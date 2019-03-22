using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _184988Drawing
{
    class DrawingHelper
    {
        private Canvas c = new Canvas();
        private Rectangle r = new Rectangle();

        public DrawingHelper(Canvas C, double X, double Y, double W, double H, Brush colour, string Shape)
        {
            if (Shape == "Rectangle")
            {
                C.Children.Add(r);
                Canvas.SetTop(r, Y);
                Canvas.SetLeft(r, X);
                r.Width = W;
                r.Height = H;
                r.Fill = colour;
            }

        }
    }
}
