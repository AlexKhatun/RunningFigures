namespace RunningFigures
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Properties;

    public partial class MainForm : Form
    {
        private readonly Serializer serializer;
        private readonly List<Figure> figures;
        public MainForm()
        {
            Task.Factory.StartNew(this.Console1);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Settings.Default.Language);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Settings.Default.Language);
            this.InitializeComponent();
            this.timerRefresher.Start();
            this.timerRefresher.Interval = 10;
            this.figures = new List<Figure>();
            this.serializer = new Serializer();

        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeConsole();

        private void Console1()
        {
            if (AllocConsole())
            {
                System.Console.WriteLine("Для выхода наберите exit.");
                while (true)
                {
                    string output = System.Console.ReadLine();
                    if (output == "exit")
                    {
                        break;
                    }
                }

                FreeConsole();
            }
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            Square square = new Square();
            this.AddFigure(square);
        }

        private void TriangleButton_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle();
            this.AddFigure(triangle);
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            this.AddFigure(circle);
        }

        private void timerRefresher_Tick(object sender, EventArgs e)
        {
            DrawingArea.Refresh();
        }

        private void DrawingArea_Paint(object sender, PaintEventArgs e)
        {
            foreach (var i in this.figures)
            {
                i.Draw(e.Graphics);
                if (i.IsMoveble)
                {
                    try
                    {
                        i.Move(this.DrawingArea, this.figures);
                    }
                    catch (FigureOutOfRangeException ex)
                    {
                        i.X = 50;
                        i.Y = 50;
                    }
                }
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            int counter = 0;
            try
            {
                foreach (var i in this.figures)
                {
                    if (FiguresListView.SelectedNode.Index == counter)
                    {
                        i.IsMoveble = !i.IsMoveble;
                        this.StopButton.Text = this.ChangeLanguageStopButton(i.IsMoveble);
                        FiguresListView.SelectedNode.Text = i.GetType().ToString().Substring(15) + ' ' + i.IsMoveble;
                    }
                    counter++;
                }
            }
            catch (NullReferenceException) 
            { }
        }

        private void FiguresListView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int counter = 0;
            foreach (var i in this.figures)
            {
                if (i.IsSelected)
                {
                    i.Select();
                    try
                    {
                        BeepCountTextBox.Text = i.Beep.GetInvocationList().GetLength(0).ToString();
                    }
                    catch (NullReferenceException ex)
                    {
                        BeepCountTextBox.Text = "0";
                    }
                }
                if (FiguresListView.SelectedNode.Index == counter)
                {
                    this.StopButton.Text = this.ChangeLanguageStopButton(i.IsMoveble);
                    i.Select();
                }
                counter++;
            }
        }

        private string ChangeLanguageStopButton(bool isMove)
        {
            string result = string.Empty;
            if (isMove && Settings.Default.Language == "ru")
            {
                result = "Стоп";
            }
            if (!isMove && Settings.Default.Language == "ru")
            {
                result = "Старт";
            }
            if (isMove && Settings.Default.Language == "en")
            {
                result = "Stop";
            }
            if (!isMove && Settings.Default.Language == "en")
            {
                result = "Start";
            }
            return result;
        }

        private void EnButton_Click(object sender, EventArgs e)
        {
            Settings.Default.Language = "en";
            Settings.Default.Save();
            Application.Restart();
        }

        private void RuButton_Click(object sender, EventArgs e)
        {
            Settings.Default.Language = "ru";
            Settings.Default.Save();
            Application.Restart();
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.serializer.XmlSerializarion(this.figures);
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var i in this.serializer.XmlDeserialization())
            {
                this.AddFigure(i);
            }
        }

        private void binToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.serializer.BinarySerialization(this.figures);
        }

        private void binToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var i in this.serializer.BinaryDeserialization())
            {
                this.AddFigure(i);
            }
        }

        private void jsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.serializer.JsonSerializarion(this.figures);
        }

        private void jsonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var i in this.serializer.JsonDeserialization())
            {
                this.AddFigure(i);
            }
        }

        private void AddFigure(Figure figure)
        {
            this.figures.Add(figure);
            FiguresListView.Nodes.Add(
                FiguresListView.Nodes.Count.ToString(),
                figure.GetType().ToString().Substring(15) + ' ' + figure.IsMoveble);
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (var i in this.figures)
            {
                if (FiguresListView.SelectedNode.Index == counter)
                {
                    i.AddBeep();
                    BeepCountTextBox.Text = i.Beep.GetInvocationList().GetLength(0).ToString();
                    break;
                }
                counter++;
            }
            
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (var i in this.figures)
            {
                if (FiguresListView.SelectedNode.Index == counter)
                {
                    i.RemoveBeep();
                    try
                    {
                        BeepCountTextBox.Text = i.Beep.GetInvocationList().GetLength(0).ToString();
                    }
                    catch (NullReferenceException ex)
                    {
                        BeepCountTextBox.Text = "0";
                    }
                    break;
                }
                counter++;
            }
        }

    }
}
