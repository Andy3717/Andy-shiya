using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       
        private void button1_Click(object sender, EventArgs e)
        {
            string Input1 = "";
            string Input2 = "";

            Input1 = textBox1.Text;
            double num1 = 0;
            //if (Input1==string.NaN)
            //{
            //    MessageBox.Show("请在第一个框中输入数字");
            //    Input1 = textBox1.Text;
            //}
            if (!double.TryParse(Input1, out num1))
            {
                MessageBox.Show("请输入有效的数字");
                Input1 = textBox1.Text;
            }
            else
            {
                Input1 = textBox1.Text;
            }            

            Input2 = textBox2.Text;
            double num2 = 0;
            if (!double.TryParse(Input2, out num2))
            {
                MessageBox.Show("请输入有效的数字");
                Input2 = textBox2.Text;
            }
            else
            {
                Input2 = textBox2.Text;
            }
          
            if (radioButton1.Checked)
            {               
                textBox3.Text = (num1 + num2).ToString();
            }
            else if (radioButton2.Checked)
            {
                textBox3.Text = (num1 - num2).ToString();
            }
            else if (radioButton3.Checked)
            {
                textBox3.Text = (num1 * num2).ToString();
            }
            else if (radioButton4.Checked)
            {
                if (num2 == 0)
                {
                    MessageBox.Show("请输入非零数");
                }
                textBox3.Text = (num1 / num2).ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
