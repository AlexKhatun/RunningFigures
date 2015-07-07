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
            Color = Color.FromArgb(Rand.Next(128, 255), Rand.Next(128, 255), Rand.Next(128, 255), Rand.Next(128, 255));
            IsMoveble = true;
            IsSelected = false;
        }

        protected Figure(int x, int y, int dx, int dy, Color color, Rectangle model, bool isMove)
        {
            this.X = x;
            this.Y = y;
            this.Dx = dx;
            this.Dy = dy;
            this.Color = color;
            this.Model = model;
            this.IsMoveble = isMove;
            this.IsSelected = false;
            Rand = new Random();
        }
        [DataMember]
        public int X { get; set; }
        [DataMember]
        public int Y { get; set; }
        [DataMember]
        public int Dx { get; set; }
        [DataMember]
        public int Dy { get; set; }
        [DataMember]
        protected Color Color { get; set; }
        [DataMember]
        protected Random Rand;
        [DataMember]
        protected Rectangle Model;
        [DataMember]
        public bool IsSelected { get; private set; }
        [DataMember]
        public bool IsMoveble { get; set; }

        public abstract void Move(PictureBox drawingArea, List<Figure> figures);

        public abstract void Draw(Graphics graphics);

        public Rectangle GetModel()
        {
            return this.Model;
        }

        public Color GetColor()
        {
            return this.Color;
        }

        public void Select()
        {
            IsSelected = !IsSelected;
            Color = IsSelected ? Color.Black : Color.FromArgb(Rand.Next(255), Rand.Next(255), Rand.Next(255), Rand.Next(255));
        }
    }
}
