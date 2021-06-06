using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematikproblemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar;
            int alan, çevre;

            birkenar = Convert.ToInt32(textBox1.Text);

            alan = birkenar * birkenar;
            çevre = birkenar * 4;

            label6.Text = alan.ToString();
            label7.Text = çevre.ToString();     }
    }
}
