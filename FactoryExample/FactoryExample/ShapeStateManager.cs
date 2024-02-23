using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    internal class ShapeStateManager
    {
        private List<IShapeObserver> observers = new List<IShapeObserver>();

        public void Subscribe(IShapeObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IShapeObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyStateChanged(Type shapeType, bool state)
        {
            foreach (var observer in observers)
            {
                observer.ShapeStateChanged(shapeType, state);
            }
        }

    }

}
