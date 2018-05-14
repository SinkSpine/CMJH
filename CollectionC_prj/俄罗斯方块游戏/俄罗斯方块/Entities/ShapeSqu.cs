using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 俄罗斯方块.Util;

namespace 俄罗斯方块.Entities
{
    class ShapeSqu:Shape
    {
        protected override void SetUnitsPositon()
        {
            base.units[0].Position = new CellPosition(0, CommonHelper.MidCol);
            base.units[1].Position = new CellPosition(0, CommonHelper.MidCol + 1);
            base.units[2].Position = new CellPosition(1, CommonHelper.MidCol);
            base.units[3].Position = new CellPosition(1, CommonHelper.MidCol + 1);
        }

        public override void RotateUp()
        {

        }

        public override void RotateDown()
        {

        }

        public override void RotateLeft()
        {

        }

        public override void RotateRight()
        {

        }
    }
}
