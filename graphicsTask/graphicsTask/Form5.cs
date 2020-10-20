using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphicsTask
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        public void Ellipse(int rx, int ry, int xc, int yc)
        {
            double rxx = Math.Sqrt(rx);
            double ryy = Math.Sqrt(ry);
            double xend = Math.Sqrt(xc);
            double yend = Math.Sqrt(yc);

            //var aBrush = Brushes.Black;
            SolidBrush mySolidBrush = new SolidBrush(Color.Aquamarine);
            var g = panel1.CreateGraphics();

            double x, y;
            double p;

            x = 0;
            y = ryy;
            p = (ryy * ryy) - (rxx * rxx * ryy) + ((rxx * rxx) / 4);

            while ((2 * x * ryy * ryy) < (2 * y * rxx * rxx))
            {
                g.FillRectangle(mySolidBrush, (float)xend + (float)x, (float)yend - (float)y, 3, 3);
                g.FillRectangle(mySolidBrush, (float)xend - (float)x, (float)yend + (float)y, 3, 3);
                g.FillRectangle(mySolidBrush, (float)xend + (float)x, (float)yend + (float)y, 3, 3);
                g.FillRectangle(mySolidBrush, (float)xend - (float)x, (float)yend - (float)y, 3, 3);

                if (p < 0)
                {
                    x = x + 1;
                    p = p + (2 * ryy * ryy * x) + (ryy * ryy);
                }
                else
                {
                    x = x + 1;
                    y = y - 1;
                    p = p + (2 * ryy * ryy * x + ryy * ryy) - (2 * rxx * rxx * y);
                }
            }
            p = ((float)x + 0.5) * ((float)x + 0.5) * ryy * ryy + (y - 1) * (y - 1) * rxx * rxx - rxx * rxx * ryy * ryy;

            while (y >= 0)
            {
                g.FillRectangle(mySolidBrush, (float)xend + (float)x, (float)yend - (float)y, 3, 3);
                g.FillRectangle(mySolidBrush, (float)xend - (float)x, (float)yend + (float)y, 3 ,3);
                g.FillRectangle(mySolidBrush, (float)xend + (float)x, (float)yend + (float)y, 3, 3);
                g.FillRectangle(mySolidBrush, (float)xend - (float)x, (float)yend - (float)y, 3, 3);

                if (p > 0)
                {
                    y = y - 1;
                    p = p - (2 * rxx * rxx * y) + (rxx * rxx);

                }
                else
                {
                    y = y - 1;
                    x = x + 1;
                    p = p + (2 * ryy * ryy * x) - (2 * rxx * rxx * y) - (rxx * rxx);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(xTxtBox.Text);
            int y = int.Parse(yTxtBox.Text);
            int x2 = int.Parse(x2TxtBox.Text);
            int y2 = int.Parse(y2TxtBox.Text);

            Ellipse(x, y, x2, y2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }

    
    }
}
