using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "...Secret...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "I love C#!!!";
        }

        Point templocation = new Point(0, 0);
        Random rnd = new Random();
        private void MagicButton_Click(object sender, EventArgs e)
        {
            MagicButton.Visible = false;
            MagicButton2.Location = templocation;
            templocation.X = rnd.Next(12, 259);
            MagicButton2.Location = templocation;
            templocation.Y = rnd.Next(12, 387);
            MagicButton2.Visible = true;
        }

        private void MagicButton2_Click(object sender, EventArgs e)
        {
            MagicButton2.Visible = false;
            MagicButton.Location = templocation;
            templocation.X = rnd.Next(12, 259);
            MagicButton.Location = templocation;
            templocation.Y = rnd.Next(12, 387);
            MagicButton.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if(textBox1.Text!="")
                    label1.Text = $"We like {textBox1.Text} too";
                else
                    label1.Text = "We like you too";
            }
            else
            {
                if (textBox1.Text != "")
                    label1.Text = $"We don't like {textBox1.Text} too";
                else
                    label1.Text = "We don't like you too";
            }
        }

    }
}
