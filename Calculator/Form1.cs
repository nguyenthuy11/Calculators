using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
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

        private void btcong_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a=int.Parse(txta.Text);
            b=int.Parse(txtb.Text);
            c = a + b;
            txtkq.Text = c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttru_Click(object sender, EventArgs e)
        {

            int a, b, c;
            a = int.Parse(txta.Text);
            b = int.Parse(txtb.Text);
            c = a - b;
            txtkq.Text = c.ToString();
        }
    }
}
