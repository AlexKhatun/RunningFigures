﻿namespace RunningFigures
{
    using System;
    using System.Drawing;

    /// <summary>
    /// Event of Figure clashing
    /// </summary>
    [Serializable]
    public class FiguresClashEventArgs : EventArgs
    {
        /// <summary>
        /// 2 Clashed Figure
        /// </summary>
        private readonly Figure figure1, figure2;

        /// <summary>
        /// Clash Point
        /// </summary>
        private readonly Point clashPoint;

        /// <summary>
        /// Initializes a new instance of the <see cref="FiguresClashEventArgs"/> class. 
        /// </summary>
        /// <param name="figure1">First figure</param>
        /// <param name="figure2">Second figure</param>
        /// <param name="point">Clashing point</param>
        public FiguresClashEventArgs(Figure figure1, Figure figure2, Point point) 
        { 
            this.figure1 = figure1; 
            this.figure2 = figure2;
            this.clashPoint = point;
        }

        /// <summary>
        /// Gets first Figure
        /// </summary>
        public Figure Figure1 
        { 
            get 
            { 
                return this.figure1; 
            } 
        }

        /// <summary>
        /// Gets second Figure
        /// </summary>
        public Figure Figure2
        { 
            get 
            { 
                return this.figure2; 
            } 
        }

        /// <summary>
        /// Gets clashing Point
        /// </summary>
        public Point Point 
        { 
            get 
            { 
                return this.clashPoint; 
            } 
        }
    }
}
