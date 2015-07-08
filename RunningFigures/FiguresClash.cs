using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace RunningFigures
{   [Serializable]
    public class FiguresClash
    {
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
