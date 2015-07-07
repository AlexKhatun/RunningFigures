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
            : base(x, y, dx, dy, color, model, isMove)
        {
            
        }
        public override void Move(PictureBox drawingArea, List<Figure> figures)
        {
            if (Model.X + Model.Width >= drawingArea.Size.Width || Model.X <= 0)
            {
                Dx = -Dx;
            }
            else if (Model.Y + Model.Height >= drawingArea.Size.Height || Model.Y <= 0)
            {
                Dy = -Dy;
            }
            else
            {
                foreach (var i in figures)
                {
                    if (Model.IntersectsWith(i.GetModel()) && Model != i.GetModel())
                    {
                        Dx = -Dx;
                        Dy = -Dy;
                    }
                }
            }
            Model.X += +Dx;
            Model.Y += +Dy;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillPolygon(new SolidBrush(Color), new Point[] {new Point(Model.X + Model.Width/2, Model.Y), new Point(Model.X, Model.Y + Model.Height),new Point(Model.X + Model.Width, Model.Y + Model.Height)  });
        }
    }
}
