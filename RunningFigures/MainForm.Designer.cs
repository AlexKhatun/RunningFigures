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
        private PictureBox drawingArea;
        private Button squareButton;
        private Button triangleButton;
        private Button circleButton;
        private Button stopButton;
        private Button enButton;
        private Button ruButton;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            resources.ApplyResources(this.figuresListView, "figuresListView");
            this.figuresListView.Name = "figuresListView";
            this.figuresListView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FiguresListView_AfterSelect);
            // 
            // squareButton
            // 
            resources.ApplyResources(this.squareButton, "squareButton");
            this.squareButton.Name = "squareButton";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // triangleButton
            // 
            resources.ApplyResources(this.triangleButton, "triangleButton");
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.TriangleButton_Click);
            // 
            // circleButton
            // 
            resources.ApplyResources(this.circleButton, "circleButton");
            this.circleButton.Name = "circleButton";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // stopButton
            // 
            resources.ApplyResources(this.stopButton, "stopButton");
            this.stopButton.Name = "stopButton";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // enButton
            // 
            resources.ApplyResources(this.enButton, "enButton");
            this.enButton.Name = "enButton";
            this.enButton.UseVisualStyleBackColor = true;
            this.enButton.Click += new System.EventHandler(this.EnButton_Click);
            // 
            // ruButton
            // 
            resources.ApplyResources(this.ruButton, "ruButton");
            this.ruButton.Name = "ruButton";
            this.ruButton.UseVisualStyleBackColor = true;
            this.ruButton.Click += new System.EventHandler(this.RuButton_Click);
            // 
            // drawingArea
            // 
            resources.ApplyResources(this.drawingArea, "drawingArea");
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.TabStop = false;
            this.drawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingArea_Paint);
            // 
            // timerRefresher
            // 
            this.timerRefresher.Tick += new System.EventHandler(this.TimerRefresher_Tick);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // serializeToolStripMenuItem
            // 
            resources.ApplyResources(this.serializeToolStripMenuItem, "serializeToolStripMenuItem");
            this.serializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binToolStripMenuItem,
            this.xmlToolStripMenuItem,
            this.jsonToolStripMenuItem});
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            // 
            // binToolStripMenuItem
            // 
            resources.ApplyResources(this.binToolStripMenuItem, "binToolStripMenuItem");
            this.binToolStripMenuItem.Name = "binToolStripMenuItem";
            this.binToolStripMenuItem.Click += new System.EventHandler(this.BinToolStripMenuItem_Click);
            // 
            // xmlToolStripMenuItem
            // 
            resources.ApplyResources(this.xmlToolStripMenuItem, "xmlToolStripMenuItem");
            this.xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
            this.xmlToolStripMenuItem.Click += new System.EventHandler(this.XmlToolStripMenuItem_Click);
            // 
            // jsonToolStripMenuItem
            // 
            resources.ApplyResources(this.jsonToolStripMenuItem, "jsonToolStripMenuItem");
            this.jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            this.jsonToolStripMenuItem.Click += new System.EventHandler(this.JsonToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            resources.ApplyResources(this.deserializeToolStripMenuItem, "deserializeToolStripMenuItem");
            this.deserializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binToolStripMenuItem1,
            this.xmlToolStripMenuItem1,
            this.jsonToolStripMenuItem1});
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            // 
            // binToolStripMenuItem1
            // 
            resources.ApplyResources(this.binToolStripMenuItem1, "binToolStripMenuItem1");
            this.binToolStripMenuItem1.Name = "binToolStripMenuItem1";
            this.binToolStripMenuItem1.Click += new System.EventHandler(this.BinDesToolStripMenuItem1_Click);
            // 
            // xmlToolStripMenuItem1
            // 
            resources.ApplyResources(this.xmlToolStripMenuItem1, "xmlToolStripMenuItem1");
            this.xmlToolStripMenuItem1.Name = "xmlToolStripMenuItem1";
            this.xmlToolStripMenuItem1.Click += new System.EventHandler(this.XmlDesToolStripMenuItem1_Click);
            // 
            // jsonToolStripMenuItem1
            // 
            resources.ApplyResources(this.jsonToolStripMenuItem1, "jsonToolStripMenuItem1");
            this.jsonToolStripMenuItem1.Name = "jsonToolStripMenuItem1";
            this.jsonToolStripMenuItem1.Click += new System.EventHandler(this.JsonDesToolStripMenuItem1_Click);
            // 
            // plusButton
            // 
            resources.ApplyResources(this.plusButton, "plusButton");
            this.plusButton.Name = "plusButton";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // minusButton
            // 
            resources.ApplyResources(this.minusButton, "minusButton");
            this.minusButton.Name = "minusButton";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // beepCountTextBox
            // 
            resources.ApplyResources(this.beepCountTextBox, "beepCountTextBox");
            this.beepCountTextBox.Name = "beepCountTextBox";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}