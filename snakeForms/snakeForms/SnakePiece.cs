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
        int x;
        int y;
        int direction;

        int length;
        Brush color;
        int tmp = 20;

        public SnakePiece(Brush color, int x, int y, int direction, int length)
        {
            this.x = x;
            this.y = y;
            this.length = length;
            this.color = color;
            this.direction = direction;
        }

        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(color, x, y, length, length);
        }
        public void Move(int direction, int length, int formWidth, int formHeight)
        {
            if (direction == 0)
            {
                if (y + 20 < 0)
                {
                    y = formHeight;
                }
                else
                {
                    y = y - tmp;
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
                    y = y + tmp;
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
                    x = x - tmp;
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
                    x = x + tmp;
                }

            }
        }
    }
}
