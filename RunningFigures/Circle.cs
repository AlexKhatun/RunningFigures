using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RunningFigures
{
    [Serializable]
    public class Circle : Figure
    {

        public Circle()
        {
            Model = new Rectangle(this.X, this.Y, Rand.Next(20,70), 0);
            Model.Height = Model.Width;
        }

        public Circle(int x, int y, int dx, int dy, Color color, Rectangle model, bool isMove)
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
            Model.X += + Dx;
            Model.Y += + Dy;
            X += Dx;
            Y += Dy;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(new SolidBrush(Color), Model);
        }
    }
}
