﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibClass;

namespace MainForm
{
    public partial class For3 : Form
    {
        public For3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            Hide();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            int N = Convert.ToInt32(textBox2.Text);
            if (N > 0)
            {
                For.power(a, N);
                textBox3.Text = For.power(a,N).ToString();
            }
            else
            {
                MessageBox.Show("Помилка");
            }
        }
    }
}
