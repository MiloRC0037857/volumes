using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volumes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double radius;

            try
            {
                radius = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                radius = 0.0;
            }
            double sa = 4 * Math.PI * (radius * radius);

            label1.Text = "Surface Area = " + sa;


        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double radius;

            try
            {
                radius = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                radius = 0.0;
            }
            double vol = ((4.0 / 3.0) * Math.PI) * (radius * (radius * radius));

            label2.Text = "Volume = " + vol;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double radius;

            try
            {
                radius = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                radius = 0.0;
            }

            double sac = ;

            label3.Text = "Surface Area = " + sac;

            double height;

            try
            { 
                height = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                height = 0.0;
            }
            
        }
    }
}
