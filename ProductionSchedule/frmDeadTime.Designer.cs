namespace ProductionSchedule
{
    partial class frmDeadTime
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
            this.tbDeadNotes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDeadTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblJobId = new System.Windows.Forms.Label();
            this.btnSaveDeadTime = new System.Windows.Forms.Button();
            this.lblJobIdVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDeadNotes
            // 
            this.tbDeadNotes.Location = new System.Drawing.Point(111, 86);
            this.tbDeadNotes.Multiline = true;
            this.tbDeadNotes.Name = "tbDeadNotes";
            this.tbDeadNotes.Size = new System.Drawing.Size(161, 86);
            this.tbDeadNotes.TabIndex = 128;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 127;
            this.label10.Text = "Dead Time Notes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 126;
            this.label9.Text = "Dead Time (hours):";
            // 
            // tbDeadTime
            // 
            this.tbDeadTime.Location = new System.Drawing.Point(111, 62);
            this.tbDeadTime.Name = "tbDeadTime";
            this.tbDeadTime.Size = new System.Drawing.Size(161, 20);
            this.tbDeadTime.TabIndex = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 129;
            this.label1.Text = "Job Id:";
            // 
            // lblJobId
            // 
            this.lblJobId.AutoSize = true;
            this.lblJobId.Location = new System.Drawing.Point(108, 24);
            this.lblJobId.Name = "lblJobId";
            this.lblJobId.Size = new System.Drawing.Size(0, 13);
            this.lblJobId.TabIndex = 130;
            // 
            // btnSaveDeadTime
            // 
            this.btnSaveDeadTime.Location = new System.Drawing.Point(90, 194);
            this.btnSaveDeadTime.Name = "btnSaveDeadTime";
            this.btnSaveDeadTime.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDeadTime.TabIndex = 131;
            this.btnSaveDeadTime.Text = "Save";
            this.btnSaveDeadTime.UseVisualStyleBackColor = true;
            this.btnSaveDeadTime.Click += new System.EventHandler(this.btnSaveDeadTime_Click);
            // 
            // lblJobIdVal
            // 
            this.lblJobIdVal.AutoSize = true;
            this.lblJobIdVal.Location = new System.Drawing.Point(108, 24);
            this.lblJobIdVal.Name = "lblJobIdVal";
            this.lblJobIdVal.Size = new System.Drawing.Size(0, 13);
            this.lblJobIdVal.TabIndex = 132;
            // 
            // frmDeadTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblJobIdVal);
            this.Controls.Add(this.btnSaveDeadTime);
            this.Controls.Add(this.lblJobId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDeadNotes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbDeadTime);
            this.Name = "frmDeadTime";
            this.Text = "frmDeadTime";
            this.Load += new System.EventHandler(this.frmDeadTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDeadNotes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDeadTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJobId;
        private System.Windows.Forms.Button btnSaveDeadTime;
        private System.Windows.Forms.Label lblJobIdVal;
    }
}