using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
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
            : base(x, y, dx, dy, color, model, isMove) { }

        public override void Move(PictureBox drawingArea, List<Figure> figures)
        {
            foreach (var i in figures)
            {
                if (this != i && IntersectWith(i))
                {
                    FiguresClash.FigureClash(this, i);
                }
            }
            base.Move(drawingArea, figures);

        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(new SolidBrush(color), Model);
        }
    }
}
