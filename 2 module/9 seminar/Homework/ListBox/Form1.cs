using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string[] reservCopy = { "Всё тихо — полная луна", "Блестит меж ветел над прудом,", "И возле берега волна", "С холодным резвится лучом." };
        private void Form1_Load(object sender, EventArgs e)
        {
            poem.Items.AddRange(reservCopy);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(poem.SelectedItems.Count != 0)
                poem.Items.Remove(poem.SelectedItem);
            else
            {
                MessageBox.Show("Список пуст или нет выделенного элемента");
            }
        }

        private void recoverButton_Click(object sender, EventArgs e)
        {
            poem.Items.Clear();
            poem.Items.AddRange(reservCopy);
        }
    }
}
