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
        bool up = false;
        bool down = false;
        bool left = false;
        bool right = false;
        Graphics gfx;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void snakeHead_Click(object sender, EventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
            if(e.KeyCode == Keys.Up)
            {
                up = true;

            }
            else
            {
                up = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = true;

            }
            else
            {
                down = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;

            }
            else
            {
                left = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = true;

            }
            else
            {
                right = false;
            }
        }

        private void gameTime_Tick(object sender, EventArgs e)
        {

        }
    }
}
