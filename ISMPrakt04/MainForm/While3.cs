using System;
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
    public partial class While3 : Form
    {
        public While3()
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
            double P = Convert.ToDouble(textBox1.Text);
            While.percentDistance(P);
            While.day(P);
            textBox2.Text = While.day(P).ToString();
            textBox3.Text = While.percentDistance(P).ToString();
        }
    }
}
