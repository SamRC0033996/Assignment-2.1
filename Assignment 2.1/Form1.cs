using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2._1
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

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Calculate the total resistance of a 2 series circuit
            try
            {
                double R1, R2, RT;
                R1 = Convert.ToDouble(textBox1.Text);
                R2 = Convert.ToDouble(textBox2.Text);
                RT = R1 + R2;
                Answer1.Text = "series total resistance = " + RT;
                RT = 1 / (1 / R1 + 1 / R2);
                Answer5.Text = "parallel total resistance = " + RT;
            }
            catch
            {
                MessageBox.Show("Type in two numbers.");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Calculate the total resistance of a 3 series circuit
            try
            {
                double R1, R2, R3, RT;
                R1 = Convert.ToDouble(textBox3.Text);
                R2 = Convert.ToDouble(textBox4.Text);
                R3 = Convert.ToDouble(textBox5.Text);
                RT = R1 + R2 + R3;
                Answer2.Text = "series total resistance = " + RT;
                RT = 1 / (1 / R1 + 1 / R2 + 1 / R3);
                Answer6.Text = "parallel total resistance = " + RT;
            }
            catch
            {
                MessageBox.Show("Type in three numbers.");
            }


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Calculate the total resistance of a 4 series circuit
            try
            {
                double R1, R2, R3, R4, RT;
                R1 = Convert.ToDouble(textBox6.Text);
                R2 = Convert.ToDouble(textBox7.Text);
                R3 = Convert.ToDouble(textBox8.Text);
                R4 = Convert.ToDouble(textBox9.Text);
                RT = R1 + R2 + R3 + R4;
                Answer3.Text = "series total resistance = " + RT;
                RT = 1 / (1 / R1 + 1 / R2 + 1 / R3 + 1 / R4);
                Answer7.Text = "parallel total resistance = " + RT;
            }
            catch
            {
                MessageBox.Show("Type in four numbers.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Calculate the total resistance of a 5 series circuit
            try
            {
                double R1, R2, R3, R4, R5, RT;
                R1 = Convert.ToDouble(textBox10.Text);
                R2 = Convert.ToDouble(textBox11.Text);
                R3 = Convert.ToDouble(textBox12.Text);
                R4 = Convert.ToDouble(textBox13.Text);
                R5 = Convert.ToDouble(textBox14.Text);
                RT = R1 + R2 + R3 + R4 + R5;
                Answer4.Text = "series total resistance = " + RT;
                RT = 1 / (1 / R1 + 1 / R2 + 1 / R3 + 1 / R4 + 1 / R5);
                Answer8.Text = "parallel total resistance = " + RT;
            }
            catch
            {
                MessageBox.Show("Type in five numbers."); 
            }
        }

    }
}
