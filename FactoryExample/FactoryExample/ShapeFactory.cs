
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryExample;

namespace FactoryExample
{
    internal abstract class ShapeFactory
    {
        public int size;
        public Color color;
        public bool isFilled;

        public abstract Shape GetShape(Point center);
    }

    internal class SquareFactory : ShapeFactory
    {
        public override Shape GetShape(Point center)
        {
            return new Square()
            {
                color = this.color,
                size = this.size,
                center = center,
                isFilled = this.isFilled
            };
        }
    }
    internal class CircleFactory : ShapeFactory
    {
        public override Shape GetShape(Point center)
        {
            return new Circle()
            {
                color = this.color,
                r = this.size,
                center = center,
                isFilled = this.isFilled
            };
        }
    }
}
