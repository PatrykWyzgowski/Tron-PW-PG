using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace Tron_PW_PG
{
    public class Lightcycle
    {
        public Rectangle[] Body;
        private int xstart, ystart;
        private int width = 7, height = 7;
        public int dir { get; set; }
        private SolidBrush Bodycolor=new SolidBrush(Color.Green);

        public Lightcycle(int x,int y, Color kolor)
        {
            xstart = x;
            ystart = y;
            Body = new Rectangle[1];
            Body[0] = new Rectangle(xstart, ystart, width, height);
            dir = 3;
            Bodycolor.Color = kolor;
        }
        public void Draw()
        {
            for (int i = Body.Length - 1; i > 0; i--)
                Body[i] = Body[i - 1];
        }
        
        public void Draw(Graphics graphics)
        { //temporarily
            //graphics.FillRectangle(greenBrush,x_cor, y_cor, width, height);
            graphics.FillRectangles(Bodycolor, Body);
        }

        public void Drive(int dir)
        {
            Draw();
            switch(dir)
            {
                case 0:
                    Body[0].X += 7; 
                    break;
                case 1:
                    Body[0].Y += 7;
                    break;
                case 2:
                    Body[0].X -= 7;
                    break;
                case 3:
                    Body[0].Y -= 7;
                    break;
            }
        }

        public void Trace()
        {
            List<Rectangle> temp = Body.ToList();
            temp.Add(new Rectangle(Body[Body.Length - 1].X, Body[Body.Length - 1].Y, width, height));
            Body = temp.ToArray();
        }
    }//GRa skończona
}
