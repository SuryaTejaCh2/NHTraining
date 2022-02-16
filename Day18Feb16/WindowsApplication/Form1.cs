using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatheMatics;

namespace WindowsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Algebra all = new Algebra();

            int n = Convert.ToInt32(textBox1.Text);
            int fact = all.Factorial(n);

            textBox2.Text = fact.ToString();

        }
    }
}
