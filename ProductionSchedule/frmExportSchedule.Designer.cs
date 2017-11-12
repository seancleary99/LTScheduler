namespace ProductionSchedule
{
    partial class frmExportSchedule
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
            this.dtExportSchedStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProdDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtExportSchedStartDate
            // 
            this.dtExportSchedStartDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtExportSchedStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtExportSchedStartDate.Location = new System.Drawing.Point(147, 60);
            this.dtExportSchedStartDate.Name = "dtExportSchedStartDate";
            this.dtExportSchedStartDate.Size = new System.Drawing.Size(128, 20);
            this.dtExportSchedStartDate.TabIndex = 124;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(96, 86);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(103, 20);
            this.btnExport.TabIndex = 123;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 13);
            this.label7.TabIndex = 125;
            this.label7.Text = "Select a date to export a production schedule from.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 126;
            this.label1.Text = "Export Schedule ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProdDate
            // 
            this.lblProdDate.AutoSize = true;
            this.lblProdDate.Location = new System.Drawing.Point(49, 64);
            this.lblProdDate.Name = "lblProdDate";
            this.lblProdDate.Size = new System.Drawing.Size(92, 13);
            this.lblProdDate.TabIndex = 127;
            this.lblProdDate.Text = "Export From Date:";
            // 
            // frmExportSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 122);
            this.Controls.Add(this.lblProdDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtExportSchedStartDate);
            this.Controls.Add(this.btnExport);
            this.Name = "frmExportSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExportSchedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtExportSchedStartDate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProdDate;
    }
}