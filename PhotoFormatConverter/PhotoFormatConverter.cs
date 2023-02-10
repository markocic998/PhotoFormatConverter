using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using Image = System.Drawing.Image;

namespace PhotoFormatConverter
{
    public partial class PhotoFormatConverter : Form
    {
        private List<Resolution> resolutionList = new List<Resolution>();
        private List<string> selectedFilesList = new List<string>();

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
        }

        private void InitializeControls()
        {
            ChooseResolutionComboBox.SelectedIndex = 0;
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
                    InitListBox(ofd.FileNames);
                    ClearOnLoadingFiles();
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
                    string[] fileNameList = FindImageFilesInFolder(fbd.SelectedPath);
                    InitListBox(fileNameList);
                    ClearOnLoadingFiles();
                }
            }
        }

        private void ClearOnLoadingFiles()
        {
            ClearSelectedFilesList();
            ClearPictureBox();
            ClearSelectAllCheckBox();
        }

        private void InitListBox(object[] items)
        {
            LoadedFilesListBox.Items.Clear();
            LoadedFilesListBox.Items.AddRange(items);
        }

        private void ClearSelectedFilesList()
        {
            this.selectedFilesList = new List<string>();
        }

        private void ClearSelectAllCheckBox()
        {
            SelectAllCheckBox.Checked = false;
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

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (this.selectedFilesList.Count > 0)
            {
                ConversionInfo conversionInfo = DetermineConversionInfo();
                Converter.ConvertImage(this.selectedFilesList, conversionInfo, this.progressBar);
                MessageBox.Show("Conversion of selected files is done.");
                this.progressBar.Value = 0;
            } else
            {
                MessageBox.Show("There are no selected files yet. Please select files.");
            }
        }

        private ConversionInfo DetermineConversionInfo()
        {
            Resolution newResolution = this.resolutionList[ChooseResolutionComboBox.SelectedIndex];
            ImageFormat imageFormat = bmpRadioButton.Checked ? ImageFormat.Bmp : ImageFormat.Jpeg;
            bool shouldPreserveAspectRatio = preserveAspectRatioCheckBox.Checked;
            InterpolationMode interpolationMode;
            SmoothingMode smoothingMode;
            PixelOffsetMode pixelOffsetMode;
            CompositingQuality compositingQuality;
            if (lowQualityRadioButton.Checked)
            {
                interpolationMode = InterpolationMode.NearestNeighbor;
                smoothingMode = SmoothingMode.HighSpeed;
                pixelOffsetMode = PixelOffsetMode.HighSpeed;
                compositingQuality = CompositingQuality.HighSpeed;

            }
            else if (normalQualityRadioButton.Checked)
            {
                interpolationMode = InterpolationMode.Bilinear;
                smoothingMode = SmoothingMode.Default;
                pixelOffsetMode = PixelOffsetMode.Half;
                compositingQuality = CompositingQuality.Default;
            }
            else
            {
                interpolationMode = InterpolationMode.HighQualityBicubic;
                smoothingMode = SmoothingMode.HighQuality;
                pixelOffsetMode = PixelOffsetMode.HighQuality;
                compositingQuality = CompositingQuality.HighQuality;
            }
            return new ConversionInfo(newResolution, imageFormat, shouldPreserveAspectRatio, interpolationMode, smoothingMode, pixelOffsetMode, compositingQuality);
        }

        private void LoadedFilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedFilesList = LoadedFilesListBox.SelectedItems.Cast<string>().ToList();
            ResolveSelectAllCheckBox();
            ResolveImagePreviewPictureBox();
        }

        private void ResolveSelectAllCheckBox()
        {
            if (IsNumberOfLoadedAndSelectedFilesTheSame())
            {
                if (!SelectAllCheckBox.Checked)
                {
                    SelectAllCheckBox.Checked = true;
                }
            }
            else
            {
                if (SelectAllCheckBox.Checked)
                {
                    SelectAllCheckBox.Checked = false;
                }
            }
        }

        private void ResolveImagePreviewPictureBox()
        {
            if (this.selectedFilesList.Count == 1)
            {
                ImagePreviewPictureBox.Image = Image.FromFile(this.selectedFilesList.First());
            }
            else
            {
                ClearPictureBox();
            }
        }

        private void ClearPictureBox()
        {
            ImagePreviewPictureBox.Image = null;
        }

        private void SelectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAllCheckBox.Checked)
            {
                if (!IsNumberOfLoadedAndSelectedFilesTheSame())
                {
                    for (int i = 0; i < LoadedFilesListBox.Items.Count; i++)
                    {
                        LoadedFilesListBox.SetSelected(i, true);
                    }
                }
            }
            else
            {
                if (IsNumberOfLoadedAndSelectedFilesTheSame())
                {
                    LoadedFilesListBox.ClearSelected();
                }
            }
        }

        private bool IsNumberOfLoadedAndSelectedFilesTheSame()
        {
            return LoadedFilesListBox.Items.Count == LoadedFilesListBox.SelectedItems.Count;
        }
    }
}