using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace RunningFigures
{
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

        protected Rectangle Model;
        [DataMember]
        public bool IsSelected { get; private set; }
        [DataMember]
        public bool IsMoveble { get; set; }

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
    }
}
