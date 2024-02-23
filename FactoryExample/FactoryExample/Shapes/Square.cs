
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    internal class Square : Shape
    {
        public Point center;
        public int size;


        public override void Draw(Graphics g, bool centers)
        {
            if (state)
            {
                if (isFilled)
                {
                    g.FillRectangle(new SolidBrush(color),
                    center.X - size / 2, center.Y - size / 2, size, size);
                }
                else
                {
                    g.DrawRectangle(new Pen(color, 8),
                    center.X - size / 2, center.Y - size / 2, size, size);
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
