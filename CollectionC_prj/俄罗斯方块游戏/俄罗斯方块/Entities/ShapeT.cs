using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 俄罗斯方块.Util;

namespace 俄罗斯方块.Entities
{
    class ShapeT:Shape
    {
        protected override void SetUnitsPositon()
        {
            base.shapePosition = new CellPosition(1, CommonHelper.MidCol);

            base.units[0].Position = new CellPosition(base.shapePosition.RowIndex - 1, base.shapePosition.ColIndex);
            base.units[1].Position = new CellPosition(base.shapePosition.RowIndex, base.shapePosition.ColIndex - 1);
            base.units[2].Position = new CellPosition(base.shapePosition.RowIndex, base.shapePosition.ColIndex);
            base.units[3].Position = new CellPosition(base.shapePosition.RowIndex, base.shapePosition.ColIndex + 1);
        }

        public override void RotateUp()
        {
            base.units[0].Position = new CellPosition(base.shapePosition.RowIndex - 1, base.shapePosition.ColIndex);
            base.units[1].Position = new CellPosition(base.shapePosition.RowIndex, base.shapePosition.ColIndex - 1);
            base.units[2].Position = new CellPosition(base.shapePosition.RowIndex, base.shapePosition.ColIndex);
            base.units[3].Position = new CellPosition(base.shapePosition.RowIndex, base.shapePosition.ColIndex + 1);
        }

        public override void RotateDown()
        {
            base.units[0].Position = new CellPosition(base.shapePosition.RowIndex + 1, base.shapePosition.ColIndex);
            base.units[1].Position = new CellPosition(base.shapePosition.RowIndex, base.shapePosition.ColIndex + 1);
            base.units[2].Position = new CellPosition(base.shapePosition.RowIndex, base.shapePosition.ColIndex);
            base.units[3].Position = new CellPosition(base.shapePosition.RowIndex, base.shapePosition.ColIndex - 1);
        }

        public override void RotateLeft()
        {
            base.units[0].Position = new CellPosition(base.shapePosition.RowIndex, base.shapePosition.ColIndex - 1);
            base.units[1].Position = new CellPosition(base.shapePosition.RowIndex + 1, base.shapePosition.ColIndex);
            base.units[2].Position = new CellPosition(base.shapePosition.RowIndex, base.shapePosition.ColIndex);
            base.units[3].Position = new CellPosition(base.shapePosition.RowIndex - 1, base.shapePosition.ColIndex);
        }

        public override void RotateRight()
        {
            base.units[0].Position = new CellPosition(base.shapePosition.RowIndex, base.shapePosition.ColIndex + 1);
            base.units[1].Position = new CellPosition(base.shapePosition.RowIndex - 1, base.shapePosition.ColIndex);
            base.units[2].Position = new CellPosition(base.shapePosition.RowIndex, base.shapePosition.ColIndex);
            base.units[3].Position = new CellPosition(base.shapePosition.RowIndex + 1, base.shapePosition.ColIndex);
        }
    }
}
