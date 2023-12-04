using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace gamedemp1
{

    public partial class Form1 : Form
    {
        PictureBox[] Stars;
        Random rnd;
        int backgroundspeed;
        int playerspeed;
        PictureBox[] munitions;
        int Munitionspeed;
        PictureBox[] enemies;
        int enemiespeed;
        
        public Form1()
        {
            InitializeComponent();
             
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundspeed = 4;
            playerspeed = 4;
            Stars = new PictureBox[10];
            rnd = new Random();
            Munitionspeed = 20;
            munitions = new PictureBox[3];
            enemies = new PictureBox[5];
            enemiespeed = 20;
           /*
            for(int i=0;i<enemies.Length;i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(10, 10);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle = BorderStyle.None; ;
                this.Controls.Add(enemies[i]);
            }
           
            enemies[0].Image = Image.FromFile(@"C:\\Users\\soura\\OneDrive\\Desktop\\Csharp_practice\\New folder\\star1.png");              
            enemies[1].Image = Image.FromFile(@"C:\\Users\\soura\\OneDrive\\Desktop\\Csharp_practice\\New folder\\star2.png");
            enemies[2].Image = Image.FromFile(@"C:\\Users\\soura\\OneDrive\\Desktop\\Csharp_practice\\New folder\\E2.png");
            enemies[3].Image = Image.FromFile(@"C:\\Users\\soura\\OneDrive\\Desktop\\Csharp_practice\\New folder\\E3.png");
            enemies[4].Image = Image.FromFile(@"C:\\Users\\soura\\OneDrive\\Desktop\\Csharp_practice\\New folder\\star2.png");
            /*
            enemies[5].Image = Image.FromFile(@"C:\\Users\\soura\\OneDrive\\Desktop\\Csharp_practice\\New folder\\munition.png");

            enemies[6].Image = Image.FromFile(@"C:\\Users\\soura\\OneDrive\\Desktop\\Csharp_practice\\New folder\\munition.png");

            enemies[7].Image = Image.FromFile(@"C:\\Users\\soura\\OneDrive\\Desktop\\Csharp_practice\\New folder\\munition.png");

            enemies[8].Image = Image.FromFile(@"C:\\Users\\soura\\OneDrive\\Desktop\\Csharp_practice\\New folder\\munition.png");

            enemies[9].Image = Image.FromFile(@"C:\\Users\\soura\\OneDrive\\Desktop\\Csharp_practice\\New folder\\munition.png");

            enemies[10].Image = Image.FromFile(@"C:\\Users\\soura\\OneDrive\\Desktop\\Csharp_practice\\New folder\\munition.png");

            enemies[0].Image = Image.FromFile(@"C:\\Users\\soura\\OneDrive\\Desktop\\Csharp_practice\\New folder\\munition.png");

            enemies[0].Image = Image.FromFile(@"C:\\Users\\soura\\OneDrive\\Desktop\\Csharp_practice\\New folder\\munition.png");

            enemies[0].Image = Image.FromFile(@"C:\\Users\\soura\\OneDrive\\Desktop\\Csharp_practice\\New folder\\munition.png");

            enemies[0].Image = Image.FromFile(@"C:\\Users\\soura\\OneDrive\\Desktop\\Csharp_practice\\New folder\\munition.png");

            enemies[0].Image = Image.FromFile(@"C:\\Users\\soura\\OneDrive\\Desktop\\Csharp_practice\\New folder\\munition.png");

            enemies[0].Image = Image.FromFile(@"C:\\Users\\soura\\OneDrive\\Desktop\\Csharp_practice\\New folder\\munition.png");
            */



            Image munition = Image.FromFile(@"C:\\Users\\soura\\OneDrive\\Desktop\\Csharp_practice\\New folder\\munition.png");
            for(int i=0;i< munitions.Length;i++)
            {
                munitions[i] = new PictureBox();
                munitions[i].Size = new Size(8, 8);
                munitions[i].Image= munition;
                munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                munitions[i].BorderStyle = BorderStyle.None; ;
                this.Controls.Add(munitions[i]);
            }

            for(int i=0;i<Stars.Length;i++)
            {
                Stars[i]=new PictureBox();
                Stars[i].BorderStyle = BorderStyle.None;
                Stars[i].Location = new Point(rnd.Next(20,580),rnd.Next(-10,400));
                if (i % 2 == 1)
                {
                    Stars[i].Size = new Size(2, 2);
                    Stars[i].BackColor=Color.Wheat;

                }
                else
                {
                    Stars[i].Size = new Size(3,3);
                    Stars[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(Stars[i]);
            }


        }

        private void movebgtimer_Tick(object sender, EventArgs e)
        {
            for (int i=0;i<Stars.Length/2;i++)
            {
                Stars[i].Top += backgroundspeed;
                if(Stars[i].Top >= this.Height)
                {
                    Stars[i].Top = -Stars[i].Height;
                }

            }

            for (int i = Stars.Length / 2; i < Stars.Length; i++)
            {
                Stars[i].Top += backgroundspeed-2;
                if (Stars[i].Top >= this.Height)
                {
                    Stars[i].Top = -Stars[i].Height;
                }

            }
        }

       private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void leftmovetimer_Tick(object sender, EventArgs e)
        {
            if (Player.Left > 10)
                Player.Left -= playerspeed;
        }

        private void rightmovetimer_Tick(object sender, EventArgs e)
        {
            if (Player.Right < 500)
                Player.Left += playerspeed;

        }

        private void upmovetimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 10)
                Player.Top -= playerspeed;

        }

        private void downmovetimer_Tick(object sender, EventArgs e)
        {
            if (Player.Bottom < 400)
                Player.Top += playerspeed;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                rightmovetimer.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                leftmovetimer.Start();
            }
            if (e.KeyCode == Keys.Up)
            {
                upmovetimer.Start();
            }
            if (e.KeyCode == Keys.Right)
            {
                downmovetimer.Start();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            rightmovetimer.Stop();
            leftmovetimer.Stop();
            upmovetimer.Stop();
            downmovetimer.Stop();

        }

        private void movemunitiontimer_Tick(object sender, EventArgs e)
        {
            for(int i=0;i< munitions.Length;i++)
            {
                if (munitions[i].Top<400)
                {
                    munitions[i].Visible = true;
                    munitions[i].Top -= Munitionspeed;
                }
                else
                {
                    munitions[i].Visible = false;
                    munitions[i].Location = new Point(Player.Location.X +20, Player.Location.Y - i * 30);
                }
            }
        }

        private void enemytimer_Tick(object sender, EventArgs e)
        {
           /* for(int i=0;i<enemies.Length;i++)
            {
                if (enemies[i].Top < 400 )
                {
                    enemies[i].Visible = true;
                    enemies[i].Top -= enemiespeed;
                }
                else
                {
                    enemies[i].Visible = false;
                    enemies[i].Location = new Point(20, 20);
                }
            }*/
        }

        /*  private void timer2_Tick(object sender, EventArgs e)
          {

          }*/
    }
}
