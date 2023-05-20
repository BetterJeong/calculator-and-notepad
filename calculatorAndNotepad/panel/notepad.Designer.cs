namespace calculatorAndNotepad.panel
{
    partial class notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notepad));
            this.NoteToCal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NoteToCal)).BeginInit();
            this.SuspendLayout();
            // 
            // NoteToCal
            // 
            this.NoteToCal.Image = ((System.Drawing.Image)(resources.GetObject("NoteToCal.Image")));
            this.NoteToCal.Location = new System.Drawing.Point(35, 35);
            this.NoteToCal.Name = "NoteToCal";
            this.NoteToCal.Size = new System.Drawing.Size(60, 70);
            this.NoteToCal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NoteToCal.TabIndex = 2;
            this.NoteToCal.TabStop = false;
            this.NoteToCal.Click += new System.EventHandler(this.NoteToCal_Click);
            // 
            // notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NoteToCal);
            this.Name = "notepad";
            this.Size = new System.Drawing.Size(550, 705);
            ((System.ComponentModel.ISupportInitialize)(this.NoteToCal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox NoteToCal;
    }
}
