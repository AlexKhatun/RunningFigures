﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using RunningFigures.Properties;

namespace RunningFigures
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Settings.Default.Language);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Settings.Default.Language);
            InitializeComponent();
            timerRefresher.Start();
            timerRefresher.Interval = 10;
            figures = new List<Figure>();
            serializer = new Serializer();
        }

        private Serializer serializer;
        private List<Figure> figures;

        private void SquareButton_Click(object sender, EventArgs e)
        {
            Square square = new Square();
            AddFigure(square);
        }

        private void TriangleButton_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle();
            AddFigure(triangle);
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            AddFigure(circle);
        }

        private void timerRefresher_Tick(object sender, EventArgs e)
        {
            DrawingArea.Refresh();
        }

        private void DrawingArea_Paint(object sender, PaintEventArgs e)
        {
            foreach (var i in figures)
            {
                i.Draw(e.Graphics);
                if (i.IsMoveble)
                {
                    i.Move(DrawingArea, figures);
                }
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            int counter = 0;
            try
            {
                foreach (var i in figures)
                {
                    if (FiguresListView.SelectedNode.Index == counter)
                    {
                        i.IsMoveble = !i.IsMoveble;
                        if (i.IsMoveble && Settings.Default.Language == "ru")
                        {
                            StopButton.Text = "Стоп";
                        }
                        if (!i.IsMoveble && Settings.Default.Language == "ru")
                        {
                            StopButton.Text = "Старт";
                        }
                        if (i.IsMoveble && Settings.Default.Language == "en")
                        {
                            StopButton.Text = "Stop";
                        }
                        if (!i.IsMoveble && Settings.Default.Language == "en")
                        {
                            StopButton.Text = "Start";
                        }
                        FiguresListView.SelectedNode.Text = i.GetType().ToString().Substring(15) + ' ' + i.IsMoveble;
                    }
                    counter++;
                }
            }
            catch (NullReferenceException) { }
        }

        private void FiguresListView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int counter = 0;
            foreach (var i in figures)
            {
                if (i.IsSelected)
                {
                    i.Select();
                }
                if (FiguresListView.SelectedNode.Index == counter)
                {
                    if (i.IsMoveble && Settings.Default.Language == "ru")
                    {
                        StopButton.Text = "Стоп";
                    }
                    if (!i.IsMoveble && Settings.Default.Language == "ru")
                    {
                        StopButton.Text = "Старт";
                    }
                    if (i.IsMoveble && Settings.Default.Language == "en")
                    {
                        StopButton.Text = "Stop";
                    }
                    if (!i.IsMoveble && Settings.Default.Language == "en")
                    {
                        StopButton.Text = "Start";
                    }
                    i.Select();
                }
                counter++;
            }
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
            //xmlFormatter.Serialize(new FileStream("figures.xml", FileMode.OpenOrCreate), figures);
            serializer.XmlSerializarion(figures);
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var i in serializer.XmlDeserialization())
            {
                AddFigure(i);
            }
        }

        private void binToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serializer.BinarySerialization(figures);
        }

        private void binToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var i in serializer.BinaryDeserialization())
            {
                AddFigure(i);
            }
        }

        private void jsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serializer.JsonSerializarion(figures);
        }

        private void jsonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var i in serializer.JsonDeserialization())
            {
                AddFigure(i);
            }
        }

        private void AddFigure(Figure figure)
        {
            figures.Add(figure);
            FiguresListView.Nodes.Add((FiguresListView.Nodes.Count).ToString(),
            figure.GetType().ToString().Substring(15) + ' ' + figure.IsMoveble);
        }

    }
}
