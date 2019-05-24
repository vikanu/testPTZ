namespace TestPTZ.ControlUser
{
    partial class PanelMenuCamera
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMenu = new System.Windows.Forms.Label();
            this.pnlViewer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.Color.DarkGray;
            this.lblMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenu.Location = new System.Drawing.Point(0, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(530, 23);
            this.lblMenu.TabIndex = 16;
            this.lblMenu.Text = "Menu Group 1";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlViewer
            // 
            this.pnlViewer.Location = new System.Drawing.Point(3, 26);
            this.pnlViewer.Name = "pnlViewer";
            this.pnlViewer.Size = new System.Drawing.Size(521, 440);
            this.pnlViewer.TabIndex = 17;
            // 
            // PanelMenuCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlViewer);
            this.Controls.Add(this.lblMenu);
            this.Name = "PanelMenuCamera";
            this.Size = new System.Drawing.Size(530, 471);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel pnlViewer;

    }
}
