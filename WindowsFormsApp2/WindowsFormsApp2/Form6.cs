using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form6 : Form
    {
        double r;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r = Convert.ToInt32(textBox1.Text);
            double A = (3.14) * r * r;
            label2.Text = "Answer=" + Convert.ToString(A);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form menu = new menu();
            menu.ShowDialog();
        }
    }
}
