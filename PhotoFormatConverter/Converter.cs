using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace PhotoFormatConverter
{
    class ConversionInfo
    {
        private Resolution resolution;
        private ImageFormat imageFormat;
        private bool shouldPreserveAspectRatio;
        private InterpolationMode interpolationMode;
        private SmoothingMode smoothingMode;
        private PixelOffsetMode pixelOffsetMode;
        private CompositingQuality compositingQuality;
        public ConversionInfo(Resolution resolution, ImageFormat imageFormat, bool shouldPreserveAspectRatio, InterpolationMode interpolationMode, SmoothingMode smoothingMode, PixelOffsetMode pixelOffsetMode, CompositingQuality compositingQuality)
        {
            this.resolution = resolution;
            this.imageFormat = imageFormat;
            this.shouldPreserveAspectRatio = shouldPreserveAspectRatio;
            this.interpolationMode = interpolationMode;
            this.smoothingMode = smoothingMode;
            this.pixelOffsetMode = pixelOffsetMode;
            this.compositingQuality = compositingQuality;
        }

        public Resolution Resolution()
        {
            return this.resolution;
        }

        public ImageFormat ImageFormat()
        {
            return this.imageFormat;
        }

        public bool ShouldPreserveAspectRatio()
        {
            return this.shouldPreserveAspectRatio;
        }

        public InterpolationMode InterpolationMode()
        {
            return this.interpolationMode;
        }

        public SmoothingMode SmoothingMode()
        {
            return this.smoothingMode;
        }

        public PixelOffsetMode PixelOffsetMode()
        {
            return this.pixelOffsetMode;
        }

        public CompositingQuality CompositingQuality()
        {
            return this.compositingQuality;
        }
    }

    static class Converter
    {
        public static List<string> ConvertImage(List<string> fileNames, ConversionInfo conversionInfo, ProgressBar progressBar)
        {
            List<string> newFilePaths = new List<string>();
            if (fileNames.Count == 0) { return newFilePaths; }
            Random rnd = new Random();
            string nonce = rnd.Next(1000).ToString();
            progressBar.Value = 0;
            int progressStep = Convert.ToInt32(Constants.ProgressBarMaxValue / fileNames.Count);
            string path = Path.GetDirectoryName(fileNames[0]) + "\\IMAGES\\";
            Directory.CreateDirectory(path);
            int chosenWidth = conversionInfo.Resolution().Width();
            int chosenHeight = conversionInfo.Resolution().Height();
            foreach (string file in fileNames)
            {
                Image image = Image.FromFile(file);
                Bitmap bitmap = new Bitmap(image, new Size(chosenWidth, chosenHeight));
                Graphics graphic = Graphics.FromImage(bitmap);

                graphic.InterpolationMode = conversionInfo.InterpolationMode();
                graphic.SmoothingMode = conversionInfo.SmoothingMode();
                graphic.PixelOffsetMode = conversionInfo.PixelOffsetMode();
                graphic.CompositingQuality = conversionInfo.CompositingQuality();

                if (conversionInfo.ShouldPreserveAspectRatio())
                {
                    int inputWidth = image.Width;
                    int inputHeight = image.Height;

                    double ratioX = (double)chosenWidth / (double)inputWidth;
                    double ratioY = (double)chosenHeight / (double)inputHeight;
                    double ratio = ratioX < ratioY ? ratioX : ratioY;

                    int outputWidth = Convert.ToInt32(inputWidth * ratio);
                    int outputHeight = Convert.ToInt32(inputHeight * ratio);

                    int x = Convert.ToInt32((chosenWidth - (inputWidth * ratio)) / 2);
                    int y = Convert.ToInt32((chosenHeight - (inputHeight * ratio)) / 2);

                    graphic.Clear(Color.Black);
                    graphic.DrawImage(image, x, y, outputWidth, outputHeight);
                }
                else
                {
                    graphic.DrawImage(image, 0, 0, chosenWidth, chosenHeight);
                }

                string fileName = Path.GetFileNameWithoutExtension(file);
                string newPath = $"{path}{fileName}_{nonce}_{conversionInfo.InterpolationMode().ToString()}.{conversionInfo.ImageFormat().ToString().ToLower()}";
                bitmap.Save(newPath, conversionInfo.ImageFormat());
                newFilePaths.Add(newPath);
                int newValue = progressBar.Value + progressStep;
                progressBar.Value = newValue > Constants.ProgressBarMaxValue ? Constants.ProgressBarMaxValue : newValue;
            }
            progressBar.Value = Constants.ProgressBarMaxValue;
            return newFilePaths;
        }
    }
}
