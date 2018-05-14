using 俄罗斯方块.Entities;
using System.Drawing;
using 俄罗斯方块.Interface;

namespace 俄罗斯方块.Controller
{
    class GameController:IShapeMoveable
    {
        Ground ground;
        ShapeFactory factory;
        Shape shape;
        Graphics g;
        IUIControl UIControl;

        public GameController(Graphics g, IUIControl UIControl) 
        {
            this.factory = new ShapeFactory();
            this.ground = new Ground();
            this.shape = factory.GetAShape();
            this.g = g;
            this.UIControl = UIControl;
        }

        public void NewGame() 
        {
            ground.initBlocks();
            this.ground.DrawMe(this.g);
            this.shape.DrawMe(this.g);
            this.shape.AddShapeListtener(this);
        }
        private void ReDisplay(Shape shape)
        {
            ground.DrawMe(g);
            shape.DrawMe(g);
        }
        public void ShapeMove(Shape shape)
        {
            if (this.IsMoveable(shape))//判断是否遇到障碍物或者是碰到底边
            {
                shape.MoveDown(g);
            }
            else//遇到障碍物或者到底
            {
                ground.KillAShape(shape); //将形状变成障碍物
                ground.CheckAndDeleteFullRow();
                if (ground.IsGameOver(shape))
                {
                    UIControl.GameOver();
                }
                else
                {
                    this.shape = factory.GetAShape();
                    this.ReDisplay(this.shape);
                    this.shape.AddShapeListtener(this);
                }
            }
        }

        public bool IsMoveable(Shape shape)
        {
            return ground.IsMoveable(shape, Direction.Down);
        }

        public void ProcessDialogKey(System.Windows.Forms.Keys keyData)
        {
            switch (keyData)
            {
                case System.Windows.Forms.Keys.Up:
                    //1. 判断是否可以变形. 主要判断变形后是否有障碍物或者越界.
                    //1.1 进行后台变形.
                    //1.2 判断变形后是否遇到障碍物或者越界.
                    if (ground.IsRotateable(shape))
                    {
                        shape.WipeMe(g);
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
                        shape.DrawMe(g);
                    }
                    break;
                case System.Windows.Forms.Keys.Down:
                    if (ground.IsMoveable(shape, Direction.Down))
                    {
                        shape.MoveToDown(g);
                    }
                    break;
                case System.Windows.Forms.Keys.Left:
                    if (ground.IsMoveable(shape, Direction.Left))
                    {
                        shape.MoveToLeft(g);
                    }
                    break;
                case System.Windows.Forms.Keys.Right:
                    if (ground.IsMoveable(shape, Direction.Right))
                    {
                        shape.MoveToRight(g);
                    }
                    break;
            }
        }
    }
}
