using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    internal abstract class Shape : IShapeObserver
    {
        public Color color;
        public bool isFilled;
        public bool state { get; private set; } = true;

        protected static Pen centerPen = new Pen(Color.Black, 4);

        public abstract void Draw(Graphics g, bool centers);

        public void ShapeStateChanged(Type shapeType, bool state)
        {
            if (GetType() == shapeType)
            {
                this.state = state;
            }
        }
    }
}
