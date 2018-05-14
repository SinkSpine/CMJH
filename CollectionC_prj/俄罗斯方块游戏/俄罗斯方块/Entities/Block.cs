using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using 俄罗斯方块.Util;

namespace 俄罗斯方块.Entities
{
    /// <summary>
    /// 背景方格類 用來描述每一個背景方格
    /// </summary>
    struct Block
    {
        /// <summary>
        /// 背景方格的類型
        /// </summary>
        BlockTypeEnum blockType;

        public BlockTypeEnum BlockType
        {
            get { return blockType; }
            set { blockType = value; }
        }

        /// <summary>
        /// 背景方格的顏色
        /// </summary>
        private Color blockColor;

        public Color BlockColor
        {
            get { return blockColor; }
            set { blockColor = value; }
        }
        /// <summary>
        /// 得到一個普通背景方格
        /// </summary>
        /// <returns></returns>
        public static Block GetABlankBolck() 
        {
            Block block = new Block();
            block.BlockType = BlockTypeEnum.Blank;
            block.blockColor = CommonHelper.BlankColor;
            return block;
        }

        /// <summary>
        /// 得到一個障礙物背景方格
        /// </summary>
        /// <returns></returns>
        public static Block GetAObstacleBolck()
        {
            Block block = new Block();
            block.BlockType = BlockTypeEnum.Obstacle;
            block.blockColor = CommonHelper.ObstacleColor;
            return block;
        }
          
    }
}
