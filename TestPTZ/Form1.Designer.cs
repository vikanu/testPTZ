namespace TestPTZ
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.MnuStripAddCamera = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlView = new System.Windows.Forms.Panel();
            this.pnlMenuFloating = new System.Windows.Forms.Panel();
            this.btnUpPanel = new System.Windows.Forms.Button();
            this.btnDownPanel = new System.Windows.Forms.Button();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvCameraList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnDownRight = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnUpRight = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDownLeft = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUpLeft = new System.Windows.Forms.Button();
            this.tmrUp = new System.Windows.Forms.Timer(this.components);
            this.tmrDown = new System.Windows.Forms.Timer(this.components);
            this.MnuStripAddCamera.SuspendLayout();
            this.pnlView.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuStripAddCamera
            // 
            this.MnuStripAddCamera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.MnuStripAddCamera.Name = "MnuStripAddCamera";
            this.MnuStripAddCamera.Size = new System.Drawing.Size(134, 92);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.addToolStripMenuItem.Tag = "0";
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.MenuStrip);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteToolStripMenuItem.Tag = "1";
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.MenuStrip);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem.Tag = "2";
            this.connectToolStripMenuItem.Text = "&Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.MenuStrip);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Tag = "3";
            this.disconnectToolStripMenuItem.Text = "&Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.MenuStrip);
            // 
            // pnlView
            // 
            this.pnlView.Controls.Add(this.pnlMenuFloating);
            this.pnlView.Controls.Add(this.btnUpPanel);
            this.pnlView.Controls.Add(this.btnDownPanel);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlView.Location = new System.Drawing.Point(0, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1094, 536);
            this.pnlView.TabIndex = 17;
            // 
            // pnlMenuFloating
            // 
            this.pnlMenuFloating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuFloating.Location = new System.Drawing.Point(0, 23);
            this.pnlMenuFloating.Name = "pnlMenuFloating";
            this.pnlMenuFloating.Size = new System.Drawing.Size(1094, 490);
            this.pnlMenuFloating.TabIndex = 4;
            // 
            // btnUpPanel
            // 
            this.btnUpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpPanel.Location = new System.Drawing.Point(0, 0);
            this.btnUpPanel.Name = "btnUpPanel";
            this.btnUpPanel.Size = new System.Drawing.Size(1094, 23);
            this.btnUpPanel.TabIndex = 3;
            this.btnUpPanel.Text = "^";
            this.btnUpPanel.UseVisualStyleBackColor = true;
            this.btnUpPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUpPanel_MouseDown);
            this.btnUpPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUpPanel_MouseUp);
            // 
            // btnDownPanel
            // 
            this.btnDownPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDownPanel.Location = new System.Drawing.Point(0, 513);
            this.btnDownPanel.Name = "btnDownPanel";
            this.btnDownPanel.Size = new System.Drawing.Size(1094, 23);
            this.btnDownPanel.TabIndex = 2;
            this.btnDownPanel.Text = "v";
            this.btnDownPanel.UseVisualStyleBackColor = true;
            this.btnDownPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDownPanel_MouseDown);
            this.btnDownPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDownPanel_MouseUp);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.groupBox3);
            this.pnlControl.Controls.Add(this.groupBox2);
            this.pnlControl.Controls.Add(this.groupBox1);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(0, 536);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1094, 157);
            this.pnlControl.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(627, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 143);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log Data";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 108);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvCameraList);
            this.groupBox2.Location = new System.Drawing.Point(443, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 142);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Camera";
            // 
            // lvCameraList
            // 
            this.lvCameraList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvCameraList.ContextMenuStrip = this.MnuStripAddCamera;
            this.lvCameraList.FullRowSelect = true;
            this.lvCameraList.GridLines = true;
            this.lvCameraList.Location = new System.Drawing.Point(6, 19);
            this.lvCameraList.Name = "lvCameraList";
            this.lvCameraList.Size = new System.Drawing.Size(164, 117);
            this.lvCameraList.TabIndex = 0;
            this.lvCameraList.UseCompatibleStateImageBehavior = false;
            this.lvCameraList.View = System.Windows.Forms.View.Details;
            this.lvCameraList.DoubleClick += new System.EventHandler(this.lvCameraList_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Camera Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDown);
            this.groupBox1.Controls.Add(this.btnDownRight);
            this.groupBox1.Controls.Add(this.btnRight);
            this.groupBox1.Controls.Add(this.btnUpRight);
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Controls.Add(this.btnDownLeft);
            this.groupBox1.Controls.Add(this.btnLeft);
            this.groupBox1.Controls.Add(this.btnUpLeft);
            this.groupBox1.Location = new System.Drawing.Point(164, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 143);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Camera";
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(97, 104);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 16;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.btnDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // btnDownRight
            // 
            this.btnDownRight.Location = new System.Drawing.Point(184, 105);
            this.btnDownRight.Name = "btnDownRight";
            this.btnDownRight.Size = new System.Drawing.Size(75, 23);
            this.btnDownRight.TabIndex = 15;
            this.btnDownRight.Text = "Down Right";
            this.btnDownRight.UseVisualStyleBackColor = true;
            this.btnDownRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.btnDownRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(184, 60);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 14;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // btnUpRight
            // 
            this.btnUpRight.Location = new System.Drawing.Point(184, 18);
            this.btnUpRight.Name = "btnUpRight";
            this.btnUpRight.Size = new System.Drawing.Size(75, 23);
            this.btnUpRight.TabIndex = 13;
            this.btnUpRight.Text = "Up Right";
            this.btnUpRight.UseVisualStyleBackColor = true;
            this.btnUpRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.btnUpRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(97, 19);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 12;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.btnUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // btnDownLeft
            // 
            this.btnDownLeft.Location = new System.Drawing.Point(5, 105);
            this.btnDownLeft.Name = "btnDownLeft";
            this.btnDownLeft.Size = new System.Drawing.Size(75, 23);
            this.btnDownLeft.TabIndex = 11;
            this.btnDownLeft.Text = "Down Left";
            this.btnDownLeft.UseVisualStyleBackColor = true;
            this.btnDownLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.btnDownLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(5, 60);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 10;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // btnUpLeft
            // 
            this.btnUpLeft.Location = new System.Drawing.Point(5, 20);
            this.btnUpLeft.Name = "btnUpLeft";
            this.btnUpLeft.Size = new System.Drawing.Size(75, 23);
            this.btnUpLeft.TabIndex = 9;
            this.btnUpLeft.Text = "Up Left";
            this.btnUpLeft.UseVisualStyleBackColor = true;
            this.btnUpLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.btnUpLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // tmrUp
            // 
            this.tmrUp.Interval = 5;
            this.tmrUp.Tick += new System.EventHandler(this.tmrUp_Tick);
            // 
            // tmrDown
            // 
            this.tmrDown.Interval = 1;
            this.tmrDown.Tick += new System.EventHandler(this.tmrDown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 693);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MnuStripAddCamera.ResumeLayout(false);
            this.pnlView.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip MnuStripAddCamera;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Panel pnlMenuFloating;
        private System.Windows.Forms.Button btnUpPanel;
        private System.Windows.Forms.Button btnDownPanel;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvCameraList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnDownRight;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUpRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDownLeft;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUpLeft;
        private System.Windows.Forms.Timer tmrUp;
        private System.Windows.Forms.Timer tmrDown;
    }
}

