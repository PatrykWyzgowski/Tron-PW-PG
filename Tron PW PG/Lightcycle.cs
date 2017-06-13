using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace Tron_PW_PG
{
    public class Lightcycle
    {
        public Rectangle[] Body;
        private int x_cor = 20, y_cor = 20;
        private int width = 10, height = 10;

        public void lightcycle()
        {
            Body = new Rectangle[1];
            Body[0] = new Rectangle(x_cor, y_cor, width, height);
        }
        //public void Draw()
        //{

        //}

        public void Draw(Graphics graphics)
        { //temporarily
            graphics.FillRectangles(Brushes.Green, Body);
        }

        public void Drive(int dir)
        {
            //Draw();
            switch(dir)
            {
                case 0:
                    Body[0].Y += 10; 
                    break;
                case 1:
                    Body[0].Y -= 10;
                    break;
                case 2:
                    Body[0].X -= 10;
                    break;
                case 3:
                    Body[0].X += 10;
                    break;
            }
        }

        public void Trace()
        {
            List<Rectangle> temp = Body.ToList();
            temp.Add(new Rectangle(Body[Body.Length - 1].X, Body[Body.Length - 1].Y, width, height));
            Body = temp.ToArray();
        }
    }
}
