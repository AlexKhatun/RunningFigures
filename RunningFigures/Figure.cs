using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace RunningFigures
{

    public delegate void BeepDelegate();


    [Serializable]
    [DataContract]
    [KnownType(typeof(Triangle))]
    [KnownType(typeof(Circle))]
    [KnownType(typeof(Square))]
    public abstract class Figure
    {
        protected Figure()
        {
            Rand = new Random();
            X = Rand.Next(50, 440);
            Y = Rand.Next(50, 150);
            Dx = Rand.Next(-5, 5);
            Dy = Rand.Next(-5, 5);
            color = Color.FromArgb(Rand.Next(128, 255), Rand.Next(128, 255), Rand.Next(128, 255), Rand.Next(128, 255));
            IsMoveble = true;
            IsSelected = false;
            NewClash += ClashFigure;
            Beep += SystemSounds.Beep.Play;
            Beep -= SystemSounds.Beep.Play;
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
            Rand = new Random();
            NewClash += ClashFigure;
            Beep += SystemSounds.Beep.Play;
        }

        [DataMember]
        public int X
        {
            get
            {
                return Model.X; 
            }
            protected set
            {
                Model.X = value;
            }
        }

        [DataMember]
        public int Y
        {
            get
            {
                return Model.Y;
            }
            protected set
            {
                Model.Y = value;
            }
        }
        [DataMember]
        public int Width
        {
            get
            {
                return Model.Width;
            }
            protected set
            {
                Model.Width = value;
            }
        }
        [DataMember]
        public int Height
        {
            get
            {
                return Model.Height;
            }
            protected set
            {
                Model.Height = value;
            }
        }

        [DataMember]
        public int Dx { get; set; }

        [DataMember]
        public int Dy { get; set; }

        protected Color color;

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
        protected Random Rand;

        public Rectangle Model;
        [DataMember]
        public bool IsSelected { get; private set; }
        [DataMember]
        public bool IsMoveble { get; set; }

        public FiguresClash FiguresClash = new FiguresClash();

        public event EventHandler<FiguresClashEventArgs> NewClash;

        private BeepDelegate Beep;

        public void AddBeep()
        {
            Beep += SystemSounds.Beep.Play;
        }

        public void RemoveBeep()
        {
            Beep -= SystemSounds.Beep.Play;
        }

        public void FiguresClashed(Figure enemy, Point p)
        {
            FiguresClashEventArgs e = new FiguresClashEventArgs(this, enemy, p);
            this.OnNewClash(e);
        }

        public virtual void Move(PictureBox drawingArea, List<Figure> figures)
        {
            if (Model.X + Model.Width >= drawingArea.Size.Width || Model.X <= 0)
            {
                Dx = -Dx;
            }
            else if (Model.Y + Model.Height >= drawingArea.Size.Height || Model.Y <= 0)
            {
                Dy = -Dy;
            }
            X += Dx;
            Y += Dy;
        }

        public abstract void Draw(Graphics graphics);

        public void Select()
        {
            IsSelected = !IsSelected;
            color = IsSelected ? Color.BlueViolet : Color.FromArgb(Rand.Next(255), Rand.Next(255), Rand.Next(255), Rand.Next(255));
        }

        public bool IntersectWith(Figure figure)
        {
            bool flag = Model.IntersectsWith(figure.Model);
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
        private void ClashFigure(object sender, FiguresClashEventArgs e)
        {
            string s = string.Format(e.Figure1.GetType().ToString(), e.Figure2.GetType().ToString(), e.Point.X, e.Point.Y);
            Console.WriteLine(e.Figure1.GetType().ToString().Substring(15) + ' ' + e.Figure2.GetType().ToString().Substring(15) + ' ' + e.Point.X + ' ' + e.Point.Y);
            Beep();
        }
    }
}
