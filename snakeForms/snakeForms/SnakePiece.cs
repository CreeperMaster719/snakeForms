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
        int width;
        int height;
        bool up;
        bool down;
        bool left;
        bool right;
        int length;
        Brush color;
        int tmp = 0;

        public SnakePiece(Brush color, int x, int y, int width, int height, bool up, bool down, bool left, bool right, int length)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.up = up;
            this.down = down;
            this.left = left;
            this.right = right;
            this.length = length;
            this.color = color;
        }

        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(color, x, y, width, height);
        }
        public void Move(bool up, bool down, bool left, bool right, int length)
        {
            if(up)
            {
                tmp = height;
                height = y;
                y = y - tmp;
                tmp = 0;
            }
            if(down)
            {
                tmp = y;
                y = height;
                height = height - tmp;
                tmp = 0;
            }
            if(left)
            {
                tmp = width;
                width = x;
                x = x - tmp;
                tmp = 0;
            }
            if(right)
            {
                tmp = x;
                x = width;
                width = width - tmp;
                tmp = 0;
            }
        }
    }
}
