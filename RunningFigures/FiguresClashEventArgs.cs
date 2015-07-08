using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningFigures
{
    public class FiguresClashEventArgs : EventArgs
    {
        private readonly Figure figure1, figure2;
        private readonly Point clashPoint;

        public FiguresClashEventArgs(Figure figure1, Figure figure2, Point point) 
        { 
            this.figure1 = figure1; 
            this.figure2 = figure2;
            this.clashPoint = point;
        }

        public Figure Figure1 
        { 
            get 
            { 
                return this.figure1; 
            } 
        }

        public Figure Figure2
        { 
            get 
            { 
                return this.figure2; 
            } 
        }

        public Point Point 
        { 
            get 
            { 
                return this.clashPoint; 
            } 
        }
    }
}
