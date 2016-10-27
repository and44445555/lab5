using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string s;
        double a;
        double b;
        double c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            c = a - b;
            textBox31.Text = Convert.ToString(c);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            s = textBox11.Text;
            a = Convert.ToDouble(s);
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            s = textBox21.Text;
            b = Convert.ToDouble(s);
        }
    }
}
