using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class BlueShapeDecorator : ShapeDecorator
    {
        public BlueShapeDecorator(IShape decoratedShape) : base(decoratedShape) { }

        public void Draw()
        {
            _decoratedShape.Draw();
            SetBlueBorder(_decoratedShape);
        }

        private void SetBlueBorder(IShape decoratedShape) => Console.WriteLine("Border Color: Blue");
    }
}
