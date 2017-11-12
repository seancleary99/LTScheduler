namespace ProductionSchedule
{
    partial class frmContractors
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
            this.dgContractor = new System.Windows.Forms.DataGridView();
            this.SaveContractor = new System.Windows.Forms.Button();
            this.lblCrane = new System.Windows.Forms.Label();
            this.tbContractor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgContractor)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(411, 10);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 21;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dgContractor
            // 
            this.dgContractor.AllowUserToOrderColumns = true;
            this.dgContractor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContractor.Location = new System.Drawing.Point(139, 52);
            this.dgContractor.Name = "dgContractor";
            this.dgContractor.Size = new System.Drawing.Size(325, 198);
            this.dgContractor.TabIndex = 20;
            this.dgContractor.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgContractor_RowHeaderMouseClick);
            // 
            // SaveContractor
            // 
            this.SaveContractor.Location = new System.Drawing.Point(307, 10);
            this.SaveContractor.Name = "SaveContractor";
            this.SaveContractor.Size = new System.Drawing.Size(98, 23);
            this.SaveContractor.TabIndex = 19;
            this.SaveContractor.Text = "Save Contractor";
            this.SaveContractor.UseVisualStyleBackColor = true;
            this.SaveContractor.Click += new System.EventHandler(this.SaveContractor_Click);
            // 
            // lblCrane
            // 
            this.lblCrane.AutoSize = true;
            this.lblCrane.Location = new System.Drawing.Point(126, 10);
            this.lblCrane.Name = "lblCrane";
            this.lblCrane.Size = new System.Drawing.Size(59, 13);
            this.lblCrane.TabIndex = 18;
            this.lblCrane.Text = "Contractor:";
            // 
            // tbContractor
            // 
            this.tbContractor.Location = new System.Drawing.Point(201, 10);
            this.tbContractor.Name = "tbContractor";
            this.tbContractor.Size = new System.Drawing.Size(100, 20);
            this.tbContractor.TabIndex = 17;
            // 
            // frmContractors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 261);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dgContractor);
            this.Controls.Add(this.SaveContractor);
            this.Controls.Add(this.lblCrane);
            this.Controls.Add(this.tbContractor);
            this.Name = "frmContractors";
            this.Text = "frmContractors";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmContractors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgContractor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView dgContractor;
        private System.Windows.Forms.Button SaveContractor;
        private System.Windows.Forms.Label lblCrane;
        private System.Windows.Forms.TextBox tbContractor;
    }
}