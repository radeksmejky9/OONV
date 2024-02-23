using System;
using System.Drawing;
using System.Security.Policy;

namespace FactoryExample
{
    internal abstract class ShapeDecorator : Shape
    {
        protected Shape decoratedShape;

        public ShapeDecorator(Shape decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }

        public override void Draw(Graphics g, bool centers)
        {
            if (decoratedShape != null)
            {
                decoratedShape.Draw(g, centers);
            }
        }
    }

    internal class BorderDecorator : ShapeDecorator
    {
        public BorderDecorator(Shape decoratedShape) : base(decoratedShape) { }
        private int borderSize = 2;
        public override void Draw(Graphics g, bool centers)
        {
            base.Draw(g, centers);

            Pen borderPen = new Pen(Color.Black, borderSize);
            if (decoratedShape is Circle)
            {
                Circle? c = decoratedShape as Circle;
                g.DrawEllipse(borderPen, c.center.X - c.r, c.center.Y - c.r, 2 * c.r, 2 * c.r);
            }
            else if (decoratedShape is Square)
            {
                Square? s = decoratedShape as Square;
                g.DrawRectangle(borderPen, s.center.X - s.size / 2, s.center.Y - s.size / 2, s.size, s.size);
            }
        }
    }
    internal class ShadowDecorator : ShapeDecorator
    {
        public ShadowDecorator(Shape decoratedShape) : base(decoratedShape) { }
        private int shadowSize = 8;
        private int shadowPadding = 5;
        public override void Draw(Graphics g, bool centers)
        {
            SolidBrush shadowBrush = new SolidBrush(Color.Gray);
            if (decoratedShape is Circle)
            {
                Circle? c = decoratedShape as Circle;
                if (c.isFilled)
                    g.FillEllipse(shadowBrush, (c.center.X - c.r) + 5, (c.center.Y - c.r) + 5, 2 * c.r, 2 * c.r);
                else
                    g.DrawEllipse(new Pen(shadowBrush.Color, shadowSize), (c.center.X - c.r) + 5, (c.center.Y - c.r) + 5, 2 * c.r, 2 * c.r);
            }
            else if (decoratedShape is Square)
            {
                Square? s = decoratedShape as Square;
                if (s.isFilled)
                    g.FillRectangle(shadowBrush, (s.center.X - s.size / 2) + 5, (s.center.Y - s.size / 2) + 5, s.size, s.size);
                else
                    g.DrawRectangle(new Pen(shadowBrush.Color, shadowSize), (s.center.X - s.size / 2) + 5, (s.center.Y - s.size / 2) + 5, s.size, s.size);
            }
            base.Draw(g, centers);
        }
    }


}
