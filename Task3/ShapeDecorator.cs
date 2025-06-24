using Task3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    abstract class ShapeDecorator : IShape
    {
        protected IShape _decoratedShape;

        public ShapeDecorator(IShape decoratedShape)
        {
            _decoratedShape = decoratedShape;
        }

        public void Draw() => _decoratedShape.Draw();
    }
}
