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
                ofd.Filter = "Image Files|*.bmp;*.jpg;*.png;*.gif;";
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
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
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
            return text.Substring(0, text.Length - 1);
        }
    }
}