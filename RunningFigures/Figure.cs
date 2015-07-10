namespace RunningFigures
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Media;
    using System.Runtime.Serialization;
    using System.Windows.Forms;

    /// <summary>
    /// Delegate, which counted Beeps on Figure Clashing
    /// </summary>
    public delegate void BeepDelegate();

    /// <summary>
    /// AbstractClass to all figures types
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(Triangle))]
    [KnownType(typeof(Circle))]
    [KnownType(typeof(Square))]
    public abstract class Figure
    {
        /// <summary>
        /// On this model we building Figure
        /// </summary>
        public Rectangle Model;

        /// <summary>
        /// Event clashing figures field
        /// </summary>
        public FiguresClash FiguresClash = new FiguresClash();

        /// <summary>
        /// Beep counter
        /// </summary>
        [NonSerialized] 
        public BeepDelegate Beep;

        /// <summary>
        /// Figure color
        /// </summary>
        private Color color;

        /// <summary>
        /// Field, which generic random on all other fields
        /// </summary>
        [DataMember]
        private Random rand;

        /// <summary>
        /// Initializes a new instance of the <see cref="Figure"/> class. All fields will be random
        /// </summary>
        protected Figure()
        {
            this.Rand = new Random();
            this.X = this.Rand.Next(50, 440);
            this.Y = this.Rand.Next(50, 150);
            this.Dx = this.Rand.Next(-5, 5);
            this.Dy = this.Rand.Next(-5, 5);
            this.color = Color.FromArgb(this.Rand.Next(128, 255), this.Rand.Next(128, 255), this.Rand.Next(128, 255), this.Rand.Next(128, 255));
            this.IsMoveble = true;
            this.IsSelected = false;
            this.NewClash += this.ClashFigure;
            this.Beep += SystemSounds.Beep.Play;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Figure"/> class. 
        /// </summary>
        /// <param name="x">X Coordinate</param>
        /// <param name="y">Y Coordinate</param>
        /// <param name="dx">X Speed</param>
        /// <param name="dy">Y Speed</param>
        /// <param name="color">Figure Color</param>
        /// <param name="model">Rectangle Model</param>
        /// <param name="isMove">Can this figure move?</param>
        protected Figure(int x, int y, int dx, int dy, Color color, Rectangle model, bool isMove)
        {
            this.X = x;
            this.Y = y;
            this.Dx = dx;
            this.Dy = dy;
            this.color = color;
            this.Model = model;
            this.IsMoveble = isMove;
            this.IsSelected = false;
            this.Rand = new Random();
            this.NewClash += this.ClashFigure;
            this.Beep += SystemSounds.Beep.Play;
        }

        /// <summary>
        /// Event of clashing figures
        /// </summary>
        public event EventHandler<FiguresClashEventArgs> NewClash;

        /// <summary>
        /// Gets or sets the X coordinate of Figure
        /// </summary>
        [DataMember]
        public int X
        {
            get
            {
                return this.Model.X;
            }

            set
            {
                this.Model.X = value;
            }
        }

        /// <summary>
        /// Gets or sets the Y coordinate of Figure
        /// </summary>
        [DataMember]
        public int Y
        {
            get
            {
                return this.Model.Y;
            }

            set
            {
                this.Model.Y = value;
            }
        }

        /// <summary>
        /// Gets or sets the width of Figure
        /// </summary>
        [DataMember]
        public int Width
        {
            get
            {
                return this.Model.Width;
            }

            protected set
            {
                this.Model.Width = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of Figure
        /// </summary>
        [DataMember]
        public int Height
        {
            get
            {
                return this.Model.Height;
            }

            protected set
            {
                this.Model.Height = value;
            }
        }

        /// <summary>
        /// Gets or sets the X speed of Figure
        /// </summary>
        [DataMember]
        public int Dx { get; set; }

        /// <summary>
        /// Gets or sets the Y speed of Figure
        /// </summary>
        [DataMember]
        public int Dy { get; set; }

        /// <summary>
        /// Gets or sets the color of Figure
        /// </summary>
        [DataMember]
        public Color Color
        {
            get
            {
                return this.color;
            }

            protected set
            {
                this.color = value;
            }
        }

        /// <summary>
        /// Gets a value indicating whether Figure selected or no
        /// </summary>
        [DataMember]
        public bool IsSelected { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether moving figure
        /// </summary>
        [DataMember]
        public bool IsMoveble { get; set; }

        /// <summary>
        /// Gets or sets rand field
        /// </summary>
        protected Random Rand
        {
            get
            {
                return this.rand;
            }

            set
            {
                this.rand = value;
            }
        }

        /// <summary>
        /// Add beep to Figure clash event
        /// </summary>
        public void AddBeep()
        {
            this.Beep += SystemSounds.Beep.Play;
        }

        /// <summary>
        /// Remove beep from Figure clash event
        /// </summary>
        public void RemoveBeep()
        {
            this.Beep -= SystemSounds.Beep.Play;
        }

        /// <summary>
        /// Clash Figure event call
        /// </summary>
        /// <param name="enemy">Second Figure</param>
        /// <param name="p">Clash Point</param>
        public void FiguresClashed(Figure enemy, Point p)
        {
            FiguresClashEventArgs e = new FiguresClashEventArgs(this, enemy, p);
            this.OnNewClash(e);
        }

        /// <summary>
        /// Move all Figures with Exception, can't go from area
        /// </summary>
        /// <param name="drawingArea">Picture Box</param>
        /// <param name="figures">All Figure list</param>
        public virtual void Move(PictureBox drawingArea, List<Figure> figures)
        {
            if (this.X + this.Model.Width <= 0 || this.X >= drawingArea.Size.Width || this.Y + this.Model.Height <= 0 ||
                this.Y >= drawingArea.Size.Height)
            {
               throw new FigureOutOfRangeException("Фигура потерялась!");
            }

            if (this.Model.X + this.Model.Width >= drawingArea.Size.Width || this.Model.X <= 0)
            {
                this.Dx = -this.Dx;
            }
            else if (this.Model.Y + this.Model.Height >= drawingArea.Size.Height || this.Model.Y <= 0)
            {
                this.Dy = -this.Dy;
            }

            this.X += this.Dx;
            this.Y += this.Dy;
        }

        /// <summary>
        /// Draw Figure
        /// </summary>
        /// <param name="graphics">PictureBox's graphics element</param>
        public abstract void Draw(Graphics graphics);

        /// <summary>
        /// Select this Figure
        /// </summary>
        public void Select()
        {
            this.IsSelected = !this.IsSelected;
            this.color = this.IsSelected ? Color.BlueViolet : Color.FromArgb(this.Rand.Next(255), this.Rand.Next(255), this.Rand.Next(255), this.Rand.Next(255));
        }

        /// <summary>
        /// Intersect with another Figure
        /// </summary>
        /// <param name="figure">Second Figure</param>
        /// <returns>Is this Figure intersect with parameter</returns>
        public bool IntersectWith(Figure figure)
        {
            bool flag = this.Model.IntersectsWith(figure.Model);
            return flag;
        }

        /// <summary>
        /// Clashing event Call, figures change direction
        /// </summary>
        /// <param name="sender">Call event parameter</param>
        /// <param name="e">Clash event</param>
        public void ClashFigure(object sender, FiguresClashEventArgs e)
        {
            Console.WriteLine(e.Figure1.GetType().ToString().Substring(15) + ' ' + e.Figure2.GetType().ToString().Substring(15) + ' ' + e.Point.X + ' ' + e.Point.Y);
            try
            {
                this.Beep();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Для этой фигуры нет бипов!");
            }
        }

        /// <summary>
        /// Call clash event
        /// </summary>
        /// <param name="e">Clash event</param>
        protected virtual void OnNewClash(FiguresClashEventArgs e)
        {
            EventHandler<FiguresClashEventArgs> temp = this.NewClash;
            if (temp != null)
            {
                temp(this, e);
            }
        }
    }
}
