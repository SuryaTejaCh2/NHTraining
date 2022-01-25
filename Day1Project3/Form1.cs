using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day1Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstNumber, secondNumber, result=0;

            firstNumber = Convert.ToInt32(textBox1.Text);
            secondNumber = Convert.ToInt32(textBox2.Text);

            result = firstNumber + secondNumber;
            textBox3.Text = result.ToString();
        }
    }
}
