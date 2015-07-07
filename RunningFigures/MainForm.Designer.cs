using System.ComponentModel;
using System.Windows.Forms;

namespace RunningFigures
{
    partial class MainForm
    {
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiguresListView
            // 
            resources.ApplyResources(this.FiguresListView, "FiguresListView");
            this.FiguresListView.Name = "FiguresListView";
            this.FiguresListView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FiguresListView_AfterSelect);
            // 
            // SquareButton
            // 
            resources.ApplyResources(this.SquareButton, "SquareButton");
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.UseVisualStyleBackColor = true;
            this.SquareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // TriangleButton
            // 
            resources.ApplyResources(this.TriangleButton, "TriangleButton");
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.UseVisualStyleBackColor = true;
            this.TriangleButton.Click += new System.EventHandler(this.TriangleButton_Click);
            // 
            // CircleButton
            // 
            resources.ApplyResources(this.CircleButton, "CircleButton");
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // StopButton
            // 
            resources.ApplyResources(this.StopButton, "StopButton");
            this.StopButton.Name = "StopButton";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // EnButton
            // 
            resources.ApplyResources(this.EnButton, "EnButton");
            this.EnButton.Name = "EnButton";
            this.EnButton.UseVisualStyleBackColor = true;
            this.EnButton.Click += new System.EventHandler(this.EnButton_Click);
            // 
            // RuButton
            // 
            resources.ApplyResources(this.RuButton, "RuButton");
            this.RuButton.Name = "RuButton";
            this.RuButton.UseVisualStyleBackColor = true;
            this.RuButton.Click += new System.EventHandler(this.RuButton_Click);
            // 
            // DrawingArea
            // 
            resources.ApplyResources(this.DrawingArea, "DrawingArea");
            this.DrawingArea.Name = "DrawingArea";
            this.DrawingArea.TabStop = false;
            this.DrawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingArea_Paint);
            // 
            // timerRefresher
            // 
            this.timerRefresher.Tick += new System.EventHandler(this.timerRefresher_Tick);
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
            this.xMLToolStripMenuItem,
            this.jsonToolStripMenuItem});
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            // 
            // binToolStripMenuItem
            // 
            resources.ApplyResources(this.binToolStripMenuItem, "binToolStripMenuItem");
            this.binToolStripMenuItem.Name = "binToolStripMenuItem";
            this.binToolStripMenuItem.Click += new System.EventHandler(this.binToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            resources.ApplyResources(this.xMLToolStripMenuItem, "xMLToolStripMenuItem");
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // jsonToolStripMenuItem
            // 
            resources.ApplyResources(this.jsonToolStripMenuItem, "jsonToolStripMenuItem");
            this.jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            this.jsonToolStripMenuItem.Click += new System.EventHandler(this.jsonToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            resources.ApplyResources(this.deserializeToolStripMenuItem, "deserializeToolStripMenuItem");
            this.deserializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binToolStripMenuItem1,
            this.xMLToolStripMenuItem1,
            this.jsonToolStripMenuItem1});
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            // 
            // binToolStripMenuItem1
            // 
            resources.ApplyResources(this.binToolStripMenuItem1, "binToolStripMenuItem1");
            this.binToolStripMenuItem1.Name = "binToolStripMenuItem1";
            this.binToolStripMenuItem1.Click += new System.EventHandler(this.binToolStripMenuItem1_Click);
            // 
            // xMLToolStripMenuItem1
            // 
            resources.ApplyResources(this.xMLToolStripMenuItem1, "xMLToolStripMenuItem1");
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Click += new System.EventHandler(this.xMLToolStripMenuItem1_Click);
            // 
            // jsonToolStripMenuItem1
            // 
            resources.ApplyResources(this.jsonToolStripMenuItem1, "jsonToolStripMenuItem1");
            this.jsonToolStripMenuItem1.Name = "jsonToolStripMenuItem1";
            this.jsonToolStripMenuItem1.Click += new System.EventHandler(this.jsonToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}

