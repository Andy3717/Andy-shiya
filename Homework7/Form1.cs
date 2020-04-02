using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.7;
        double per2 = 0.7;
        int depth = 0;
        private double length = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(depth, 230, 370, length, -Math.PI / 2);
        }
        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            Color col;
            col = colorDialog1.Color;
            int red = col.R;
            int green = col.G;
            int blue = col.B;
            Pen color = new Pen(Color.FromArgb(red, green, blue));//自定义RGB
            graphics.DrawLine(color, (int)x0, (int)y0, (int)x1, (int)y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1 / 100);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2 / 100);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            per1 = double.Parse(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            per2 = double.Parse(textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            th1 = double.Parse(trackBar1.Value.ToString());
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            th2 = double.Parse(trackBar2.Value.ToString());
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            depth = int.Parse(numericUpDown1.Value.ToString());
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            length = int.Parse(numericUpDown2.Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            graphics.Clear(Form1.DefaultBackColor);
            graphics.Dispose();
        }
    }
}