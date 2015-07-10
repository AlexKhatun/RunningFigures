namespace RunningFigures
{
    using System;
    using System.Drawing;

    /// <summary>
    /// Class, which describe clashing of figures, and changing it direction
    /// </summary>
    [Serializable]
    public class FiguresClash
    {
        /// <summary>
        /// Figures change direction on clash
        /// </summary>
        /// <param name="figure1">First Figure</param>
        /// <param name="figure2">Second Figure</param>
        public void FigureClash(Figure figure1, Figure figure2)
        {
            figure1.Dx = -figure1.Dx;
            figure1.Dy = -figure1.Dy;
            if (figure1.GetType() != figure2.GetType())
            {
                figure1.FiguresClashed(figure2, new Point(Rectangle.Intersect(figure1.Model, figure2.Model).X, Rectangle.Intersect(figure1.Model, figure2.Model).Y));
            }
        }
    }
}
