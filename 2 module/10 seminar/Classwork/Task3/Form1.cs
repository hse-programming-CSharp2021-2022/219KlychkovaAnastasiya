using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int mode = 2;

        private void buttonSize_Click(object sender, EventArgs e)
        {
            if(mode == 1)
            {
                if(this.Size.Width + 20 < this.MaximumSize.Width &&
                    this.Size.Height + 20 < this.MaximumSize.Height)
                {
                    this.Size = new Size(this.Size.Width + 20, this.Size.Height + 20);
                }
                else
                {
                    this.Size = this.MaximumSize;
                    mode = 2;
                    buttonSize.Text = "Уменьшить форму";
                }
            }

            if(mode == 2)
            {
                if (this.Size.Width - 20 > this.MinimumSize.Width &&
                    this.Size.Height - 20 > this.MinimumSize.Height)
                {
                    this.Size = new Size(this.Size.Width - 20, this.Size.Height - 20);
                }
                else
                {
                    this.Size = this.MinimumSize;
                    mode = 1;
                    buttonSize.Text = "Увеличить форму";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = this.MaximumSize;
            mode = 2;
            buttonSize.Text = "Уменьшить форму";
        }
    }
}
