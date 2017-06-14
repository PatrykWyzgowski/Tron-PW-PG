using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tron_PW_PG
{
    public partial class Menu : Form
    {
        private int dir = 0;
        private Timer my_timer = new Timer();
        private Random rand = new Random();
        public Graphics graphics;
        private Lightcycle player1, player2;
        public Menu()
        {
            InitializeComponent();
            //graphics = new Graphics();
            player1 = new Lightcycle();
            //player2 = new Lightcycle();
            my_timer.Interval = 75;
            my_timer.Tick += Update;

        }
        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    if (IntroInfo.Visible)
                    {
                        IntroInfo.Visible = false;
                        my_timer.Start();
                    }
                    break;
                case Keys.Space:
                    if (!IntroInfo.Visible)
                        my_timer.Enabled = (my_timer.Enabled) ? false : true;
                    break;

                case Keys.Right:
                    if (dir != 2)
                        dir = 0;
                    break;
                case Keys.Down:
                    if (dir != 3)
                        dir = 1;
                    break;
                case Keys.Left:
                    if (dir != 0)
                        dir = 2;
                    break;
                case Keys.Up:
                    if (dir != 1)
                        dir = 3;
                    break;
            }
        }
        

        private void Update(object sender, EventArgs e)
        {
            this.Text = string.Format("Tron - Score: 0-0");
            player1.Drive(dir);
            //suicide detection
            for (int i = 1; i < player1.Body.Length; i++)
                if (player1.Body[0].IntersectsWith(player1.Body[i]))
                    Restart();
            //torus window-leaving style
            if (player1.Body[0].X < 0)
                player1.Body[0].X = 500 - 1;
            if (player1.Body[0].X > 500)
                player1.Body[0].X = 0 + 1;
            if (player1.Body[0].Y < 0)
                player1.Body[0].Y = 500 - 1;
            if (player1.Body[0].Y > 500)
                player1.Body[0].Y = 0 + 1;



            //intersekcja z drugim graczem
            this.Invalidate();
        }
        private void Menu_Paint(object sender, PaintEventArgs e)
        {
            graphics = this.CreateGraphics();
            player1.Draw(graphics);

        }

        private void Restart()
        {
            my_timer.Stop();
            graphics.Clear(SystemColors.Control);
        }

    }
}

