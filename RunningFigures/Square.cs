namespace RunningFigures
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using Properties;

    /// <summary>
    /// Class for square, describing by rectangle
    /// </summary>
    [Serializable]
    public class Square : Figure
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class. All fields will be random
        /// </summary>
        public Square()
        {
            this.Model = new Rectangle(this.X, this.Y, this.Rand.Next(20, 70), 0);
            this.Model.Height = this.Model.Width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class. 
        /// </summary>
        /// <param name="x">X Coordinate</param>
        /// <param name="y">Y Coordinate</param>
        /// <param name="dx">X Speed</param>
        /// <param name="dy">Y Speed</param>
        /// <param name="color">Figure Color</param>
        /// <param name="model">Rectangle Model</param>
        /// <param name="isMove">Can this figure move?</param>
        public Square(int x, int y, int dx, int dy, Color color, Rectangle model, bool isMove)
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
        /// Draw Square
        /// </summary>
        /// <param name="graphics">PictureBox's graphics element</param>
        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(new SolidBrush(Color), this.Model);
        }

        public override string ToString()
        {
            string result = "Square";
            if (Settings.Default.Language == "ru")
            {
                result = "Квадрат";
            }
            return result;
        }
    }
}
