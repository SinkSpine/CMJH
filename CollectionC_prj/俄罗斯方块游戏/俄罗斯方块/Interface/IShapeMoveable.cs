using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 俄罗斯方块.Entities;

namespace 俄罗斯方块.Interface
{
    interface IShapeMoveable
    {
        void ShapeMove(Shape shape);
        bool IsMoveable(Shape shape);
    }
}
