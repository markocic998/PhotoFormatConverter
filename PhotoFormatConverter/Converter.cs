using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoFormatConverter
{
    static class Converter
    {
        public static void Convert(List<string> fileNames)
        {
            foreach (string file in fileNames)
            {
                MessageBox.Show(file);
            }
        }
    }
}
