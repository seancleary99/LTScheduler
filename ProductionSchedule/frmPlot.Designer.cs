namespace ProductionSchedule
{
    partial class frmPlot
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
            this.lblPlotID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgPlots = new System.Windows.Forms.DataGridView();
            this.lblPlotIDVal = new System.Windows.Forms.Label();
            this.tbPlotName = new System.Windows.Forms.TextBox();
            this.cbxPlotType = new System.Windows.Forms.ComboBox();
            this.tbPlotFloorTot = new System.Windows.Forms.TextBox();
            this.tbPlotBenchTot = new System.Windows.Forms.TextBox();
            this.tbPlotLineTot = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSavePlot = new System.Windows.Forms.Button();
            this.btnDelPlot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlots)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlotID
            // 
            this.lblPlotID.AutoSize = true;
            this.lblPlotID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlotID.Location = new System.Drawing.Point(12, 18);
            this.lblPlotID.Name = "lblPlotID";
            this.lblPlotID.Size = new System.Drawing.Size(42, 13);
            this.lblPlotID.TabIndex = 0;
            this.lblPlotID.Text = "Plot ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plot Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plot Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Plot Line Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Plot Bench Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Plot Floor Total:";
            // 
            // dgPlots
            // 
            this.dgPlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlots.Location = new System.Drawing.Point(15, 161);
            this.dgPlots.Name = "dgPlots";
            this.dgPlots.Size = new System.Drawing.Size(699, 286);
            this.dgPlots.TabIndex = 6;
            this.dgPlots.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPlots_RowHeaderMouseClick);
            // 
            // lblPlotIDVal
            // 
            this.lblPlotIDVal.AutoSize = true;
            this.lblPlotIDVal.Location = new System.Drawing.Point(132, 18);
            this.lblPlotIDVal.Name = "lblPlotIDVal";
            this.lblPlotIDVal.Size = new System.Drawing.Size(0, 13);
            this.lblPlotIDVal.TabIndex = 7;
            // 
            // tbPlotName
            // 
            this.tbPlotName.Location = new System.Drawing.Point(135, 39);
            this.tbPlotName.Name = "tbPlotName";
            this.tbPlotName.Size = new System.Drawing.Size(334, 20);
            this.tbPlotName.TabIndex = 8;
            // 
            // cbxPlotType
            // 
            this.cbxPlotType.FormattingEnabled = true;
            this.cbxPlotType.Location = new System.Drawing.Point(135, 64);
            this.cbxPlotType.Name = "cbxPlotType";
            this.cbxPlotType.Size = new System.Drawing.Size(334, 21);
            this.cbxPlotType.TabIndex = 9;
            // 
            // tbPlotFloorTot
            // 
            this.tbPlotFloorTot.Location = new System.Drawing.Point(135, 134);
            this.tbPlotFloorTot.Name = "tbPlotFloorTot";
            this.tbPlotFloorTot.Size = new System.Drawing.Size(334, 20);
            this.tbPlotFloorTot.TabIndex = 10;
            // 
            // tbPlotBenchTot
            // 
            this.tbPlotBenchTot.Location = new System.Drawing.Point(135, 111);
            this.tbPlotBenchTot.Name = "tbPlotBenchTot";
            this.tbPlotBenchTot.Size = new System.Drawing.Size(334, 20);
            this.tbPlotBenchTot.TabIndex = 11;
            // 
            // tbPlotLineTot
            // 
            this.tbPlotLineTot.Location = new System.Drawing.Point(135, 89);
            this.tbPlotLineTot.Name = "tbPlotLineTot";
            this.tbPlotLineTot.Size = new System.Drawing.Size(334, 20);
            this.tbPlotLineTot.TabIndex = 12;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(16, 453);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 23);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "New Plot";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSavePlot
            // 
            this.btnSavePlot.Location = new System.Drawing.Point(108, 453);
            this.btnSavePlot.Name = "btnSavePlot";
            this.btnSavePlot.Size = new System.Drawing.Size(86, 23);
            this.btnSavePlot.TabIndex = 14;
            this.btnSavePlot.Text = "Save Plot";
            this.btnSavePlot.UseVisualStyleBackColor = true;
            this.btnSavePlot.Click += new System.EventHandler(this.btnSavePlot_Click);
            // 
            // btnDelPlot
            // 
            this.btnDelPlot.Location = new System.Drawing.Point(489, 453);
            this.btnDelPlot.Name = "btnDelPlot";
            this.btnDelPlot.Size = new System.Drawing.Size(86, 23);
            this.btnDelPlot.TabIndex = 15;
            this.btnDelPlot.Text = "Delete Plot";
            this.btnDelPlot.UseVisualStyleBackColor = true;
            this.btnDelPlot.Click += new System.EventHandler(this.btnDelPlot_Click);
            // 
            // frmPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 488);
            this.Controls.Add(this.btnDelPlot);
            this.Controls.Add(this.btnSavePlot);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.tbPlotLineTot);
            this.Controls.Add(this.tbPlotBenchTot);
            this.Controls.Add(this.tbPlotFloorTot);
            this.Controls.Add(this.cbxPlotType);
            this.Controls.Add(this.tbPlotName);
            this.Controls.Add(this.lblPlotIDVal);
            this.Controls.Add(this.dgPlots);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlotID);
            this.Name = "frmPlot";
            this.Text = "frmPlot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPlot_FormClosing);
            this.Load += new System.EventHandler(this.frmPlot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgPlots;
        private System.Windows.Forms.TextBox tbPlotName;
        private System.Windows.Forms.ComboBox cbxPlotType;
        private System.Windows.Forms.TextBox tbPlotFloorTot;
        private System.Windows.Forms.TextBox tbPlotBenchTot;
        private System.Windows.Forms.TextBox tbPlotLineTot;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSavePlot;
        private System.Windows.Forms.Button btnDelPlot;
        private System.Windows.Forms.Label lblPlotIDVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlotID;
    }
}