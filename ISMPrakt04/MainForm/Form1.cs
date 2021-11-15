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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void For1_Click(object sender, EventArgs e)
        {
            For1 f1 = new For1();
            Hide();
            f1.Show();
        }

        private void For2_Click(object sender, EventArgs e)
        {
            For2 f2 = new For2();
            Hide();
            f2.Show();
        }

        private void For3_Click(object sender, EventArgs e)
        {
            For3 f3 = new For3();
            Hide();
            f3.Show();
        }

        private void For4_Click(object sender, EventArgs e)
        {
            For4 f4 = new For4();
            Hide();
            f4.Show();
        }

        private void For5_Click(object sender, EventArgs e)
        {
            For5 f5 = new For5();
            Hide();
            f5.Show();
        }

        private void While2_Click(object sender, EventArgs e)
        {
            While2 w2 = new While2();
            Hide();
            w2.Show();
        }

        private void While1_Click(object sender, EventArgs e)
        {
            While1 w1 = new While1();
            Hide();
            w1.Show();
        }

        private void While3_Click(object sender, EventArgs e)
        {
            While3 w3 = new While3();
            Hide();
            w3.Show();
        }

        private void DoWhile_Click(object sender, EventArgs e)
        {
            DoWhile1 dowhile = new DoWhile1();
            Hide();
            dowhile.Show();
        }
    }
}
