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
        SnakePiece snakeHead;
        List<SnakePiece> snakePieces = new List<SnakePiece>();
        List<Food> foodchunks = new List<Food>();
        Food firstfood;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = new Bitmap(PictureBox.Width, PictureBox.Height);
            snakeHead = new SnakePiece(Brushes.Black, x, y, direction, length);
            gfx = Graphics.FromImage(canvas);
            firstfood = new Food(x, y, length - 30, Brushes.Red);
        }
        private void gameTime_Tick(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);
            snakeHead.Move(direction, length, Width, Height);
            snakeHead.Draw(gfx);
            firstfood.Draw(gfx);
            //gfx.DrawEllipse(Pens.Green, 10, 10, 100, 100);
            PictureBox.Image = canvas;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                direction = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                direction = 1;
            }

            if (e.KeyCode == Keys.Left)
            {
                direction = 2;

            }

            if (e.KeyCode == Keys.Right)
            {
                direction = 3;

            }

        }


    }
}
