using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color[] colors = { Color.BlueViolet, Color.Violet, Color.Purple, Color.Magenta, Color.DarkViolet, Color.DeepPink };
        int colorNumber = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CatLabel.Text != "")
            {
                CatLabel.Text = CatLabel.Text.Remove(CatLabel.Text.Length - 1);
                if(colorNumber>=colors.Length)
                    colorNumber = 0;
                CatLabel.ForeColor = colors[colorNumber];
                colorNumber++;
            }
            else
            {
                timer1.Stop();
                invisibleTimer.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void invisibleTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity != 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                invisibleTimer.Stop();
                CatLabel.Text = "nobody is here";
                visibleTimer.Start();
            }
        }

        private void visibleTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity != 1)
            {
                this.Opacity += 0.1;
            }
            else
            {
                visibleTimer.Stop();
            }
        }

        
    }
}
