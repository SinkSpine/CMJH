using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 俄罗斯方块.Entities
{
    /// <summary>
    /// 用來描述一個形狀的單元位置
    /// </summary>
    struct CellPosition
    {
        #region 01.形狀單元的行坐標+int rowIndex
        private int rowIndex;

        public int RowIndex
        {
            get { return rowIndex; }
            set { rowIndex = value; }
        } 
        #endregion


        #region 02.形狀單元的列坐標+int colIndex
        private int colIndex;

        public int ColIndex
        {
            get { return colIndex; }
            set { colIndex = value; }
        } 
        #endregion


        #region 03.為結構體對象賦初始值
        public CellPosition(int rowIndex, int colIndex)
        {
            this.colIndex = colIndex;
            this.rowIndex = rowIndex;
        } 
        #endregion
    }
}
