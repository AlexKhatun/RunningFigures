namespace RunningFigures
{
    using System.ComponentModel;
    using System.Windows.Forms;

    /// <summary>
    /// Main Form Designer
    /// </summary>
    public partial class MainForm
    {
        private TreeView figuresListView;
        private Button squareButton;
        private Button triangleButton;
        private Button circleButton;
        private Button stopButton;
        private Button enButton;
        private Button ruButton;
        private PictureBox drawingArea;
        private Timer timerRefresher;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem serializeToolStripMenuItem;
        private ToolStripMenuItem binToolStripMenuItem;
        private ToolStripMenuItem xmlToolStripMenuItem;
        private ToolStripMenuItem jsonToolStripMenuItem;
        private ToolStripMenuItem deserializeToolStripMenuItem;
        private ToolStripMenuItem binToolStripMenuItem1;
        private ToolStripMenuItem xmlToolStripMenuItem1;
        private ToolStripMenuItem jsonToolStripMenuItem1;
        private Button plusButton;
        private Button minusButton;
        private TextBox beepCountTextBox;

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
            this.figuresListView = new System.Windows.Forms.TreeView();
            this.squareButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.enButton = new System.Windows.Forms.Button();
            this.ruButton = new System.Windows.Forms.Button();
            this.drawingArea = new System.Windows.Forms.PictureBox();
            this.timerRefresher = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.beepCountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // figuresListView
            // 
            this.figuresListView.Location = new System.Drawing.Point(12, 71);
            this.figuresListView.Name = "figuresListView";
            this.figuresListView.Size = new System.Drawing.Size(123, 224);
            this.figuresListView.TabIndex = 0;
            this.figuresListView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FiguresListView_AfterSelect);
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(12, 32);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(88, 23);
            this.squareButton.TabIndex = 1;
            this.squareButton.Text = "Квадрат";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Location = new System.Drawing.Point(106, 32);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(91, 23);
            this.triangleButton.TabIndex = 2;
            this.triangleButton.Text = "Треугольник";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.TriangleButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(203, 32);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(91, 23);
            this.circleButton.TabIndex = 3;
            this.circleButton.Text = "Круг";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(300, 32);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(91, 23);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // enButton
            // 
            this.enButton.Location = new System.Drawing.Point(598, 32);
            this.enButton.Name = "enButton";
            this.enButton.Size = new System.Drawing.Size(30, 23);
            this.enButton.TabIndex = 5;
            this.enButton.Text = "En";
            this.enButton.UseVisualStyleBackColor = true;
            this.enButton.Click += new System.EventHandler(this.EnButton_Click);
            // 
            // ruButton
            // 
            this.ruButton.Location = new System.Drawing.Point(634, 32);
            this.ruButton.Name = "ruButton";
            this.ruButton.Size = new System.Drawing.Size(30, 23);
            this.ruButton.TabIndex = 6;
            this.ruButton.Text = "Ру";
            this.ruButton.UseVisualStyleBackColor = true;
            this.ruButton.Click += new System.EventHandler(this.RuButton_Click);
            // 
            // drawingArea
            // 
            this.drawingArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingArea.Location = new System.Drawing.Point(157, 71);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(507, 224);
            this.drawingArea.TabIndex = 0;
            this.drawingArea.TabStop = false;
            this.drawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingArea_Paint);
            // 
            // timerRefresher
            // 
            this.timerRefresher.Tick += new System.EventHandler(this.TimerRefresher_Tick);
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
            this.xmlToolStripMenuItem,
            this.jsonToolStripMenuItem});
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.serializeToolStripMenuItem.Text = "Сериализовать";
            // 
            // binToolStripMenuItem
            // 
            this.binToolStripMenuItem.Name = "binToolStripMenuItem";
            this.binToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.binToolStripMenuItem.Text = "Bin";
            this.binToolStripMenuItem.Click += new System.EventHandler(this.BinToolStripMenuItem_Click);
            // 
            // xmlToolStripMenuItem
            // 
            this.xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
            this.xmlToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xmlToolStripMenuItem.Text = "XML";
            this.xmlToolStripMenuItem.Click += new System.EventHandler(this.XmlToolStripMenuItem_Click);
            // 
            // jsonToolStripMenuItem
            // 
            this.jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            this.jsonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.jsonToolStripMenuItem.Text = "Json";
            this.jsonToolStripMenuItem.Click += new System.EventHandler(this.JsonToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binToolStripMenuItem1,
            this.xmlToolStripMenuItem1,
            this.jsonToolStripMenuItem1});
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.deserializeToolStripMenuItem.Text = "Десериализовать";
            // 
            // binToolStripMenuItem1
            // 
            this.binToolStripMenuItem1.Name = "binToolStripMenuItem1";
            this.binToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.binToolStripMenuItem1.Text = "Bin";
            this.binToolStripMenuItem1.Click += new System.EventHandler(this.BinDesToolStripMenuItem1_Click);
            // 
            // xmlToolStripMenuItem1
            // 
            this.xmlToolStripMenuItem1.Name = "xmlToolStripMenuItem1";
            this.xmlToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.xmlToolStripMenuItem1.Text = "XML";
            this.xmlToolStripMenuItem1.Click += new System.EventHandler(this.XmlDesToolStripMenuItem1_Click);
            // 
            // jsonToolStripMenuItem1
            // 
            this.jsonToolStripMenuItem1.Name = "jsonToolStripMenuItem1";
            this.jsonToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.jsonToolStripMenuItem1.Text = "Json";
            this.jsonToolStripMenuItem1.Click += new System.EventHandler(this.JsonDesToolStripMenuItem1_Click);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(465, 32);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(19, 20);
            this.plusButton.TabIndex = 8;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(512, 32);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(20, 20);
            this.minusButton.TabIndex = 9;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // beepCountTextBox
            // 
            this.beepCountTextBox.Location = new System.Drawing.Point(490, 32);
            this.beepCountTextBox.Name = "beepCountTextBox";
            this.beepCountTextBox.Size = new System.Drawing.Size(16, 20);
            this.beepCountTextBox.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 307);
            this.Controls.Add(this.beepCountTextBox);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.drawingArea);
            this.Controls.Add(this.ruButton);
            this.Controls.Add(this.enButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.figuresListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Бегающие фигуры";
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}