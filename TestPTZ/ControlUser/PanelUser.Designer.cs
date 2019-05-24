namespace TestPTZ.ControlUser
{
    partial class PanelUser
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
            this.pnlSlide = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlSlide
            // 
            this.pnlSlide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSlide.Location = new System.Drawing.Point(0, 0);
            this.pnlSlide.Name = "pnlSlide";
            this.pnlSlide.Size = new System.Drawing.Size(527, 461);
            this.pnlSlide.TabIndex = 0;
            // 
            // PanelUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSlide);
            this.Name = "PanelUser";
            this.Size = new System.Drawing.Size(527, 461);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSlide;
    }
}
