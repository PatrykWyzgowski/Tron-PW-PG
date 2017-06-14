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
        private bool Game = true;
        //private int dir = 0;
        private Timer my_timer = new Timer();
        //private static Random rand = new Random();
        //int randomNumber = rand.Next(0, 100);
        public Graphics graphics;
        //private Lightcycle player1, player2;
        private Lightcycle[] player = new Lightcycle[2];
        public Menu()
        {
            InitializeComponent();
            //graphics = new Graphics();
            player[0] = new Lightcycle(125,500,Color.Red);
            player[1] = new Lightcycle(375,500,Color.Blue);
            my_timer.Interval = 75;
            my_timer.Tick += Update;

        }
        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            //while (Game)
            //{
           
                switch (e.KeyData)
                {
                    case Keys.Enter:
                        if (IntroInfo.Visible)
                        {
                            IntroInfo.Visible = false;
                            //Game = true;
                            my_timer.Start();
                        }
                        break;
                    case Keys.Space:
                        if (!IntroInfo.Visible)
                            my_timer.Enabled = (my_timer.Enabled) ? false : true;
                        break;

                    case Keys.Right:
                        if (player[0].dir != 2)
                            player[0].dir = 0;
                        break;
                    case Keys.Down:
                        if (player[0].dir != 3)
                        player[0].dir = 1;
                        break;
                    case Keys.Left:
                        if (player[0].dir != 0)
                        player[0].dir = 2;
                        break;
                    case Keys.Up:
                        if (player[0].dir != 1)
                        player[0].dir = 3;
                        break;

                case Keys.D:
                    if (player[1].dir != 2)
                        player[1].dir = 0;
                    break;
                case Keys.S:
                    if (player[1].dir != 3)
                        player[1].dir = 1;
                    break;
                case Keys.A:
                    if (player[1].dir != 0)
                        player[1].dir = 2;
                    break;
                case Keys.W:
                    if (player[1].dir != 1)
                        player[1].dir = 3;
                    break;
            }
            //}
        }
        

        private void Update(object sender, EventArgs e)
        {
            if (true)
                player[0].Trace();
            player[1].Trace();
            this.Text = string.Format("Tron - Score: 0-0");
            player[0].Drive(player[0].dir);
            player[1].Drive(player[1].dir);
            //suicide detection
            for (int i = 1; i < player[0].Body.Length; i++)
                if (player[0].Body[0].IntersectsWith(player[0].Body[i]))
                    //Form2.ShowDialog.Text("Player 2 Wins");
                    Restart();
            for (int i = 1; i < player[1].Body.Length; i++)
                if (player[1].Body[0].IntersectsWith(player[1].Body[i]))
                    Restart();
            for (int i = 1; i < player[0].Body.Length; i++)
                if (player[0].Body[0].IntersectsWith(player[1].Body[i]))
                    //Form2.ShowDialog.Text("Player 2 Wins");
                    Restart();
            for (int i = 1; i < player[1].Body.Length; i++)
                if (player[1].Body[0].IntersectsWith(player[0].Body[i]))
                    Restart();
            //torus window-leaving style
            if (player[0].Body[0].X < 0)
                player[0].Body[0].X = 500 - 1;
            if (player[0].Body[0].X > 500)
                player[0].Body[0].X = 0 + 1;
            if (player[0].Body[0].Y < 0)
                player[0].Body[0].Y = 500 - 1;
            if (player[0].Body[0].Y > 500)
                player[0].Body[0].Y = 0 + 1;

            if (player[1].Body[0].X < 0)
                player[1].Body[0].X = 500 - 1;
            if (player[1].Body[0].X > 500)
                player[1].Body[0].X = 0 + 1;
            if (player[1].Body[0].Y < 0)
                player[1].Body[0].Y = 500 - 1;
            if (player[1].Body[0].Y > 500)
                player[1].Body[0].Y = 0 + 1;



            //intersekcja z drugim graczem
            this.Invalidate();
        }
        private void Menu_Paint(object sender, PaintEventArgs e)
        {
            graphics = this.CreateGraphics();
            player[0].Draw(graphics);
            player[1].Draw(graphics);

        }

        private void Restart()
        {
            //Game = false;
            my_timer.Stop();
            graphics.Clear(SystemColors.Control);
            player[0] = new Lightcycle(125,500,Color.Red);
            player[1] = new Lightcycle(375, 500, Color.Blue);
            IntroInfo.Visible = true;
            player[0].dir = 3;
            player[1].dir = 3;
        }

    }
}

