namespace RunningFigures
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Media;
    using System.Runtime.Serialization;
    using System.Windows.Forms;

    public delegate void BeepDelegate();

    [Serializable]
    [DataContract]
    [KnownType(typeof(Triangle))]
    [KnownType(typeof(Circle))]
    [KnownType(typeof(Square))]
    public abstract class Figure
    {
        

        protected Color color;

        [DataMember]
        protected Random Rand;

        public Rectangle Model;

        public FiguresClash FiguresClash = new FiguresClash();

        public event EventHandler<FiguresClashEventArgs> NewClash;

        [NonSerialized] 
        public BeepDelegate Beep;

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

        [DataMember]
        public int Dx { get; set; }

        [DataMember]
        public int Dy { get; set; }

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

        [DataMember]
        public bool IsSelected { get; private set; }
        [DataMember]
        public bool IsMoveble { get; set; }

        public void AddBeep()
        {
            this.Beep += SystemSounds.Beep.Play;
        }

        public void RemoveBeep()
        {
            this.Beep -= SystemSounds.Beep.Play;
        }

        public void FiguresClashed(Figure enemy, Point p)
        {
            FiguresClashEventArgs e = new FiguresClashEventArgs(this, enemy, p);
            this.OnNewClash(e);
        }

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

        public abstract void Draw(Graphics graphics);

        public void Select()
        {
            this.IsSelected = !this.IsSelected;
            this.color = this.IsSelected ? Color.BlueViolet : Color.FromArgb(this.Rand.Next(255), this.Rand.Next(255), this.Rand.Next(255), this.Rand.Next(255));
        }

        public bool IntersectWith(Figure figure)
        {
            bool flag = this.Model.IntersectsWith(figure.Model);
            return flag;
        }

        protected virtual void OnNewClash(FiguresClashEventArgs e)
        {
            EventHandler<FiguresClashEventArgs> temp = this.NewClash;
            if (temp != null)
            {
                temp(this, e);
            }
        }

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
    }
}
