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
    class FullSnake
    {

        public List<SnakePiece> Body = new List<SnakePiece>();
        public SnakePiece Head
        {
            get
            {
                return Body[0];
            }
        }
        public FullSnake(Brush color, int x, int y, int direction, int length)
        {
            SnakePiece snakePiece = new SnakePiece(color, x, y, direction, length);
            Body.Add(snakePiece);

        }
        //Update - updates the direction of all the pieces in the body
        public void Update(int formWidth, int formHeight, bool timer)
        {
            for (int i = 0; i < Body.Count; i++)
            {
                Body[i].Move(Head.length, formWidth, formHeight);
            }
            for (int i = Body.Count - 1; i > 0; i--)
            {
                Body[i].direction = Body[i - 1].direction;
            }
            for (int i = 1; i < Body.Count; i++)
            {
                if (Body[0].hitbox.IntersectsWith(Body[i].hitbox))
                {
                    if(Body[i].color == Brushes.Red)
                    {
                        timer = false;
                    }
                    Body[i].color = Brushes.Red;
                }
                else
                {

                }
            }
        }
        public void NewPiece()
        {

            SnakePiece newpiece = new SnakePiece(Brushes.Black, Body[Body.Count - 1].x, Body[Body.Count - 1].y, Body[Body.Count - 1].direction, Head.length);

            if (Body[Body.Count - 1].direction == 0)
            {
                newpiece.y += Head.length;
            }
            if (Body[Body.Count - 1].direction == 1)
            {
                newpiece.y -= Head.length;
            }
            if (Body[Body.Count - 1].direction == 2)
            {
                newpiece.x += Head.length;
            }
            if (Body[Body.Count - 1].direction == 3)
            {
                newpiece.x -= Head.length;
            }


            Body.Add(newpiece);


        }

        public void Draw(Graphics gfx)
        {
            for (int i = 0; i < Body.Count; i++)
            {
                Body[i].Draw(gfx);
            }
        }
    }
}



