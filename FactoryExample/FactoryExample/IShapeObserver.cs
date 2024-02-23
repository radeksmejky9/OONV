using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    internal interface IShapeObserver
    {
        void ShapeStateChanged(Type shapeType, bool state);
    }
}
