using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_15
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        double k = 1.5;
        int m1 = 90;
        int m2 = 90;

        Color color = Color.Blue;
        double width = 0.5f;
        int r = 200;
        int g = 200;
        int b = 0;

        bool random = false;
        Random MyRandom = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (graphics == null) graphics = this.CreateGraphics();
            graphics.Clear(Form1.DefaultBackColor);
            if (random || Double.TryParse(valueOfK.Text, out k))
                drawCayleyTree(8, 500, 600, 100, -Math.PI / 2, k);
            else
            {
                valueOfK.Text = "请输入合适的小数！";
                drawCayleyTree(8, 500, 600, 100, -Math.PI / 2, k);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            random = true;
            k = MyRandom.NextDouble() * 4 + 0.2;
            width = MyRandom.NextDouble() * 5;
            m1 = MyRandom.Next(5, 175);
            m2 = MyRandom.Next(5, 175);

            valueOfK.Text = k.ToString();
            Angel1.Text = m1.ToString();
            Angle2.Text = m2.ToString();
            whatwidth.Text = width.ToString();
            red.Text = r.ToString();
            green.Text = g.ToString();
            blue.Text = b.ToString();

            button1_Click(sender, e);


            random = false;
        }
        void drawCayleyTree(int n, double x0, double y0, double leng, double th, double k)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            double x2 = x0 + leng * k * Math.Cos(th);
            double y2 = y0 + leng * k * Math.Sin(th);

            drawLine(x0, y0, x1, y1);
            drawLine(x0, y0, x2, y2);

            if (!random)
            {
                if (!(Int32.TryParse(Angel1.Text, out m1) &&
                    Int32.TryParse(Angle2.Text, out m2)))
                {

                    Angle2.Text = Angel1.Text = "请输入合适的整数";
                }

            }

            th1 = m1 * Math.PI / 180;
            th2 = m2 * Math.PI / 180;

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1, k);
            drawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2, k);


        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            if (!random)
            {
                if (!(Int32.TryParse(red.Text, out r) &&
                    Int32.TryParse(green.Text, out g) &&
                    Int32.TryParse(blue.Text, out b) &&
                    colorAgb(r) && colorAgb(g) && colorAgb(b)
                    ))
                {
                    red.Text = "0";
                    green.Text = " -";
                    blue.Text = "255";
                }
                if(!Double.TryParse(whatwidth.Text, out width))
                    whatwidth.Text = "请输入小数"; 




            }
            else
            {
                r = MyRandom.Next(0, 255);
                g = MyRandom.Next(0, 255);
                b = MyRandom.Next(0, 255);
            }

            color = Color.FromArgb(r, g, b);
            Pen pen = new Pen(color, (float)width);
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        bool colorAgb(int n)
        {
            if (n >= 0 && n <= 255) return true; else return false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Angel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void valueOfK_TextChanged(object sender, EventArgs e)
        {

        }

        private void whatcolor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            graphics.Clear(Form1.DefaultBackColor);
            red.Text =
            green.Text =
            blue.Text =
            valueOfK.Text =
            Angel1.Text =
            Angle2.Text =
            whatwidth.Text = "";
        }
    }
}
