namespace RunningFigures
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using RunningFigures.Properties;

    /// <summary>
    /// Class for triangle, describing by rectangle
    /// </summary>
    [Serializable]
    public class Triangle : Figure
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class. All fields will be random
        /// </summary>
        public Triangle()
        {
            this.Model = new Rectangle(this.X, this.Y, Rand.Next(20, 70), Rand.Next(20, 70));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class. 
        /// </summary>
        /// <param name="x">X Coordinate</param>
        /// <param name="y">Y Coordinate</param>
        /// <param name="dx">X Speed</param>
        /// <param name="dy">Y Speed</param>
        /// <param name="color">Figure Color</param>
        /// <param name="model">Rectangle Model</param>
        /// <param name="isMove">Can this figure move?</param>
        public Triangle(int x, int y, int dx, int dy, Color color, Rectangle model, bool isMove)
            : base(x, y, dx, dy, color, model, isMove)
        {
        }

        /// <summary>
        /// Move all Figures with base call and clashing
        /// </summary>
        /// <param name="drawingArea">Picture Box</param>
        /// <param name="figures">All Figure list</param>
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

        /// <summary>
        /// Draw Triangle
        /// </summary>
        /// <param name="graphics">PictureBox's graphics element</param>
        public override void Draw(Graphics graphics)
        {
            graphics.FillPolygon(new SolidBrush(Color), new Point[] { new Point(Model.X + (Model.Width / 2), Model.Y), new Point(Model.X, Model.Y + Model.Height), new Point(Model.X + Model.Width, Model.Y + Model.Height) });
        }

        public override string ToString()
        {
            string result = "Triangle";
            if (Settings.Default.Language == "ru")
            {
                result = "Треугольник";
            }
            return result;
        }
    }
}
