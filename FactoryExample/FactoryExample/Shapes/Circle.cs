using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryExample;

namespace FactoryExample
{
    internal class Circle : Shape
    {
        public int r;
        public Point center;

        public override void Draw(Graphics g, bool centers)
        {
            if (state)
            {
                if (isFilled)
                {
                    g.FillEllipse(new SolidBrush(color),
                    center.X - r, center.Y - r, 2 * r, 2 * r);
                }
                else
                {
                    g.DrawEllipse(new Pen(color, 8),
                    center.X - r, center.Y - r, 2 * r, 2 * r);
                }

                if (centers)
                {
                    g.DrawLine(centerPen, center.X - 15, center.Y, center.X + 15, center.Y);
                    g.DrawLine(centerPen, center.X, center.Y - 15, center.X, center.Y + 15);
                }
            }
        }

    }
}
