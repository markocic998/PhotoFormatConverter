﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoFormatConverter
{
    class Resolution 
    {
        private int width;
        private int height;
        public Resolution(int width, int height) 
        {
            this.width = width;
            this.height = height;
        }
        public int Width()
        {
            return width;
        }

        public int Height()
        {
            return height;
        }
    }

    static class Constants
    {
        public const string BmpFile = ".bmp";
        public const string JpgFile = ".jpg";
        public const string PngFile = ".png";
        public const string GifFile = ".gif";
        public const string ImageFiles = "*.bmp;*.jpg;*.png;*.gif;";
        public const string NoFiles = "There are no selected files yet.";
    }
}
