
namespace BGSnippet
{
    partial class ReferencePointSelector
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
            this.SuspendLayout();
            // 
            // ReferencePointSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(50, 20);
            this.MinimumSize = new System.Drawing.Size(50, 20);
            this.Name = "ReferencePointSelector";
            this.Size = new System.Drawing.Size(50, 20);
            this.Click += new System.EventHandler(this.ReferencePointSelector_Click);
            this.MouseLeave += new System.EventHandler(this.ReferencePointSelector_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReferencePointSelector_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
