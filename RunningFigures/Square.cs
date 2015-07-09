namespace RunningFigures
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    [Serializable]
    public class Square : Figure
    {
        public Square()
        {
            this.Model = new Rectangle(this.X, this.Y, this.Rand.Next(20, 70), 0);
            this.Model.Height = this.Model.Width;
        }

        public Square(int x, int y, int dx, int dy, Color color, Rectangle model, bool isMove)
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
            graphics.FillRectangle(new SolidBrush(color), this.Model);
        }
    }
}
