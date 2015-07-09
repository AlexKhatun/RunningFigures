namespace RunningFigures
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    [Serializable]
    public class Triangle : Figure
    {
        public Triangle()
        {
            this.Model = new Rectangle(this.X, this.Y, Rand.Next(20, 70), Rand.Next(20, 70));
        }

        public Triangle(int x, int y, int dx, int dy, Color color, Rectangle model, bool isMove)
            : base(x, y, dx, dy, color, model, isMove) { }

        public override void Move(PictureBox drawingArea, List<Figure> figures)
        {
            foreach (var i in figures)
            {
                if (this != i && this.IntersectWith(i))
                {
                    FiguresClash.FigureClash(this, i);
                }
            }
            base.Move(drawingArea, figures);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillPolygon(new SolidBrush(color), new Point[] { new Point(Model.X + Model.Width / 2, Model.Y), new Point(Model.X, Model.Y + Model.Height), new Point(Model.X + Model.Width, Model.Y + Model.Height) });
        }
    }
}
