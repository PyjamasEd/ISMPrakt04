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
    public partial class For5 : Form
    {
        public For5()
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
            int N = Convert.ToInt32(textBox1.Text);
            if (N >0)
            { 
            For.factorial(N);
            textBox2.Text = For.factorial(N).ToString();
            }
            else
            {
                MessageBox.Show("Помилка");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
