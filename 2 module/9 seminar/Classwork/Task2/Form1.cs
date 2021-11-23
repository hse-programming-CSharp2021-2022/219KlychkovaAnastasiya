using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int p1 = 1;
        int p2 = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            int p3 = p1 + p2;
            if (p3 < 0)
            {
                MessageBox.Show("Overflow!!!");
                p1 = 1;
                p2 = 1;
            }
            else
            {
                label1.Text = p3.ToString();
                p1 = p2;
                p2 = p3;
            }
        }
    }
}
