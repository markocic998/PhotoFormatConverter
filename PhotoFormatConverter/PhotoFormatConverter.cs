using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PhotoFormatConverter
{
    public partial class PhotoFormatConverter : Form
    {
        private List<Resolution> resolutionList = new List<Resolution>();
        private List<string> fileNameList = new List<string>();

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
                    this.fileNameList = new List<string>(ofd.FileNames);
                    SelectedFilesOrFolderText.Text = DetermineSelectedFilesText(this.fileNameList);
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
                    this.fileNameList = FindImageFilesInFolder(fbd.SelectedPath);
                    string text = DetermineSelectedFilesText(this.fileNameList);
                    SelectedFilesOrFolderText.Text = text == "" ? Constants.NoFiles : text;
                }
            }
        }

        private string DetermineSelectedFilesText(List<string> files)
        {
            string text = "";
            foreach (string file in files)
            {
                text += file + "\r\n";
            }
            return text.Length > 0 ? text.Substring(0, text.Length - 1) : text;
        }

        private List<string> FindImageFilesInFolder(string folderPath)
        {
            return Directory.GetFiles(folderPath).Where(file => {
                string fileLowerCase = file.ToLower();
                return fileLowerCase.EndsWith(Constants.BmpFile) ||
                       fileLowerCase.EndsWith(Constants.JpgFile) ||
                       fileLowerCase.EndsWith(Constants.PngFile) ||
                       fileLowerCase.EndsWith(Constants.GifFile);
            }).ToList();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (this.fileNameList.Count > 0)
            {
                Resolution newResolution = this.resolutionList[ChooseResolutionComboBox.SelectedIndex];
                ImageFormat imageFormat = bmpRadioButton.Checked ? ImageFormat.Bmp : ImageFormat.Jpeg;
                Converter.ConvertImage(this.fileNameList, newResolution, imageFormat, this.progressBar);
                MessageBox.Show("Conversion of selected files is done.");
                this.progressBar.Value = 0;
            } else
            {
                MessageBox.Show("There are no selected files yet. Please select files.");
            }
        }
    }
}