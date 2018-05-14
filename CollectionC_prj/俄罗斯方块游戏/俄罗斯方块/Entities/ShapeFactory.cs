using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 俄罗斯方块.Entities
{
    class ShapeFactory
    {
        Random r = new Random();
        public Shape GetAShape() 
        {
            ShapeType shapeType = (ShapeType)r.Next(1, 7);
            Shape shape = null;
            switch (shapeType)
            {
                case ShapeType.ZLeft:
                    shape = new ShapeZLeft();
                    break;
                case ShapeType.ZRight:
                    shape = new ShapeZRight();
                    break;
                case ShapeType.LLeft:
                    shape = new ShapeLLeft();
                    break;
                case ShapeType.LRight:
                    shape = new ShapeLRight();
                    break;
                case ShapeType.Squ:
                    shape = new ShapeSqu();
                    break;
                case ShapeType.Line:
                    shape = new ShapeLine();
                    break;
                case ShapeType.T:
                    shape = new ShapeT();
                    break;
            }
            return shape;       
        }
    }
}
