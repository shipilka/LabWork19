using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class RedShapeDecorator : ShapeDecorator
    {

        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape) { }

        public void Draw()
        {
            _decoratedShape.Draw();
            SetRedBorder(_decoratedShape);
        }

        private void SetRedBorder(IShape decoratedShape) => Console.WriteLine("Border Color: Red");
    }
}
