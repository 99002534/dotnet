using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInterest_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Principal should not be blank!");
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Rate should not be blank!");
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Period should not be blank!");
            }
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            var principal = double.Parse(textBox1.Text);
            var rate = double.Parse(textBox2.Text);
            var period = double.Parse(textBox3.Text);
            //var interest = double.Parse(textBox4.Text);
            var interest = (principal * rate * period / 1200);
            var amount = principal + interest;
            textBox4.Text = interest.ToString();
            textBox5.Text = amount.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
