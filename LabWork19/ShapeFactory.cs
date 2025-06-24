using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork19
{
    class ShapeFactory
    {
        public IShape? PropertyShape(string shapeType)
        {
            if (shapeType == null)
                return null;

            if (shapeType.Equals("CIRCLE", StringComparison.OrdinalIgnoreCase))
                return new Circle();

            if (shapeType.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase))
                return new Rectangle();

            if (shapeType.Equals("SQUARE", StringComparison.OrdinalIgnoreCase))
                return new Square();

            if (shapeType.Equals("PENTAGON", StringComparison.OrdinalIgnoreCase))
                return new Pentagon();

            return null;
        }
    }
}
