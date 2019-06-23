namespace Mars.Rover
{
    partial class RoverForm
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
            this.btnRoverNext = new System.Windows.Forms.Button();
            this.lblXCord = new System.Windows.Forms.Label();
            this.lblYCoord = new System.Windows.Forms.Label();
            this.txtXCoord = new System.Windows.Forms.TextBox();
            this.txtYCoord = new System.Windows.Forms.TextBox();
            this.lblDirection = new System.Windows.Forms.Label();
            this.cBoxDirection = new System.Windows.Forms.ComboBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.txtCommands = new System.Windows.Forms.TextBox();
            this.listRovers = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mars.Rover.Properties.Resources.rover;
            this.pictureBox1.Location = new System.Drawing.Point(124, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRoverNext
            // 
            this.btnRoverNext.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRoverNext.Location = new System.Drawing.Point(247, 411);
            this.btnRoverNext.Name = "btnRoverNext";
            this.btnRoverNext.Size = new System.Drawing.Size(95, 38);
            this.btnRoverNext.TabIndex = 11;
            this.btnRoverNext.Text = "Send Rover »";
            this.btnRoverNext.UseVisualStyleBackColor = true;
            this.btnRoverNext.Click += new System.EventHandler(this.btnRoverNext_Click);
            // 
            // lblXCord
            // 
            this.lblXCord.AutoSize = true;
            this.lblXCord.Location = new System.Drawing.Point(121, 314);
            this.lblXCord.Name = "lblXCord";
            this.lblXCord.Size = new System.Drawing.Size(68, 13);
            this.lblXCord.TabIndex = 10;
            this.lblXCord.Text = "X Coordinate";
            // 
            // lblYCoord
            // 
            this.lblYCoord.AutoSize = true;
            this.lblYCoord.Location = new System.Drawing.Point(266, 314);
            this.lblYCoord.Name = "lblYCoord";
            this.lblYCoord.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblYCoord.Size = new System.Drawing.Size(68, 13);
            this.lblYCoord.TabIndex = 9;
            this.lblYCoord.Text = "Y Coordinate";
            this.lblYCoord.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtXCoord
            // 
            this.txtXCoord.Location = new System.Drawing.Point(124, 333);
            this.txtXCoord.Name = "txtXCoord";
            this.txtXCoord.Size = new System.Drawing.Size(100, 20);
            this.txtXCoord.TabIndex = 8;
            // 
            // txtYCoord
            // 
            this.txtYCoord.Location = new System.Drawing.Point(247, 333);
            this.txtYCoord.Name = "txtYCoord";
            this.txtYCoord.Size = new System.Drawing.Size(100, 20);
            this.txtYCoord.TabIndex = 7;
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(420, 314);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDirection.Size = new System.Drawing.Size(49, 13);
            this.lblDirection.TabIndex = 13;
            this.lblDirection.Text = "Direction";
            this.lblDirection.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cBoxDirection
            // 
            this.cBoxDirection.FormattingEnabled = true;
            this.cBoxDirection.Location = new System.Drawing.Point(379, 332);
            this.cBoxDirection.Name = "cBoxDirection";
            this.cBoxDirection.Size = new System.Drawing.Size(87, 21);
            this.cBoxDirection.TabIndex = 14;
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(121, 362);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(59, 13);
            this.lblCommand.TabIndex = 16;
            this.lblCommand.Text = "Commands";
            // 
            // txtCommands
            // 
            this.txtCommands.Location = new System.Drawing.Point(124, 381);
            this.txtCommands.Name = "txtCommands";
            this.txtCommands.Size = new System.Drawing.Size(342, 20);
            this.txtCommands.TabIndex = 15;
            // 
            // listRovers
            // 
            this.listRovers.FormattingEnabled = true;
            this.listRovers.Location = new System.Drawing.Point(124, 463);
            this.listRovers.Name = "listRovers";
            this.listRovers.Size = new System.Drawing.Size(342, 69);
            this.listRovers.TabIndex = 17;
            // 
            // RoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.listRovers);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.txtCommands);
            this.Controls.Add(this.cBoxDirection);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.btnRoverNext);
            this.Controls.Add(this.lblXCord);
            this.Controls.Add(this.lblYCoord);
            this.Controls.Add(this.txtXCoord);
            this.Controls.Add(this.txtYCoord);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "RoverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rover";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RoverForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRoverNext;
        private System.Windows.Forms.Label lblXCord;
        private System.Windows.Forms.Label lblYCoord;
        private System.Windows.Forms.TextBox txtXCoord;
        private System.Windows.Forms.TextBox txtYCoord;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.ComboBox cBoxDirection;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.TextBox txtCommands;
        private System.Windows.Forms.ListBox listRovers;
    }
}