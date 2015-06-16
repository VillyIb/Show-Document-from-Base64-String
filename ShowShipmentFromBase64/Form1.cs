using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ShowShipmentFromBase64
{
    public partial class Form1 : Form
    {
        private Settings1 Settings { get; set; }

        public Form1()
        {
            InitializeComponent();
            Settings = new Settings1();
            XuDirectory.Text = Settings.DirectoryName;
            XuFilename.Text = Settings.Filename;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var di = Path.GetDirectoryName(XuDirectory.Text);
                folderBrowserDialog1.SelectedPath = di;
            }
            catch (ArgumentException)
            { }

            folderBrowserDialog1.ShowDialog();

            XuDirectory.Text = folderBrowserDialog1.SelectedPath;
        }


        private void XuClose_Click(object sender, EventArgs e)
        {
            Settings.DirectoryName = XuDirectory.Text;
            Settings.Filename = XuFilename.Text;
            Settings.Save();
            Close();
        }


        private void XuExecute_Click(object sender, EventArgs e)
        {
            var text = Clipboard.GetText();
            byte[] byteArray;
            try
            {
                byteArray = Convert.FromBase64String(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Unable to dekode text as base64 string");
                var t = ex;
                return;
            }

            var extension = "hex";

            if (byteArray[0] == 37)
            {
                extension = "pdf";
            }
            else if (byteArray[0] == 137)
            {
                extension = "png";
            }

            var filename = Path.Combine(XuDirectory.Text, String.Format("{0}.{1}",XuFilename.Text, extension));

            var fi = new FileInfo(filename);
            try
            {
                using (var outputStream = fi.OpenWrite())
                {
                    outputStream.Write(byteArray, 0, byteArray.Length);
                }


                var dialogResult = MessageBox.Show(String.Format("Skrevet filen '{0}' med {1:#,##0} tegn. \r\nÅben filen ?",filename, fi.Length), @"Information", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (dialogResult.HasFlag(DialogResult.No))
                {
                    return;
                }

                Process. Start(filename);

            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
