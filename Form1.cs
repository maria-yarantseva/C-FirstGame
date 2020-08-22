using System;
using System.Media;
using System.Windows.Forms;

namespace ProjectGame
{
    public partial class Form1 : Form
    {
        public static int width = 1200;
        public static int height = 670;
        bool gameOver = false;
        bool goRight;
        bool goLeft;
        bool goUp;
        bool goDown;
        int magicCount = 10;
        int speed = 7;
        double health = 100;
        int score = 0;
        int mSpeed = 2;
        string bulletDirection = "up";
        int holes = 1;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (gameOver)
            {
                label6.Text = "Ты проиграл";
                label6.BringToFront();
                label7.Text = "Нажмите вверх, чтобы завершить игру";
                label7.BringToFront();
            }
            else MakeHole();
            if (e.KeyCode == Keys.Up && gameOver)
                Application.Exit();
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                bulletDirection = "right";
                player.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                bulletDirection = "up";
                player.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                bulletDirection = "left";
                player.Image = Properties.Resources.left;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                bulletDirection = "down";
                player.Image = Properties.Resources.down;
            }
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                goRight = false;
            if (e.KeyCode == Keys.Left)
                goLeft = false;
            if (e.KeyCode == Keys.Down)
                goDown = false;
            if (e.KeyCode == Keys.Up)
                goUp = false;
            if ((e.KeyCode == Keys.Space) && (magicCount > 0))
            {
                magicCount--;
                UseMagic(bulletDirection);
                if (magicCount < 1)
                    NeedMagic();
            }
        }

        private void Game(object sender, EventArgs e)
        {
            if (gameOver)
                label6.Text = "Ты проиграл";
            label7.Text = "";
            label6.Text = "";
            if (health > 1)
                progressBar1.Value = Convert.ToInt32(health);
            else
            {
                player.Image = Properties.Resources.dead;
                timer1.Stop();
                gameOver = true;
                magicCount = 0;
            }
            label1.Text = " Energy: " + magicCount;
            label4.Text = "Kills: " + score;
            if (goUp&& player.Top > 60)
                player.Top -= speed;
            if (goLeft && player.Left > 0)
                player.Left -= speed;
            if (goRight && player.Left + player.Width < width)
                player.Left += speed;
            if (goDown && player.Top + player.Height < height)
                player.Top += speed;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "magic")
                    if (((PictureBox)x).Left < 1 || ((PictureBox)x).Left > width - 40
                        || ((PictureBox)x).Top < 1 || ((PictureBox)x).Top > height - 30)
                    {
                        this.Controls.Remove(((PictureBox)x));
                        ((PictureBox)x).Dispose();
                    }
                if (x is PictureBox && x.Tag == "magicBox")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        this.Controls.Remove(((PictureBox)x));
                        ((PictureBox)x).Dispose();
                        magicCount += 5;
                        health += 15;
                        if (health >= 100)
                            health = 100;
                    }
                }

                if (x is PictureBox && x.Tag == "hole")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        timer1.Stop();
                        gameOver = true;
                        player.Image = Properties.Resources.dead;
                        magicCount = 0;
                    }
                }

                if (x is PictureBox && x.Tag == "monster")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        health -= 0.5;
                    }
                    if (((PictureBox)x).Left < player.Left)
                    {
                        ((PictureBox)x).Left += mSpeed;
                        ((PictureBox)x).Image = Properties.Resources.mright;
                    }
                    if (((PictureBox)x).Left > player.Left)
                    {
                        ((PictureBox)x).Left -= mSpeed;
                        ((PictureBox)x).Image = Properties.Resources.mleft;
                    }
                    if (((PictureBox)x).Top < player.Top)
                    {
                        ((PictureBox)x).Top += mSpeed;
                        ((PictureBox)x).Image = Properties.Resources.mdown;
                    }
                    if (((PictureBox)x).Top > player.Top)
                    {
                        ((PictureBox)x).Top -= mSpeed;
                        ((PictureBox)x).Image = Properties.Resources.mup;
                    }
                }
                foreach (Control y in this.Controls)
                {
                    if (x is PictureBox && y is PictureBox 
                        && y.Tag == "magic" && x.Tag == "monster")
                        if (x.Bounds.IntersectsWith(y.Bounds))
                        {
                            score++;
                            this.Controls.Remove(y);
                            y.Dispose();
                            this.Controls.Remove(x);
                            x.Dispose();
                            MakeMonsters();
                        }

                    if (x is PictureBox && y is PictureBox
                        && y.Tag == "magicBox" && x.Tag == "hole")
                        if (x.Bounds.IntersectsWith(y.Bounds))
                        {
                            this.Controls.Remove(y);
                            y.Dispose();
                            NeedMagic();
                        }

                    if (x is PictureBox && y is PictureBox
                        && y.Tag == "monster" && x.Tag == "hole")
                        if (x.Bounds.IntersectsWith(y.Bounds))
                        {
                            this.Controls.Remove(y);
                            y.Dispose();
                            MakeMonsters();
                        }
                }
            }
        }

        private void UseMagic(string dir)
        {
            Magic fight = new Magic();
            fight.Direction = dir;
            fight.MagicTop = player.Top + (player.Height / 2);
            fight.MagicLeft = player.Left + (player.Width / 2);
            fight.MagicHit(this);
        }

        private void MakeMonsters()
        {
            PictureBox monster = new PictureBox();
            monster.Tag = "monster";
            monster.Image = Properties.Resources.mdown;
            monster.Left = random.Next(0, width);
            monster.Top = random.Next(0, height);
            monster.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(monster);
            player.BringToFront();
        }

        private void NeedMagic()
        {
            PictureBox magic = new PictureBox();
            magic.Image = Properties.Resources.x5;
            magic.SizeMode = PictureBoxSizeMode.AutoSize;
            magic.Left = random.Next(0, width);
            magic.Top = random.Next(40, height - 40);
            magic.Tag = "magicBox";
            this.Controls.Add(magic);
            magic.BringToFront();
            player.BringToFront();
        }

        private void MakeHole()
        {
            if (holes > 0)
            {
                PictureBox hole = new PictureBox();
                hole.Image = Properties.Resources.hole;
                hole.SizeMode = PictureBoxSizeMode.AutoSize;
                hole.Left = random.Next(0, width - 50);
                hole.Top = random.Next(50, height - 50);
                hole.Tag = "hole";
                this.Controls.Add(hole);
                hole.BringToFront();
                player.BringToFront();
                holes--;
            }
        }
    }
}
