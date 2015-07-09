namespace RunningFigures
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Media;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Xml.Linq;

    public class Serializer
    {
        private readonly BinaryFormatter binaryFormatter;
        private List<Figure> figureList;
        private XDocument doc;
        private Rectangle model;
        private Color color;
        private int x;
        private int y;
        private int dx;
        private int dy;
        private bool isMoveble;

        public Serializer()
        {
            this.binaryFormatter = new BinaryFormatter();
            this.figureList = new List<Figure>();
        }

        public void BinarySerialization(List<Figure> figures)
        {
            using (FileStream fs = new FileStream("figures.dat", FileMode.OpenOrCreate))
            {
                this.binaryFormatter.Serialize(fs, figures);
            }
        }

        public List<Figure> BinaryDeserialization()
        {
            this.figureList.Clear();
            using (FileStream fs = new FileStream("figures.dat", FileMode.OpenOrCreate))
            {
                    this.figureList = (List<Figure>)this.binaryFormatter.Deserialize(fs);
            }
            foreach (var i in this.figureList)
            {
                i.Beep += SystemSounds.Beep.Play;
            }
            return this.figureList;
        }

        public void XmlSerializarion(List<Figure> figures)
        {
            this.doc = new XDocument(new XElement("Figures"));
            foreach (var i in figures)
            {
                var addingElement = new XElement("Figure");
                addingElement.SetAttributeValue("Name", i.GetType().ToString());
                addingElement.SetAttributeValue("X", i.X);
                addingElement.SetAttributeValue("Y", i.Y);
                addingElement.SetAttributeValue("Dx", i.Dx);
                addingElement.SetAttributeValue("Dy", i.Dy);
                addingElement.SetAttributeValue("IsMoveble", i.IsMoveble);
                addingElement.SetAttributeValue("ModelHeight", i.Height);
                addingElement.SetAttributeValue("ModelWidth", i.Width);
                addingElement.SetAttributeValue("ColorA", i.Color.A);
                addingElement.SetAttributeValue("ColorB", i.Color.B);
                addingElement.SetAttributeValue("ColorG", i.Color.G);
                addingElement.SetAttributeValue("ColorR", i.Color.R);
                this.doc.Root.Add(addingElement);
            }
            this.doc.Save("figures.xml");
        }

        public List<Figure> XmlDeserialization()
        {
            this.figureList.Clear();
            XDocument doc = XDocument.Load("figures.xml");
            foreach (XElement element in doc.Root.Elements())
            {
                switch (element.Attribute("Name").Value)
                {
                    case "RunningFigures.Circle":
                        this.figureList.Add(this.ConstructCircle(element));
                        break;
                    case "RunningFigures.Square":
                        this.figureList.Add(this.ConstructSquare(element));
                        break;
                    case "RunningFigures.Triangle":
                        this.figureList.Add(this.ConstructTriangle(element));
                        break;
                }
            }
            return tthis.figureList;
        }
        private Circle ConstructCircle(XElement element)
        {
            this.x = Convert.ToInt32(element.Attribute("X").Value);
            this.y = Convert.ToInt32(element.Attribute("Y").Value);
            this.dx = Convert.ToInt32(element.Attribute("Dx").Value);
            this.dy = Convert.ToInt32(element.Attribute("Dy").Value);
            this.isMoveble = Convert.ToBoolean(element.Attribute("IsMoveble").Value);
            this.model = new Rectangle(
                Convert.ToInt32(element.Attribute("X").Value),
                Convert.ToInt32(element.Attribute("Y").Value),
                Convert.ToInt32(element.Attribute("ModelWidth").Value),
                Convert.ToInt32(element.Attribute("ModelHeight").Value));
            this.color = Color.FromArgb(
                Convert.ToInt32(element.Attribute("ColorA").Value),
                Convert.ToInt32(element.Attribute("ColorR").Value),
                Convert.ToInt32(element.Attribute("ColorG").Value),
                Convert.ToInt32(element.Attribute("ColorB").Value));
            return new Circle(this.x, this.y, this.dx, this.dy, this.color, this.model, this.isMoveble);
        }

        private Square ConstructSquare(XElement element)
        {
            this.x = Convert.ToInt32(element.Attribute("X").Value);
            this.y = Convert.ToInt32(element.Attribute("Y").Value);
            this.dx = Convert.ToInt32(element.Attribute("Dx").Value);
            this.dy = Convert.ToInt32(element.Attribute("Dy").Value);
            this.isMoveble = Convert.ToBoolean(element.Attribute("IsMoveble").Value);
            this.model = new Rectangle(
                Convert.ToInt32(element.Attribute("X").Value),
                Convert.ToInt32(element.Attribute("Y").Value),
                Convert.ToInt32(element.Attribute("ModelWidth").Value),
                Convert.ToInt32(element.Attribute("ModelHeight").Value));
            this.color = Color.FromArgb(
                Convert.ToInt32(element.Attribute("ColorA").Value),
                Convert.ToInt32(element.Attribute("ColorR").Value),
                Convert.ToInt32(element.Attribute("ColorG").Value),
                Convert.ToInt32(element.Attribute("ColorB").Value));
            return new Square(this.x, this.y, this.dx, this.dy, this.color, this.model, this.isMoveble);
        }

        private Triangle ConstructTriangle(XElement element)
        {
            this.x = Convert.ToInt32(element.Attribute("X").Value);
            this.y = Convert.ToInt32(element.Attribute("Y").Value);
            this.dx = Convert.ToInt32(element.Attribute("Dx").Value);
            this.dy = Convert.ToInt32(element.Attribute("Dy").Value);
            this.isMoveble = Convert.ToBoolean(element.Attribute("IsMoveble").Value);
            this.model = new Rectangle(
                Convert.ToInt32(element.Attribute("X").Value),
                Convert.ToInt32(element.Attribute("Y").Value),
                Convert.ToInt32(element.Attribute("ModelWidth").Value),
                Convert.ToInt32(element.Attribute("ModelHeight").Value));
            this.color = Color.FromArgb(
                Convert.ToInt32(element.Attribute("ColorA").Value),
                Convert.ToInt32(element.Attribute("ColorR").Value),
                Convert.ToInt32(element.Attribute("ColorG").Value),
                Convert.ToInt32(element.Attribute("ColorB").Value));
            return new Triangle(this.x, this.y, this.dx, this.dy, this.color, this.model, this.isMoveble);
        }


        public void JsonSerializarion(List<Figure> figures)
        {
            StreamWriter strOut = new StreamWriter("figures.json");
            DataContractSerializer serializer = new DataContractSerializer(typeof(List<Figure>));
            serializer.WriteObject(strOut.BaseStream, figures);
            strOut.Close();
        }

        public List<Figure> JsonDeserialization()
        {
            this.figureList.Clear();
            StreamReader strIn = new StreamReader("figures.json");
            DataContractSerializer deserializer = new DataContractSerializer(typeof(List<Figure>));
            this.figureList = (List<Figure>)deserializer.ReadObject(strIn.BaseStream);
            strIn.Close();
            foreach (var i in this.figureList)
            {
                i.Beep += SystemSounds.Beep.Play;
                i.NewClash += i.ClashFigure;
                i.FiguresClash = new FiguresClash();
            }
            return this.figureList;
        }

        
    }
}
