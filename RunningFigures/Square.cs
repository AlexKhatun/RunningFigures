using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RunningFigures
{
    [Serializable]
    public class Square : Figure
    {
        public Square()
        {
            Model = new Rectangle(this.X, this.Y, Rand.Next(20,70), 0);
            Model.Height = Model.Width;
        }

        public Square(int x, int y, int dx, int dy, Color color, Rectangle model, bool isMove)
            : base(x, y, dx, dy, color, model, isMove) { }

        public override void Move(PictureBox drawingArea, List<Figure> figures )
        {
            base.Move(drawingArea, figures);
            foreach (var i in figures)
            {
                if (this != i && IntersectWith(i))
                {
                    Dx = -Dx;
                    Dy = -Dy;
                }
            }
            X += +Dx;
            Y += +Dy;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(new SolidBrush(color), Model );
        }
    }
}
