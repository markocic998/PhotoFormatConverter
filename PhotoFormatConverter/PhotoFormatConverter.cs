using System.Linq;
using System.Windows.Forms;

namespace PhotoFormatConverter
{
    public partial class PhotoFormatConverter : Form
    {
        private List<Resolution> resolutionList = new List<Resolution>();
        private Resolution? selectedResolution;

        public PhotoFormatConverter()
        {
            InitializeComponent();
            InitializeResolutions();
            InitializeControls();
        }

        private void InitializeResolutions()
        {
            this.resolutionList.Add(new Resolution(720, 480));
            this.resolutionList.Add(new Resolution(720, 576));
            this.resolutionList.Add(new Resolution(800, 600));
            this.resolutionList.Add(new Resolution(1024, 768));
            this.resolutionList.Add(new Resolution(1280, 720));
            this.resolutionList.Add(new Resolution(1280, 768));
            this.resolutionList.Add(new Resolution(1280, 800));
            this.resolutionList.Add(new Resolution(1280, 960));
            this.resolutionList.Add(new Resolution(1280, 1024));
            this.resolutionList.Add(new Resolution(1366, 768));
            this.resolutionList.Add(new Resolution(1600, 900));
            this.resolutionList.Add(new Resolution(1920, 1080));
            this.resolutionList.Add(new Resolution(1920, 1200));
            this.resolutionList.Add(new Resolution(2560, 1440));
            this.resolutionList.Add(new Resolution(3440, 1440));
            this.resolutionList.Add(new Resolution(3840, 2160));

            this.selectedResolution = this.resolutionList[0];
            ChooseResolutionComboBox.SelectedIndex = 0;
        }

        private void InitializeControls()
        {
            
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

        private void ChooseResolutionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedResolution = this.resolutionList[ChooseResolutionComboBox.SelectedIndex];
        }
    }
}