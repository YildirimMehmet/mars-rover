namespace Mars.Rover
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEntry = new System.Windows.Forms.Label();
            this.txtUpperRight = new System.Windows.Forms.TextBox();
            this.txtLowerLeft = new System.Windows.Forms.TextBox();
            this.lblUpperRight = new System.Windows.Forms.Label();
            this.lblLowerLeft = new System.Windows.Forms.Label();
            this.btnPlateauNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mars.Rover.Properties.Resources.plateau;
            this.pictureBox1.Location = new System.Drawing.Point(100, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEntry.Location = new System.Drawing.Point(93, 51);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(407, 39);
            this.lblEntry.TabIndex = 1;
            this.lblEntry.Text = "Entry Grid Size of Plateau";
            // 
            // txtUpperRight
            // 
            this.txtUpperRight.Location = new System.Drawing.Point(384, 405);
            this.txtUpperRight.Name = "txtUpperRight";
            this.txtUpperRight.Size = new System.Drawing.Size(100, 20);
            this.txtUpperRight.TabIndex = 2;
            // 
            // txtLowerLeft
            // 
            this.txtLowerLeft.Location = new System.Drawing.Point(100, 405);
            this.txtLowerLeft.Name = "txtLowerLeft";
            this.txtLowerLeft.Size = new System.Drawing.Size(100, 20);
            this.txtLowerLeft.TabIndex = 3;
            // 
            // lblUpperRight
            // 
            this.lblUpperRight.AutoSize = true;
            this.lblUpperRight.Location = new System.Drawing.Point(366, 386);
            this.lblUpperRight.Name = "lblUpperRight";
            this.lblUpperRight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUpperRight.Size = new System.Drawing.Size(118, 13);
            this.lblUpperRight.TabIndex = 4;
            this.lblUpperRight.Text = "Upper Right Coordinate";
            this.lblUpperRight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLowerLeft
            // 
            this.lblLowerLeft.AutoSize = true;
            this.lblLowerLeft.Location = new System.Drawing.Point(97, 386);
            this.lblLowerLeft.Name = "lblLowerLeft";
            this.lblLowerLeft.Size = new System.Drawing.Size(111, 13);
            this.lblLowerLeft.TabIndex = 5;
            this.lblLowerLeft.Text = "Lower Left Coordinate";
            // 
            // btnPlateauNext
            // 
            this.btnPlateauNext.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPlateauNext.Location = new System.Drawing.Point(242, 436);
            this.btnPlateauNext.Name = "btnPlateauNext";
            this.btnPlateauNext.Size = new System.Drawing.Size(95, 38);
            this.btnPlateauNext.TabIndex = 6;
            this.btnPlateauNext.Text = "Next Step »";
            this.btnPlateauNext.UseVisualStyleBackColor = true;
            this.btnPlateauNext.Click += new System.EventHandler(this.btnPlateauNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnPlateauNext);
            this.Controls.Add(this.lblLowerLeft);
            this.Controls.Add(this.lblUpperRight);
            this.Controls.Add(this.txtLowerLeft);
            this.Controls.Add(this.txtUpperRight);
            this.Controls.Add(this.lblEntry);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.TextBox txtUpperRight;
        private System.Windows.Forms.TextBox txtLowerLeft;
        private System.Windows.Forms.Label lblUpperRight;
        private System.Windows.Forms.Label lblLowerLeft;
        private System.Windows.Forms.Button btnPlateauNext;
    }
}

