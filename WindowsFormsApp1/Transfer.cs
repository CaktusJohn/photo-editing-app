using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    internal class Transfer : Filters
    {


        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int newX = x + 50;
            int newY = y;

     

            if (newX >= sourceImage.Width || newX < 0 || newY >= sourceImage.Height || newY < 0)
            {
                return Color.Black;
            }
            return sourceImage.GetPixel(newX, newY);


        }
    }
}
