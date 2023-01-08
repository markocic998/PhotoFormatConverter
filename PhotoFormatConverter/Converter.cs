using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PhotoFormatConverter
{
    static class Converter
    {
        public static void ConvertImage(List<string> fileNames, Resolution chosenResolution, ImageFormat imageFormat, ProgressBar progressBar)
        {
            if (fileNames.Count == 0) { return; }
            progressBar.Value = 0;
            int progressStep = Convert.ToInt32(Constants.ProgressBarMaxValue / fileNames.Count);
            string path = Path.GetDirectoryName(fileNames[0]) + "\\IMAGES\\";
            Directory.CreateDirectory(path);
            int chosenWidth = chosenResolution.Width();
            int chosenHeight = chosenResolution.Height();
            foreach (string file in fileNames)
            {
                Image image = Image.FromFile(file);
                Bitmap bitmap = new Bitmap(image, new Size(chosenWidth, chosenHeight));
                Graphics graphic = Graphics.FromImage(bitmap);

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

                string fileName = Path.GetFileNameWithoutExtension(file);
                bitmap.Save($"{path}{fileName}.{imageFormat}", imageFormat);
                int newValue = progressBar.Value + progressStep;
                progressBar.Value = newValue > Constants.ProgressBarMaxValue ? Constants.ProgressBarMaxValue : newValue;
            }
            progressBar.Value = Constants.ProgressBarMaxValue;
        }
    }
}
