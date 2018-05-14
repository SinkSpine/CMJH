using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using 俄罗斯方块.Interface;
using 俄罗斯方块.Util;

namespace 俄罗斯方块.Entities
{
    /// <summary>
    /// 形狀父類
    /// </summary>
    abstract class Shape
    {
        //1.所以子類都由四個形狀單元組成
        //2.每個子類的形狀單元又不一樣，並且都有變形的方法，但變形方法不一樣
        //3沒有必要實例化一個Shape類

        //聲明一個ShapeUnit數組長度為4作為字段
        public ShapeUnit[] units = new ShapeUnit[4];

        /// <summary>
        /// 形狀遠點，九宮格的中心
        /// </summary>
        protected CellPosition shapePosition = new CellPosition();

        /// <summary>
        ///  形状当前的位置
        /// </summary>
        public Direction shapeDir = Direction.Up;
        /// <summary>
        /// 構造函數用於初始化units數組
        /// </summary>
        public Shape() 
        {
            for (int i = 0; i < units.Length; i++)
            {
                units[i] = new ShapeUnit();
            }
            this.SetUnitsPositon();
        }
        /// <summary>
        /// 每一個子類都由4個形狀單元組成 但是每個子類這四個元素的位置又不一樣，所以寫一個抽象方法 讓子類必須為數組元素的位置設置值
        /// </summary>
        protected abstract void SetUnitsPositon();

        /// <summary>
        /// 形狀自己畫自己的方法
        /// </summary>
        /// <param name="g"></param>
        public void DrawMe(Graphics g) 
        {
            lock (CommonHelper.lockKey)
            {
                //遍歷數組中每一個元素調用每一元素的DrawMe方法
                foreach (ShapeUnit u in this.units)
                {
                    u.DrawMe(g);
                }
            }
        }
        /// <summary>
        ///  形状擦除自己
        /// </summary>
        /// <param name="g"></param>
        public void WipeMe(Graphics g)
        {
            lock (CommonHelper.lockKey)
            {
                foreach (ShapeUnit unit in this.units)
                {
                    unit.WipeMe(g);
                }
            }
        }
        //形状向下移动
        public void MoveDown(Graphics g)
        {
            //1. 擦出当前形状
            this.WipeMe(g);
            //2. 移动当前形状的位置 rowIndex+1
            for (int i = 0; i < this.units.Length; i++)
            {
                units[i].Position = new CellPosition() { RowIndex = units[i].Position.RowIndex + 1, ColIndex = units[i].Position.ColIndex };
            }
            //改变形状原点的位置
            this.shapePosition.RowIndex++;
            //3. 根据新位置重新绘制形状.
            this.DrawMe(g);
        }
        /*******************************************形狀下落線程*********************************************************/
        IShapeMoveable shapeListener = null;
        Thread shapeMoveThread = null;
        bool isAlive = true;
        public void AddShapeListtener(IShapeMoveable shapeListener) 
        {
            this.shapeListener = shapeListener;
            shapeMoveThread = new Thread(MoveDownAuto);
            shapeMoveThread.IsBackground = true;
            shapeMoveThread.Start();
        }

        public void MoveDownAuto()
        {
            while (isAlive)
            {
                Thread.Sleep(450);
                //Thread.Sleep(120);
                this.shapeListener.ShapeMove(this);
            }
        }
        public void KillMe()
        {
            this.isAlive = false;
        }
        #region 向左移动 +void MoveToLeft(Graphics g)
        public void MoveToLeft(Graphics g)
        {
            this.WipeMe(g);
            for (int i = 0; i < units.Length; i++)
            {
                units[i].Position = new CellPosition() { RowIndex = units[i].Position.RowIndex, ColIndex = units[i].Position.ColIndex - 1 };
            }
            this.shapePosition.ColIndex--;
            this.DrawMe(g);
        }
        #endregion

        #region 向右移动+void MoveToRight(Graphics g)
        public void MoveToRight(Graphics g)
        {
            this.WipeMe(g);
            for (int i = 0; i < units.Length; i++)
            {
                units[i].Position = new CellPosition() { RowIndex = units[i].Position.RowIndex, ColIndex = units[i].Position.ColIndex + 1 };
            }
            this.shapePosition.ColIndex++;
            this.DrawMe(g);
        }
        #endregion

        #region 向下移动+void MoveToDown(Graphics g)
        public void MoveToDown(Graphics g)
        {
            this.WipeMe(g);
            for (int i = 0; i < units.Length; i++)
            {
                units[i].Position = new CellPosition() { RowIndex = units[i].Position.RowIndex + 1, ColIndex = units[i].Position.ColIndex };
            }
            this.shapePosition.RowIndex++;
            this.DrawMe(g);
        }
        #endregion
        
        /// <summary>
        /// 變形
        /// </summary>
        public abstract void RotateUp();
        public abstract void RotateDown();
        public abstract void RotateLeft();
        public abstract void RotateRight();

    }
}
