using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RunningFigures
{
    [Serializable]
    public class Triangle : Figure
    {
        public Triangle()
        {
            Model = new Rectangle(this.X, this.Y, Rand.Next(20, 70), Rand.Next(20,70));
        }

        public Triangle(int x, int y, int dx, int dy, Color color, Rectangle model, bool isMove)
            : base(x, y, dx, dy, color, model, isMove) { }

        public override void Move(PictureBox drawingArea, List<Figure> figures)
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
            Model.X += +Dx;
            Y += +Dy;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillPolygon(new SolidBrush(color), new Point[] {new Point(Model.X + Model.Width/2, Model.Y), new Point(Model.X, Model.Y + Model.Height),new Point(Model.X + Model.Width, Model.Y + Model.Height)  });
        }
    }
}
