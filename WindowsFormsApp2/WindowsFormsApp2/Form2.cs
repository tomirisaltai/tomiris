using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void solve_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                MessageBox.Show("Discriminant is less than zero. No roots.");
            }


            if (d == 0)
            {
                double x = (-b / (2 * a));//формула 
                MessageBox.Show("Discriminant equals to zero. Root is " + x + ".");

            }
            if (d > 0)
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                MessageBox.Show("Discriminant equals to " + d + ". First root number is " + x1 + ". Second root number is " + x2 + ".");

            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            Form menu = new menu();
            menu.ShowDialog();

        }
    }
}

