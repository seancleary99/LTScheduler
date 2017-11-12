namespace ProductionSchedule
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.houseTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erectorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.craneHireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GetJobPlotsReportForDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new ProductionSchedule.DataSet2();
            this.GetJobPlotsReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JobsTableAdapter = new ProductionSchedule.DataSet2TableAdapters.JobsTableAdapter();
            this.GetJobPlotsReportTableAdapter = new ProductionSchedule.DataSet2TableAdapters.GetJobPlotsReportTableAdapter();
            this.GetJobPlotsReportForDatesTableAdapter = new ProductionSchedule.DataSet2TableAdapters.GetJobPlotsReportForDatesTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GetJobPlotsReportForDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetJobPlotsReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobsToolStripMenuItem,
            this.plotsToolStripMenuItem,
            this.houseTypesToolStripMenuItem,
            this.erectorsToolStripMenuItem,
            this.craneHireToolStripMenuItem,
            this.contractorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jobsToolStripMenuItem
            // 
            this.jobsToolStripMenuItem.Name = "jobsToolStripMenuItem";
            this.jobsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.jobsToolStripMenuItem.Text = "Jobs";
            this.jobsToolStripMenuItem.Click += new System.EventHandler(this.jobsToolStripMenuItem_Click);
            // 
            // plotsToolStripMenuItem
            // 
            this.plotsToolStripMenuItem.Name = "plotsToolStripMenuItem";
            this.plotsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.plotsToolStripMenuItem.Text = "Plots";
            this.plotsToolStripMenuItem.Click += new System.EventHandler(this.plotsToolStripMenuItem_Click);
            // 
            // houseTypesToolStripMenuItem
            // 
            this.houseTypesToolStripMenuItem.Name = "houseTypesToolStripMenuItem";
            this.houseTypesToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.houseTypesToolStripMenuItem.Text = "HouseTypes";
            this.houseTypesToolStripMenuItem.Click += new System.EventHandler(this.houseTypesToolStripMenuItem_Click);
            // 
            // erectorsToolStripMenuItem
            // 
            this.erectorsToolStripMenuItem.Name = "erectorsToolStripMenuItem";
            this.erectorsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.erectorsToolStripMenuItem.Text = "Erectors";
            this.erectorsToolStripMenuItem.Click += new System.EventHandler(this.erectorsToolStripMenuItem_Click);
            // 
            // craneHireToolStripMenuItem
            // 
            this.craneHireToolStripMenuItem.Name = "craneHireToolStripMenuItem";
            this.craneHireToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.craneHireToolStripMenuItem.Text = "CraneHire";
            this.craneHireToolStripMenuItem.Click += new System.EventHandler(this.craneHireToolStripMenuItem_Click);
            // 
            // contractorsToolStripMenuItem
            // 
            this.contractorsToolStripMenuItem.Name = "contractorsToolStripMenuItem";
            this.contractorsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.contractorsToolStripMenuItem.Text = "Contractors";
            this.contractorsToolStripMenuItem.Click += new System.EventHandler(this.contractorsToolStripMenuItem_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(684, 27);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(154, 26);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 20);
            this.dtFrom.TabIndex = 5;
            this.dtFrom.Value = new System.DateTime(2007, 1, 1, 22, 48, 0, 0);
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(432, 27);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 20);
            this.dtTo.TabIndex = 6;
            this.dtTo.Value = new System.DateTime(2097, 1, 1, 21, 52, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "From Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "To Date:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.GetJobPlotsReportForDatesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DisplayName = "Production Schedule";
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProductionSchedule.rptProductionScheduleFiltered.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 24);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Padding = new System.Windows.Forms.Padding(0, 33, 0, 0);
            this.reportViewer1.Size = new System.Drawing.Size(898, 389);
            this.reportViewer1.TabIndex = 3;
            // 
            // GetJobPlotsReportForDatesBindingSource
            // 
            this.GetJobPlotsReportForDatesBindingSource.DataMember = "GetJobPlotsReportForDates";
            this.GetJobPlotsReportForDatesBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GetJobPlotsReportBindingSource
            // 
            this.GetJobPlotsReportBindingSource.DataMember = "GetJobPlotsReport";
            this.GetJobPlotsReportBindingSource.DataSource = this.DataSet2;
            // 
            // JobsBindingSource
            // 
            this.JobsBindingSource.DataMember = "Jobs";
            this.JobsBindingSource.DataSource = this.DataSet2;
            // 
            // JobsTableAdapter
            // 
            this.JobsTableAdapter.ClearBeforeFill = true;
            // 
            // GetJobPlotsReportTableAdapter
            // 
            this.GetJobPlotsReportTableAdapter.ClearBeforeFill = true;
            // 
            // GetJobPlotsReportForDatesTableAdapter
            // 
            this.GetJobPlotsReportForDatesTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 413);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Leadon Timberframe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GetJobPlotsReportForDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetJobPlotsReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem houseTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erectorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem craneHireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plotsToolStripMenuItem;
        private System.Windows.Forms.BindingSource JobsBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.JobsTableAdapter JobsTableAdapter;
        private System.Windows.Forms.BindingSource GetJobPlotsReportBindingSource;
        private DataSet2TableAdapters.GetJobPlotsReportTableAdapter GetJobPlotsReportTableAdapter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GetJobPlotsReportForDatesBindingSource;
        private DataSet2TableAdapters.GetJobPlotsReportForDatesTableAdapter GetJobPlotsReportForDatesTableAdapter;
    }
}

