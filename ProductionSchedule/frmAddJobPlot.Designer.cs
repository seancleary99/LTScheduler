namespace ProductionSchedule
{
    partial class frmAddJobPlot
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblJobIdValue = new System.Windows.Forms.Label();
            this.dgUnscheduledPlots = new System.Windows.Forms.DataGridView();
            this.btnAddPlots = new System.Windows.Forms.Button();
            this.btnCreateNewPlot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUnscheduledPlots)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job ID";
            // 
            // lblJobIdValue
            // 
            this.lblJobIdValue.AutoSize = true;
            this.lblJobIdValue.Location = new System.Drawing.Point(57, 27);
            this.lblJobIdValue.Name = "lblJobIdValue";
            this.lblJobIdValue.Size = new System.Drawing.Size(0, 13);
            this.lblJobIdValue.TabIndex = 1;
            // 
            // dgUnscheduledPlots
            // 
            this.dgUnscheduledPlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUnscheduledPlots.Location = new System.Drawing.Point(15, 57);
            this.dgUnscheduledPlots.Name = "dgUnscheduledPlots";
            this.dgUnscheduledPlots.Size = new System.Drawing.Size(516, 150);
            this.dgUnscheduledPlots.TabIndex = 3;
            // 
            // btnAddPlots
            // 
            this.btnAddPlots.Location = new System.Drawing.Point(15, 225);
            this.btnAddPlots.Name = "btnAddPlots";
            this.btnAddPlots.Size = new System.Drawing.Size(137, 23);
            this.btnAddPlots.TabIndex = 4;
            this.btnAddPlots.Text = "Add Selected Plots";
            this.btnAddPlots.UseVisualStyleBackColor = true;
            this.btnAddPlots.Click += new System.EventHandler(this.btnAddPlots_Click);
            // 
            // btnCreateNewPlot
            // 
            this.btnCreateNewPlot.Location = new System.Drawing.Point(433, 225);
            this.btnCreateNewPlot.Name = "btnCreateNewPlot";
            this.btnCreateNewPlot.Size = new System.Drawing.Size(98, 23);
            this.btnCreateNewPlot.TabIndex = 5;
            this.btnCreateNewPlot.Text = "Create New Plot";
            this.btnCreateNewPlot.UseVisualStyleBackColor = true;
            this.btnCreateNewPlot.Click += new System.EventHandler(this.btnCreateNewPlot_Click);
            // 
            // frmAddJobPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 269);
            this.Controls.Add(this.btnCreateNewPlot);
            this.Controls.Add(this.btnAddPlots);
            this.Controls.Add(this.dgUnscheduledPlots);
            this.Controls.Add(this.lblJobIdValue);
            this.Controls.Add(this.label1);
            this.Name = "frmAddJobPlot";
            this.Text = "frmAddJobPlot";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddJobPlot_FormClosed);
            this.Load += new System.EventHandler(this.frmAddJobPlot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUnscheduledPlots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJobIdValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgUnscheduledPlots;
        private System.Windows.Forms.Button btnAddPlots;
        private System.Windows.Forms.Button btnCreateNewPlot;
    }
}