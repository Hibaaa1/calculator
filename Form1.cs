using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=int.Parse(textBox1.Text);
            int b=int.Parse(textBox2.Text);
            int c;
            
            if(radioButton1.Checked)
            {
                c = a + b;
                label5.Text = "Sum = " + c.ToString();
            }

            if (radioButton2.Checked)
            {
                c = a - b;
                label5.Text = "Difference = " + c.ToString();
            }

            if (radioButton3.Checked)
            {
                c = a * b;
                label5.Text = "Product = " + c.ToString();
            }

            if (radioButton4.Checked)
            {
                c = a / b;
                label5.Text = "Quotient = " + c.ToString();
            }
            
            if (radioButton5.Checked)
            {
                c = a % b;
                label5.Text = "Modulus = " + c.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
