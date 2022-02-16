using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Surya;

namespace ClintApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mathematics m = new Mathematics();
            int input = Convert.ToInt32(textBox1.Text);
            m.input = input;
            int fact = m.GetFact();

            textBox2.Text = fact.ToString();
        }
    }
}
