namespace ProductionSchedule
{
    partial class frmCranes
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
            this.Delete = new System.Windows.Forms.Button();
            this.dgCraneHire = new System.Windows.Forms.DataGridView();
            this.SaveCraneHire = new System.Windows.Forms.Button();
            this.lblCrane = new System.Windows.Forms.Label();
            this.tbCrane = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCraneHire)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(453, 12);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dgCraneHire
            // 
            this.dgCraneHire.AllowUserToOrderColumns = true;
            this.dgCraneHire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCraneHire.Location = new System.Drawing.Point(181, 54);
            this.dgCraneHire.Name = "dgCraneHire";
            this.dgCraneHire.Size = new System.Drawing.Size(325, 198);
            this.dgCraneHire.TabIndex = 15;
            this.dgCraneHire.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCraneHire_RowHeaderMouseClick_1);
            // 
            // SaveCraneHire
            // 
            this.SaveCraneHire.Location = new System.Drawing.Point(349, 12);
            this.SaveCraneHire.Name = "SaveCraneHire";
            this.SaveCraneHire.Size = new System.Drawing.Size(98, 23);
            this.SaveCraneHire.TabIndex = 14;
            this.SaveCraneHire.Text = "Save Crane Hire";
            this.SaveCraneHire.UseVisualStyleBackColor = true;
            this.SaveCraneHire.Click += new System.EventHandler(this.SaveCraneHire_Click);
            // 
            // lblCrane
            // 
            this.lblCrane.AutoSize = true;
            this.lblCrane.Location = new System.Drawing.Point(168, 12);
            this.lblCrane.Name = "lblCrane";
            this.lblCrane.Size = new System.Drawing.Size(38, 13);
            this.lblCrane.TabIndex = 13;
            this.lblCrane.Text = "Crane:";
            // 
            // tbCrane
            // 
            this.tbCrane.Location = new System.Drawing.Point(243, 12);
            this.tbCrane.Name = "tbCrane";
            this.tbCrane.Size = new System.Drawing.Size(100, 20);
            this.tbCrane.TabIndex = 12;
            // 
            // frmCranes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 261);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dgCraneHire);
            this.Controls.Add(this.SaveCraneHire);
            this.Controls.Add(this.lblCrane);
            this.Controls.Add(this.tbCrane);
            this.Name = "frmCranes";
            this.Text = "frmCranes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCranes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCraneHire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView dgCraneHire;
        private System.Windows.Forms.Button SaveCraneHire;
        private System.Windows.Forms.Label lblCrane;
        private System.Windows.Forms.TextBox tbCrane;
    }
}