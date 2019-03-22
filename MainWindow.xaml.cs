/*Ethan Shipston
 * ICS4U
 * A program which draws ellipses or rectangles
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _184988Drawing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Brush b;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void setColour_Click(object sender, RoutedEventArgs e)
        {
            pickColour p = new pickColour();
            p.ShowDialog();
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            string temp = txtInput.Text;
            int[] inputs = new int[4];
            for (int i = 0; i != 4; i++)
            {
                if (i != 3)
                {
                    int.TryParse(temp.Substring(0, temp.IndexOf(",")), out inputs[i]);
                    temp = temp.Remove(0, temp.IndexOf(",") + 1);
                }
                else
                {
                    int.TryParse(temp.Substring(0, temp.Length), out inputs[i]);
                }
            }
            if (rbRec.IsChecked.ToString() == "True")
            {
                temp = "Rectangle";
            }
            else if (rbRec.IsChecked.ToString() == "False")
            {
                temp = "Rectangle";
            }
            DrawingHelper DH = new DrawingHelper(canvas, inputs[0], inputs[1], inputs[2], inputs[3], b, temp);
        }
    }
}
