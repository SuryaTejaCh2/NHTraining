using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day1Project4
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

        private void button1_Click(object sender, EventArgs e)
        {
            int firstNumber, secondNumber, power=1;

            firstNumber = Convert.ToInt32(textBox1.Text);
            secondNumber = Convert.ToInt32(textBox2.Text);

            for (int i = 1; i <= secondNumber; i++)
            {
                power = power * firstNumber;
            }
            textBox3.Text = power.ToString();
        }
    }
}
