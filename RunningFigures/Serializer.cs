using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;

namespace RunningFigures
{
    public class Serializer
    {
        public Serializer()
        {
            binaryFormatter = new BinaryFormatter();
            figureList = new List<Figure>();
        }

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

        public void BinarySerialization(List<Figure> figures)
        {
            using (FileStream fs = new FileStream("figures.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fs, figures);
            }
        }

        public List<Figure> BinaryDeserialization()
        {
            figureList.Clear();
            using (FileStream fs = new FileStream("figures.dat", FileMode.OpenOrCreate))
            {
                    figureList = (List<Figure>)binaryFormatter.Deserialize(fs);
            }
            //foreach (var i in figureList)
            //{
            //    i.Beep += SystemSounds.Beep.Play;
            //}
            return figureList;
        }

        public void XmlSerializarion(List<Figure> figures)
        {
            doc = new XDocument(new XElement("Figures"));
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
                doc.Root.Add(addingElement);
            }
            doc.Save("figures.xml");
        }

        public List<Figure> XmlDeserialization()
        {
            figureList.Clear();
            XDocument doc = XDocument.Load("figures.xml");
            foreach (XElement element in doc.Root.Elements())
            {
                switch (element.Attribute("Name").Value)
                {
                    case "RunningFigures.Circle":
                        figureList.Add(ConstructCircle(element));
                        break;
                    case "RunningFigures.Square":
                        figureList.Add(ConstructSquare(element));
                        break;
                    case "RunningFigures.Triangle":
                        figureList.Add(ConstructTriangle(element));
                        break;
                }
            }
            return figureList;
        }
        private Circle ConstructCircle(XElement element)
        {
            x = Convert.ToInt32(element.Attribute("X").Value);
            y = Convert.ToInt32(element.Attribute("Y").Value);
            dx = Convert.ToInt32(element.Attribute("Dx").Value);
            dy = Convert.ToInt32(element.Attribute("Dy").Value);
            isMoveble = Convert.ToBoolean(element.Attribute("IsMoveble").Value);
            model = new Rectangle(Convert.ToInt32(element.Attribute("X").Value),
                     Convert.ToInt32(element.Attribute("Y").Value),
                     Convert.ToInt32(element.Attribute("ModelWidth").Value),
                     Convert.ToInt32(element.Attribute("ModelHeight").Value)
                     );
            color = Color.FromArgb(Convert.ToInt32(element.Attribute("ColorA").Value),
                Convert.ToInt32(element.Attribute("ColorR").Value),
                Convert.ToInt32(element.Attribute("ColorG").Value),
                Convert.ToInt32(element.Attribute("ColorB").Value));
            return new Circle(x, y, dx, dy, color, model, isMoveble);
        }

        private Square ConstructSquare(XElement element)
        {
            x = Convert.ToInt32(element.Attribute("X").Value);
            y = Convert.ToInt32(element.Attribute("Y").Value);
            dx = Convert.ToInt32(element.Attribute("Dx").Value);
            dy = Convert.ToInt32(element.Attribute("Dy").Value);
            isMoveble = Convert.ToBoolean(element.Attribute("IsMoveble").Value);
            model = new Rectangle(Convert.ToInt32(element.Attribute("X").Value),
                     Convert.ToInt32(element.Attribute("Y").Value),
                     Convert.ToInt32(element.Attribute("ModelWidth").Value),
                     Convert.ToInt32(element.Attribute("ModelHeight").Value)
                     );
            color = Color.FromArgb(Convert.ToInt32(element.Attribute("ColorA").Value),
                Convert.ToInt32(element.Attribute("ColorR").Value),
                Convert.ToInt32(element.Attribute("ColorG").Value),
                Convert.ToInt32(element.Attribute("ColorB").Value));
            return new Square(x, y, dx, dy, color, model, isMoveble);
        }

        private Triangle ConstructTriangle(XElement element)
        {
            x = Convert.ToInt32(element.Attribute("X").Value);
            y = Convert.ToInt32(element.Attribute("Y").Value);
            dx = Convert.ToInt32(element.Attribute("Dx").Value);
            dy = Convert.ToInt32(element.Attribute("Dy").Value);
            isMoveble = Convert.ToBoolean(element.Attribute("IsMoveble").Value);
            model = new Rectangle(Convert.ToInt32(element.Attribute("X").Value),
                     Convert.ToInt32(element.Attribute("Y").Value),
                     Convert.ToInt32(element.Attribute("ModelWidth").Value),
                     Convert.ToInt32(element.Attribute("ModelHeight").Value)
                     );
            color = Color.FromArgb(Convert.ToInt32(element.Attribute("ColorA").Value),
                Convert.ToInt32(element.Attribute("ColorR").Value),
                Convert.ToInt32(element.Attribute("ColorG").Value),
                Convert.ToInt32(element.Attribute("ColorB").Value));
            return new Triangle(x, y, dx, dy, color, model, isMoveble);
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
            figureList.Clear();
            StreamReader strIn = new StreamReader("figures.json");
            DataContractSerializer deserializer = new DataContractSerializer(typeof(List<Figure>));
            figureList = (List<Figure>)deserializer.ReadObject(strIn.BaseStream);
            strIn.Close();
            foreach (var i in figureList)
            {
                i.Beep += SystemSounds.Beep.Play;
                i.NewClash += i.ClashFigure;
                i.FiguresClash = new FiguresClash();
            }
            return figureList;
        }

        
    }
}
