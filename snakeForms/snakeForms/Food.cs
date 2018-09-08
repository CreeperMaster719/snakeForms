using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeForms
{
    public class Food
    {
        int x;
        int y;
        int length;
        public Rectangle FoodBox;
        Brush color;
        Graphics gfx;

        public Food(int x, int y, int length, Brush color)
        {

            this.x = x;
            this.y = y;
            this.color = color;
            this.length = length;
            FoodBox = new Rectangle(x, y, length, length);

        }

        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(color, x, y, length, length);
        }
        public void Move(Random random)
        {
            x = random.Next(20, 1240);
            y = random.Next(20, 590);
            FoodBox.X = x;
            FoodBox.Y = y;
        }
    }
}
