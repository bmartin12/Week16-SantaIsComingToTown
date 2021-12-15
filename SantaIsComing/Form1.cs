using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantaIsComing
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int santaSpeed = 6;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ground_Click(object sender, EventArgs e)
        {

        }

        private void ScoreBoard_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Snowflake_Click(object sender, EventArgs e)
        {

        }

        private void Moon_Click(object sender, EventArgs e)
        {

        }

        private void Tree_Click(object sender, EventArgs e)
        {

        }

        private void Hut_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Santa.Top += gravity;
            Snowflake.Left -= santaSpeed;
            Moon.Left -= santaSpeed;
            Hut.Left -= santaSpeed;
            Tree.Left -= santaSpeed;
            ScoreBoard.Text = $"score : {score}";

            if (Moon.Left < -80)
            {
                Moon.Left = 500;
                score++;
            }

            if (Hut.Left < -100)
            {
                Hut.Left = 600;
                score++;
            }

            if (Tree.Left < -100)
            {
                Hut.Left = 600;
                score++;
            }

            if (Santa.Top < -25)
            {
                GameOver();
            }

            if (Santa.Bounds.IntersectsWith(Moon.Bounds) || Santa.Bounds.IntersectsWith(Hut.Bounds) || Santa.Bounds.IntersectsWith(Ground.Bounds))
            {
                GameOver();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }

        }

        private void GameOver()
        {
            timer1.Stop();
            ScoreBoard.Text = $"Game over!";
            PlayAgain.Visible = true;
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
