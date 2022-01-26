using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lemonade_price
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "20";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "25";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "30";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "40";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "50";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "55";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "65";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "75";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
    }
}
