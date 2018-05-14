using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace 俄罗斯方块.Util
{
    static class CommonHelper
    {
        #region 遊戲面板的行數,默認18行+static int RowCount
        private static int rowCount = 18;

        public static int RowCount
        {
            get { return CommonHelper.rowCount; }
            set { CommonHelper.rowCount = value; }
        } 
        #endregion

        #region 遊戲面板的列數,默認11列+ static int ColCount
        private static int colCount = 11;

        public static int ColCount
        {
            get { return CommonHelper.colCount; }
            set { CommonHelper.colCount = value; }
        } 
        #endregion

        #region 小方格的邊長
        private static int squLength;

        public static int SquLength
        {
            get { return CommonHelper.squLength; }
        } 
        #endregion

        #region 初始化遊戲環境+static void InitializeEnvironment(int width, int height)
        /// <summary>
        /// 初始化遊戲環境，根據遊戲面板的寬度和高度求出小方格的邊長
        /// </summary>
        public static void InitializeEnvironment(int width, int height)
        {
            int w = width / colCount;
            int h = height / rowCount;
            squLength = w > h ? h : w;
            midCol = colCount / 2;
        } 
        #endregion

        #region 中間咧索引
        private static int midCol;

        public static int MidCol
        {
            get { return CommonHelper.midCol; }
        } 
        #endregion

        #region 障礙物的顏色+static Color ObstacleColor
        /// <summary>
        /// 障礙物的顏色
        /// </summary>
        private static Color obstacleColor = Color.Green;

        public static Color ObstacleColor
        {
            get { return CommonHelper.obstacleColor; }
            set { CommonHelper.obstacleColor = value; }
        } 
        #endregion

        #region 普通背景方格的顏色+static Color BlankColor
        /// <summary>
        /// 普通背景方格的顏色
        /// </summary>
        private static Color blankColor = Color.SkyBlue;

        public static Color BlankColor
        {
            get { return CommonHelper.blankColor; }
            set { CommonHelper.blankColor = value; }
        } 
        #endregion

        public static object lockKey = new object();
    }
}
