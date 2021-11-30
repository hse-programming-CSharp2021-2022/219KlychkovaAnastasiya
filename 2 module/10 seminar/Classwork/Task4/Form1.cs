using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Point templocation = new Point(0, 0);
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button.Visible == true)
            {
                button.Visible = false;
            }
            else
            {
                templocation.X = rnd.Next(12, 266);
                templocation.Y = rnd.Next(12, 249);
                button.Location = templocation;
                button.Visible = true;
            }
        }
        Rate player1;
        Rate player2;
        Rate CurrentRate;
        private void Form1_Load(object sender, EventArgs e)
        {
            player1 = new Rate();
            player2 = new Rate();
            CurrentRate = player1;
            labelHits.Text = CurrentRate.Hits.ToString();
            labelFail.Text = CurrentRate.Fails.ToString();
            MessageBox.Show("Цель игры пока кнопка видна, кликать по ней мышью.\n" +
                "Клики по кнопки учитываются как попадания, клики мимо – промахи.\n" +
                "Игра рассчитана на двух игроков, для каждого ведется отдельный счет.\n" +
                "По умолчанию первым играет первый игрок, чтобы сменить игрока выберите соответствующий пункт в выпадающем меню.\n" +
                "Игроки могут меняться любое количество раз, при этом счет сохраняется.\n" +
                "Чтобы узнать результат и обнулить счет, нажмите кнопку \"Результат\"." +
                "Побеждает игрок с наибольшим количеством баллов, где баллы = попадания - промахи","Правила");
            timer1.Start();
        }

        private void button_Click(object sender, EventArgs e)
        {
            CurrentRate.Hits++;
            labelHits.Text = CurrentRate.Hits.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                CurrentRate = player1;
                labelHits.Text = CurrentRate.Hits.ToString();
                labelFail.Text = CurrentRate.Fails.ToString();
            }
            else
            {
                CurrentRate = player2;
                labelHits.Text = CurrentRate.Hits.ToString();
                labelFail.Text = CurrentRate.Fails.ToString();
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            CurrentRate.Fails++;
            labelFail.Text = CurrentRate.Fails.ToString();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            int points1 =(int)player1.Hits - (int)player1.Fails;
            int points2 = (int)player2.Hits - (int)player2.Fails;

            MessageBox.Show($"Победил игрок {(points1 > points2 ? '1' : '2')}.\n" +
                $"Игрок 1\n\tПопадения: {player1.Hits}\tПромахи: {player1.Fails}\n" +
                $"Игрок 2\n\tПопадения: {player2.Hits}\tПромахи: {player2.Fails}","Результат");
            player1.Hits = 0;
            player1.Fails = 0;
            player2.Hits = 0;
            player2.Fails = 0;
            labelHits.Text = CurrentRate.Hits.ToString();
            labelFail.Text = CurrentRate.Fails.ToString();
        }

    }
}
