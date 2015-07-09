namespace RunningFigures
{
    using System.ComponentModel;
    using System.Windows.Forms;
    partial class MainForm
    {
        private TreeView FiguresListView;
        private Button SquareButton;
        private Button TriangleButton;
        private Button CircleButton;
        private Button StopButton;
        private Button EnButton;
        private Button RuButton;
        private PictureBox DrawingArea;
        private Timer timerRefresher;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem serializeToolStripMenuItem;
        private ToolStripMenuItem binToolStripMenuItem;
        private ToolStripMenuItem xMLToolStripMenuItem;
        private ToolStripMenuItem jsonToolStripMenuItem;
        private ToolStripMenuItem deserializeToolStripMenuItem;
        private ToolStripMenuItem binToolStripMenuItem1;
        private ToolStripMenuItem xMLToolStripMenuItem1;
        private ToolStripMenuItem jsonToolStripMenuItem1;
        private Button PlusButton;
        private Button MinusButton;
        private TextBox BeepCountTextBox;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FiguresListView = new System.Windows.Forms.TreeView();
            this.SquareButton = new System.Windows.Forms.Button();
            this.TriangleButton = new System.Windows.Forms.Button();
            this.CircleButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.EnButton = new System.Windows.Forms.Button();
            this.RuButton = new System.Windows.Forms.Button();
            this.DrawingArea = new System.Windows.Forms.PictureBox();
            this.timerRefresher = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.BeepCountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiguresListView
            // 
            this.FiguresListView.Location = new System.Drawing.Point(12, 71);
            this.FiguresListView.Name = "FiguresListView";
            this.FiguresListView.Size = new System.Drawing.Size(123, 224);
            this.FiguresListView.TabIndex = 0;
            this.FiguresListView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FiguresListView_AfterSelect);
            // 
            // SquareButton
            // 
            this.SquareButton.Location = new System.Drawing.Point(12, 32);
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.Size = new System.Drawing.Size(88, 23);
            this.SquareButton.TabIndex = 1;
            this.SquareButton.Text = "Квадрат";
            this.SquareButton.UseVisualStyleBackColor = true;
            this.SquareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // TriangleButton
            // 
            this.TriangleButton.Location = new System.Drawing.Point(106, 32);
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.Size = new System.Drawing.Size(91, 23);
            this.TriangleButton.TabIndex = 2;
            this.TriangleButton.Text = "Треугольник";
            this.TriangleButton.UseVisualStyleBackColor = true;
            this.TriangleButton.Click += new System.EventHandler(this.TriangleButton_Click);
            // 
            // CircleButton
            // 
            this.CircleButton.Location = new System.Drawing.Point(203, 32);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(91, 23);
            this.CircleButton.TabIndex = 3;
            this.CircleButton.Text = "Круг";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(300, 32);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(91, 23);
            this.StopButton.TabIndex = 4;
            this.StopButton.Text = "Стоп";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // EnButton
            // 
            this.EnButton.Location = new System.Drawing.Point(598, 32);
            this.EnButton.Name = "EnButton";
            this.EnButton.Size = new System.Drawing.Size(30, 23);
            this.EnButton.TabIndex = 5;
            this.EnButton.Text = "En";
            this.EnButton.UseVisualStyleBackColor = true;
            this.EnButton.Click += new System.EventHandler(this.EnButton_Click);
            // 
            // RuButton
            // 
            this.RuButton.Location = new System.Drawing.Point(634, 32);
            this.RuButton.Name = "RuButton";
            this.RuButton.Size = new System.Drawing.Size(30, 23);
            this.RuButton.TabIndex = 6;
            this.RuButton.Text = "Ру";
            this.RuButton.UseVisualStyleBackColor = true;
            this.RuButton.Click += new System.EventHandler(this.RuButton_Click);
            // 
            // DrawingArea
            // 
            this.DrawingArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawingArea.Location = new System.Drawing.Point(157, 71);
            this.DrawingArea.Name = "DrawingArea";
            this.DrawingArea.Size = new System.Drawing.Size(507, 224);
            this.DrawingArea.TabIndex = 0;
            this.DrawingArea.TabStop = false;
            this.DrawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingArea_Paint);
            // 
            // timerRefresher
            // 
            this.timerRefresher.Tick += new System.EventHandler(this.timerRefresher_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.jsonToolStripMenuItem});
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.serializeToolStripMenuItem.Text = "Сериализовать";
            // 
            // binToolStripMenuItem
            // 
            this.binToolStripMenuItem.Name = "binToolStripMenuItem";
            this.binToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.binToolStripMenuItem.Text = "Bin";
            this.binToolStripMenuItem.Click += new System.EventHandler(this.binToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // jsonToolStripMenuItem
            // 
            this.jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            this.jsonToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.jsonToolStripMenuItem.Text = "Json";
            this.jsonToolStripMenuItem.Click += new System.EventHandler(this.jsonToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binToolStripMenuItem1,
            this.xMLToolStripMenuItem1,
            this.jsonToolStripMenuItem1});
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.deserializeToolStripMenuItem.Text = "Десериализовать";
            // 
            // binToolStripMenuItem1
            // 
            this.binToolStripMenuItem1.Name = "binToolStripMenuItem1";
            this.binToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.binToolStripMenuItem1.Text = "Bin";
            this.binToolStripMenuItem1.Click += new System.EventHandler(this.binToolStripMenuItem1_Click);
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.xMLToolStripMenuItem1.Text = "XML";
            this.xMLToolStripMenuItem1.Click += new System.EventHandler(this.xMLToolStripMenuItem1_Click);
            // 
            // jsonToolStripMenuItem1
            // 
            this.jsonToolStripMenuItem1.Name = "jsonToolStripMenuItem1";
            this.jsonToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.jsonToolStripMenuItem1.Text = "Json";
            this.jsonToolStripMenuItem1.Click += new System.EventHandler(this.jsonToolStripMenuItem1_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(465, 32);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(19, 20);
            this.PlusButton.TabIndex = 8;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(512, 32);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(20, 20);
            this.MinusButton.TabIndex = 9;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // BeepCountTextBox
            // 
            this.BeepCountTextBox.Location = new System.Drawing.Point(490, 32);
            this.BeepCountTextBox.Name = "BeepCountTextBox";
            this.BeepCountTextBox.Size = new System.Drawing.Size(16, 20);
            this.BeepCountTextBox.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 307);
            this.Controls.Add(this.BeepCountTextBox);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.DrawingArea);
            this.Controls.Add(this.RuButton);
            this.Controls.Add(this.EnButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.CircleButton);
            this.Controls.Add(this.TriangleButton);
            this.Controls.Add(this.SquareButton);
            this.Controls.Add(this.FiguresListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Бегающие фигуры";
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
    }
}

