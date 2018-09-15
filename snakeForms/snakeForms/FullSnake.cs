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
        }

    //Draw - draws all the snakepieces


    }

