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

    public class SnakePiece
    {
        public int x;
        public int y;
        public int direction;
        public Rectangle hitbox;        
        public int length;
        public Brush color;
        

        public SnakePiece(Brush color, int x, int y, int direction, int length)
        {
            this.x = x;
            this.y = y;
            this.length = length;
            this.color = color;
            this.direction = direction;

            hitbox = new Rectangle(x, y, length, length);
        }

        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(color, x, y, length, length);
        }

        public void Move(int length, int formWidth, int formHeight)
        {
            hitbox.X = x;
            hitbox.Y = y;

            if (direction == 0)
            {
                if (y + 20 < 0)
                {
                    y = formHeight;
                }
                else
                {
                    y = y - length;
                }
            }
            if (direction == 1)
            {

                if (y - 20 > formHeight)
                {
                    y = 0;
                }
                else
                {
                    y = y + length;
                }
            }
            if (direction == 2)
            {
                if (x + 20 < 0)
                {
                    x = formWidth;
                }
                else
                {
                    x = x - length;
                }

            }
            if (direction == 3)
            {

                if (x - 20 > formWidth)
                {
                    x = 0;
                }
                else
                {
                    x = x + length;
                }

            }
        }
    }
}
