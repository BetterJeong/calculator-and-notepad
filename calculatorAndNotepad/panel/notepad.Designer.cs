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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notepad));
            this.NoteToCal = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblCalc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NoteToCal)).BeginInit();
            this.SuspendLayout();
            // 
            // NoteToCal
            // 
            this.NoteToCal.Image = ((System.Drawing.Image)(resources.GetObject("NoteToCal.Image")));
            this.NoteToCal.Location = new System.Drawing.Point(470, 20);
            this.NoteToCal.Name = "NoteToCal";
            this.NoteToCal.Size = new System.Drawing.Size(60, 70);
            this.NoteToCal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NoteToCal.TabIndex = 2;
            this.NoteToCal.TabStop = false;
            this.NoteToCal.Click += new System.EventHandler(this.NoteToCal_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 190);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(470, 332);
            this.textBox1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("D2Coding", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(208, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "저장";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblCalc
            // 
            this.lblCalc.AutoSize = true;
            this.lblCalc.Font = new System.Drawing.Font("D2Coding", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCalc.Location = new System.Drawing.Point(183, 90);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(183, 62);
            this.lblCalc.TabIndex = 7;
            this.lblCalc.Text = "메모장";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("D2Coding", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(203, 665);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "BETTERJEONG";
            // 
            // notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCalc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NoteToCal);
            this.Name = "notepad";
            this.Size = new System.Drawing.Size(550, 705);
            ((System.ComponentModel.ISupportInitialize)(this.NoteToCal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NoteToCal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCalc;
        private System.Windows.Forms.Label label4;
    }
}
