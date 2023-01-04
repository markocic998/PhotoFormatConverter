using System.Linq;
using System.Windows.Forms;

namespace PhotoFormatConverter
{
    public partial class PhotoFormatConverter : Form
    {
        public PhotoFormatConverter()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "My Image Browser";
                ofd.Filter = "Image Files|" + Constants.ImageFiles;
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    SelectedFilesOrFolderText.Text = DetermineSelectedFilesText(ofd.FileNames);
                }
            }

        }

        private void FolderBrowserButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = FindImageFilesInFolder(fbd.SelectedPath);
                    SelectedFilesOrFolderText.Text = DetermineSelectedFilesText(files);
                }
            }
        }

        private string DetermineSelectedFilesText(string[] files)
        {
            string text = "";
            foreach (string file in files)
            {
                text += file + "\r\n";
            }
            return text.Length > 0 ? text.Substring(0, text.Length - 1) : text;
        }

        private string[] FindImageFilesInFolder(string folderPath)
        {
            return Directory.GetFiles(folderPath).Where(file => {
                string fileLowerCase = file.ToLower();
                return fileLowerCase.EndsWith(Constants.BmpFile) ||
                       fileLowerCase.EndsWith(Constants.JpgFile) ||
                       fileLowerCase.EndsWith(Constants.PngFile) ||
                       fileLowerCase.EndsWith(Constants.GifFile);
            }).ToArray();
        }
    }
}