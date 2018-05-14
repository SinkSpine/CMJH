using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using 俄罗斯方块.Util;

namespace 俄罗斯方块.Entities
{
    /// <summary>
    /// 背景類，用來處理與背景有關的邏輯
    /// </summary>
    class Ground
    {
        /// <summary>
        /// 二維數組的每一個元素都對應了背景上面的背景方格
        /// </summary>
        private Block[,] blocks = new Block[CommonHelper.RowCount,CommonHelper.ColCount];

        /// <summary>
        /// 初始化二維數組給指點的元素的類型改成障礙物
        /// </summary>
        public void initBlocks() 
        {
            for (int i = 0; i < blocks.GetLength(0); i++)
            {
                for (int j = 0; j < blocks.GetLength(1); j++)
                {
                    blocks[i, j] = new Block();
                }
            }
            blocks[4, 3] = Block.GetAObstacleBolck();
            blocks[8, 7] = Block.GetAObstacleBolck();
        }
        /// <summary>
        /// 背景自己畫自己
        /// </summary>
        /// <param name="g"></param>
        public void DrawMe(Graphics g) 
        {
            SolidBrush blankBrush = new SolidBrush(CommonHelper.BlankColor);
            SolidBrush obstacleBrush = new SolidBrush(CommonHelper.ObstacleColor);
            //根据小方格的宽度和高度在游戏面板中绘制
            for (int rowindex = 0; rowindex < CommonHelper.RowCount; rowindex++)//外层循环控制行数
            {
                for (int colindex = 0; colindex < CommonHelper.ColCount; colindex++)
                {
                    g.DrawRectangle(Pens.Black, new Rectangle(colindex * CommonHelper.SquLength, rowindex * CommonHelper.SquLength, CommonHelper.SquLength, CommonHelper.SquLength));
                    //填充背景方格的時候 根據當前填充的方格的位置去二維數組中對應，看其中的類型，如果是普通類型的就畫普通方格 如果障礙物類型的 就畫障礙物
                    if (blocks[rowindex, colindex].BlockType == BlockTypeEnum.Blank)
                    {
                        g.FillRectangle(blankBrush, new Rectangle(colindex * CommonHelper.SquLength + 1, rowindex * CommonHelper.SquLength + 1, CommonHelper.SquLength - 1, CommonHelper.SquLength - 1));
                    }
                    else if (blocks[rowindex, colindex].BlockType == BlockTypeEnum.Obstacle) 
                    {
                        g.FillRectangle(obstacleBrush, new Rectangle(colindex * CommonHelper.SquLength + 1, rowindex * CommonHelper.SquLength + 1, CommonHelper.SquLength - 1, CommonHelper.SquLength - 1));                   
                    }
                }
            }
        }

        /// <summary>
        /// 判斷制訂的形狀能否移動
        /// </summary>
        /// <param name="shape"></param>
        /// <param name="dir"></param>
        /// <returns></returns>
        public bool IsMoveable(Shape shape, Direction dir) 
        {
            CellPosition position;
            foreach (ShapeUnit unit in shape.units)
            {
                position = unit.Position;
                switch (dir)
                {
                    case Direction.Up:
                        break;
                    case Direction.Down:
                        position.RowIndex++;
                        break;
                    case Direction.Left:
                        position.ColIndex--;
                        break;
                    case Direction.Right:
                        position.ColIndex++;
                        break;
                }
                if (position.RowIndex >= CommonHelper.RowCount || position.ColIndex < 0 || position.ColIndex >= CommonHelper.ColCount || blocks[position.RowIndex, position.ColIndex].BlockType == BlockTypeEnum.Obstacle)
                    return false;
            }
            return true;
        }

        //将形状变成障碍物
        public void KillAShape(Shape shape)
        {
            shape.KillMe();
            foreach (ShapeUnit unit in shape.units)
            {
                blocks[unit.Position.RowIndex, unit.Position.ColIndex].BlockType = BlockTypeEnum.Obstacle;
            }
        }

        //判断游戏是否结束.
        public bool IsGameOver(Shape shape)
        {
            foreach (ShapeUnit unit in shape.units)
            {
                if (unit.Position.RowIndex == 0)
                    return true;
            }
            return false;
        }
        /// <summary>
        ///  判断制定的形状能否变形.
        /// </summary>
        /// <param name="shape"></param>
        /// <param name="shapeDir"></param>
        /// <returns></returns>
        public bool IsRotateable(Shape shape)
        {
            bool isRotateable = true;

            //1. 预变形.
            switch (shape.shapeDir)
            {
                case Direction.Up:
                    shape.RotateRight();
                    shape.shapeDir = Direction.Right;
                    break;
                case Direction.Down:
                    shape.RotateLeft();
                    shape.shapeDir = Direction.Left;
                    break;
                case Direction.Left:
                    shape.RotateUp();
                    shape.shapeDir = Direction.Up;
                    break;
                case Direction.Right:
                    shape.RotateDown();
                    shape.shapeDir = Direction.Down;
                    break;
            }
            //2. 判断预变形后 每个形状单元的位置 是否遇到障碍物或者越界.
            foreach (ShapeUnit u in shape.units)
            {
                if (u.Position.ColIndex < 0
                    || u.Position.ColIndex >= CommonHelper.ColCount
                    || u.Position.RowIndex < 0
                    || u.Position.RowIndex >= CommonHelper.RowCount
                    || blocks[u.Position.RowIndex, u.Position.ColIndex].BlockType == BlockTypeEnum.Obstacle)
                {
                    isRotateable = false;
                }
            }
            //3. 还原变形
            switch (shape.shapeDir)
            {
                case Direction.Up:
                    shape.RotateLeft();
                    shape.shapeDir = Direction.Left;
                    break;
                case Direction.Down:
                    shape.RotateRight();
                    shape.shapeDir = Direction.Right;
                    break;
                case Direction.Left:
                    shape.RotateDown();
                    shape.shapeDir = Direction.Down;
                    break;
                case Direction.Right:
                    shape.RotateUp();
                    shape.shapeDir = Direction.Up;
                    break;
            }
            return isRotateable;
        }
        /// <summary>
        ///  检查并删除满行
        /// </summary>
        public void CheckAndDeleteFullRow()
        {
            //从最后一行往前遍历 检查.
            for (int rowIndex = this.blocks.GetLength(0) - 1; rowIndex >= 0; rowIndex--)
            {
                bool isFullRow = true;

                for (int colIndex = 0; colIndex < this.blocks.GetLength(1); colIndex++)
                {
                    if (blocks[rowIndex, colIndex].BlockType == BlockTypeEnum.Blank)
                    {
                        isFullRow = false;
                        break;
                    }
                }

                if (isFullRow)
                {
                    //删除当前循环到的行. 
                    //从当前行往上遍历
                    DeleteFullRow(rowIndex++);

                }
            }
        }

        private void DeleteFullRow(int deleteLineNumber)
        {
            for (int rowNum = deleteLineNumber; rowNum > 0; rowNum--)
            {
                for (int colIndex = 0; colIndex < this.blocks.GetLength(1); colIndex++)
                {
                    blocks[rowNum, colIndex].BlockType = blocks[rowNum - 1, colIndex].BlockType;
                }
            }
        }

    }
}
