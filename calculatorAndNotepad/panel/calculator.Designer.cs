namespace calculatorAndNotepad.panel
{
    partial class calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator));
            this.btnCalToNote = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalToNote)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalToNote
            // 
            this.btnCalToNote.Image = ((System.Drawing.Image)(resources.GetObject("btnCalToNote.Image")));
            this.btnCalToNote.Location = new System.Drawing.Point(35, 35);
            this.btnCalToNote.Name = "btnCalToNote";
            this.btnCalToNote.Size = new System.Drawing.Size(60, 70);
            this.btnCalToNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCalToNote.TabIndex = 0;
            this.btnCalToNote.TabStop = false;
            this.btnCalToNote.Click += new System.EventHandler(this.CalToNote_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCalToNote);
            this.Name = "calculator";
            this.Size = new System.Drawing.Size(550, 705);
            ((System.ComponentModel.ISupportInitialize)(this.btnCalToNote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCalToNote;
    }
}
