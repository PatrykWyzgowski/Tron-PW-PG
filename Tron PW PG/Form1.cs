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
        private Graphics graphics;
        private Lightcycle player1, player2;
        public Menu()
        {
            InitializeComponent();
            player1 = new Lightcycle();
            player2 = new Lightcycle();
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

        }
    }
        private void Menu_Paint(object sender, PaintEventArgs e)
        {

        }

    private void Update(object sender, EventArgs e)
    {

    }

    

    private void Restart()
    {

    }

}

