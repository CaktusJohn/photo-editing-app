using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DopFilter: Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int intensity = (int)(0.299 * sourceColor.R + 0.587 * sourceColor.G + 0.114 * sourceColor.B);
            Color resultColor = Color.Black;

            if (intensity >= 0 && intensity <= 64) 
            {
                resultColor = Color.FromArgb(0, 0, 0);
                                               
            }

            else if (intensity > 64 && intensity <= 128)
            {
                resultColor = Color.FromArgb(0, 0, 255);
                                          
            }


            else if (intensity > 128 && intensity <= 192)
            {
                resultColor = Color.FromArgb(0, 255, 255);
            }

            else if (intensity > 192 && intensity <= 255)
            {
                resultColor = Color.FromArgb(255, 255, 255);
            }

            return resultColor;
        }
    }
}
