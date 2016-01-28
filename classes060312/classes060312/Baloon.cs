using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace classes060312
{
    public class Baloon : Sphere
    {
        protected int radius = 30;

        public int Size
        {
            set
            {
                radius = value;
            }
        }

        public override void Display(Graphics drawArea)
        {
            drawArea.DrawEllipse(pen, xCoord, yCoord, 2 * radius, 2 * radius);
        }
    }

}
