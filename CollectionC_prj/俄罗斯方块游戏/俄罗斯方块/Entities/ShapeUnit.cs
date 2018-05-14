using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using 俄罗斯方块.Util;

namespace 俄罗斯方块.Entities
{
    /// <summary>
    /// 形狀單元
    /// </summary>
    class ShapeUnit
    {
        //形狀單元的坐標
        private CellPosition position;

        internal CellPosition Position
        {
            get { return position; }
            set { position = value; }
        }


        /// <summary>
        /// 行傳單元的函數
        /// </summary>
        private Color unitColor = Color.Red;

        public Color UnitColor
        {
            get { return unitColor; }
            set { unitColor = value; }
        }

        public ShapeUnit() 
        { 
        
        }

        public ShapeUnit(int rowIndex, int colIndex) 
        {
            this.position.ColIndex = colIndex;
            this.position.RowIndex = rowIndex;
        }

        public ShapeUnit(CellPosition position)
        {
            this.position = position;
        }

        /// <summary>
        /// 行傳單元自己畫自己的方法
        /// </summary>
        /// <param name="g"></param>
        public void DrawMe(Graphics g) 
        { 
            //根據當前形狀單元的顏色創建一把刷子對象
            SolidBrush brush=new SolidBrush(this.unitColor);
            //讓傳遞進來的畫家對象根據當前形狀單元位置繪製出來
            g.FillRectangle(brush,new Rectangle(this.position.ColIndex*CommonHelper.SquLength+1,this.position.RowIndex*CommonHelper.SquLength+1,CommonHelper.SquLength-1,CommonHelper.SquLength-1));
        }

        /// <summary>
        ///  形状单元自己擦除自己.
        /// </summary>
        /// <param name="g"></param>
        public void WipeMe(Graphics g)
        {
            lock (CommonHelper.lockKey)
            {
                g.FillRectangle(Brushes.Silver, new Rectangle(this.Position.ColIndex * CommonHelper.SquLength + 1,
                 this.position.RowIndex * CommonHelper.SquLength + 1,
                 CommonHelper.SquLength - 1,
                 CommonHelper.SquLength - 1));
            }
        }
    }
}
