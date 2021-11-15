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
    public partial class For4 : Form
    {
        public For4()
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
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            if (a < b)
            {
                For.Sumofsquares(a, b);
                textBox3.Text = For.Sumofsquares(a, b).ToString();
            }
            else
            {
                MessageBox.Show("Помилка");
            }
        }
    }
}
