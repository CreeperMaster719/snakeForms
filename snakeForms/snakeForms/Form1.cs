using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakeForms
{
    public partial class Form1 : Form
    {
        int x = 100;
        int y = 100;
        int direction = 0;
        int length = 50;
        Graphics gfx;
        Bitmap canvas;
        Random gen;
        List<SnakePiece> snakePieces = new List<SnakePiece>();

        Food firstfood;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gen = new Random();
            canvas = new Bitmap(PictureBox.Width, PictureBox.Height);
            snakePieces.Add(new SnakePiece(Brushes.Black, x, y, direction, length));
            gfx = Graphics.FromImage(canvas);
            firstfood = new Food(gen.Next(20, 1240), gen.Next(20, 590), length - 30, Brushes.Red);

        }
        private void gameTime_Tick(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);

            firstfood.Draw(gfx);

            //make a for loop that goes from the end of the snake to the beginning of the snake
            //set the current pieces direction = to the piece behind it


            for (int i = 0; i < snakePieces.Count; i++)
            {
                snakePieces[i].Move(length, Width, Height);
            }
            for (int i = snakePieces.Count - 1; i > 0; i--)
            {
                snakePieces[i].direction = snakePieces[i - 1].direction;
            }
            if (snakePieces[0].hitbox.IntersectsWith(firstfood.FoodBox))
            {
                SnakePiece newpiece = new SnakePiece(Brushes.Black, snakePieces[snakePieces.Count - 1].x, snakePieces[snakePieces.Count - 1].y, snakePieces[snakePieces.Count - 1].direction, length);

                if (snakePieces[snakePieces.Count - 1].direction == 0)
                {
                    newpiece.y += length;
                }
                if (snakePieces[snakePieces.Count - 1].direction == 1)
                {
                    newpiece.y -= length;
                }
                if (snakePieces[snakePieces.Count - 1].direction == 2)
                {
                    newpiece.x += length;
                }
                if (snakePieces[snakePieces.Count - 1].direction == 3)
                {
                    newpiece.x -= length;
                }

                snakePieces.Add(newpiece);
                firstfood.Move(gen);
            }
            for (int i = 0; i < snakePieces.Count; i++)
            {
                snakePieces[i].Draw(gfx);
            }
            //gfx.DrawEllipse(Pens.Green, 10, 10, 100, 100);
            PictureBox.Image = canvas;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                snakePieces[0].direction = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                snakePieces[0].direction = 1;
            }

            if (e.KeyCode == Keys.Left)
            {
                snakePieces[0].direction = 2;

            }

            if (e.KeyCode == Keys.Right)
            {
                snakePieces[0].direction = 3;

            }

        }


    }
}
