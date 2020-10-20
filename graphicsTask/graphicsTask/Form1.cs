﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void lineDDA(int x0, int y0, int x1, int y1)
        {
           
            //for drawing
            SolidBrush mySolidBrush = new SolidBrush(Color.DarkCyan);
            //var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();
            
           //for algorithm 
            int dx = x1 - x0, dy = y1 - y0, steps, k;
            double xIncrement, yIncrement, x = x0, y = y0;
            

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);

            xIncrement = Convert.ToDouble(dx) / Convert.ToDouble(steps);
            yIncrement = Convert.ToDouble(dy) / Convert.ToDouble(steps);
            double[] xArr = new double[steps+1];
            double[] yArr = new double[steps+1];
            xArr[0] = x;
            yArr[0] = y;

            
            for (k = 1; k <= steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
               // Console.WriteLine("{0} {1}", x, y);
                xArr[k] = x;
                yArr[k] = y;
            }


            for (k = 0; k <=steps; k++)
            {
                double xTemp, yTemp;
                xTemp = Math.Round(xArr[k]);
                yTemp = Math.Round(yArr[k]);
                Console.WriteLine("{0} {1}", Convert.ToSingle(xTemp), Convert.ToSingle(yTemp));
                g.FillRectangle(mySolidBrush, Convert.ToSingle(xTemp), Convert.ToSingle(yTemp), 3, 3);
               // g.FillRectangle(aBrush, Convert.ToSingle(xTemp), Convert.ToSingle(yTemp), 1, 1);

            }




        }



        void lineBres(int x0, int y0, int xEnd, int yEnd)
        {
            int dx = Math.Abs(xEnd - x0), dy = Math.Abs(yEnd - y0);
            int x, y, p = 2 * dy - dx;
            int twoDy = 2 * dy, twoDyMinusDx = 2 * (dy - dx);


            SolidBrush mySolidBrush = new SolidBrush(Color.Aquamarine);
            var g = panel1.CreateGraphics();

            /* Determine which endpoint to use as start position.  */
            if (x0 > xEnd)
            {
                x = xEnd; y = yEnd; xEnd = x0;
            }
            else
            {
                x = x0; y = y0;
            }

             double[] xArr = new double[300];
             double[] yArr = new double[300];
           
            //initialize all elements to 0
             Array.Clear(xArr, 0, 300);
             Array.Clear(yArr, 0, 300);
             xArr[0] = x;
             yArr[0] = y;
           
            int i = 1;
            while (x < xEnd)
            {
                x++;
                if (p < 0)
                    p += twoDy;
                else
                {
                    y++;
                    p += twoDyMinusDx;
                }
                xArr[i] = x;
                yArr[i] = y;
                i++;
              
            }
            int k;
            for (k = 0; k < xArr.Length ; k++)
            {
                double xTemp, yTemp;
                xTemp = Math.Round(xArr[k]);
                yTemp = Math.Round(yArr[k]);

                if (xArr[k] == 0 && yArr[k] == 0 && k != 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("{0} {1}", Convert.ToSingle(xTemp),Convert.ToSingle(yTemp));
                    g.FillRectangle(mySolidBrush, Convert.ToSingle(xTemp), Convert.ToSingle(yTemp), 3, 3);
                }
               
            }


        }




        private void button1_Click(object sender, EventArgs e)
        {
            int x0, x1, y0, y1;
            x0 = Convert.ToInt32(x0textBox.Text);
            x1 = Convert.ToInt32(x1textBox.Text);
            y0 = Convert.ToInt32(y0textBox.Text);
            y1 = Convert.ToInt32(y1textBox.Text);

            lineDDA(x0, y0, x1, y1);
           // lineBres(x0, y0, x1, y1);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}