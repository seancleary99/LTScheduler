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
            this.GetJobPlotsReportForDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new ProductionSchedule.DataSet2();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.houseTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erectorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.craneHireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GetJobPlotsReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JobsTableAdapter = new ProductionSchedule.DataSet2TableAdapters.JobsTableAdapter();
            this.GetJobPlotsReportTableAdapter = new ProductionSchedule.DataSet2TableAdapters.GetJobPlotsReportTableAdapter();
            this.GetJobPlotsReportForDatesTableAdapter = new ProductionSchedule.DataSet2TableAdapters.GetJobPlotsReportForDatesTableAdapter();
            this.workingHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GetJobPlotsReportForDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GetJobPlotsReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleToolStripMenuItem,
            this.jobsToolStripMenuItem,
            this.plotsToolStripMenuItem,
            this.houseTypesToolStripMenuItem,
            this.erectorsToolStripMenuItem,
            this.craneHireToolStripMenuItem,
            this.contractorsToolStripMenuItem,
            this.workingHoursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            this.scheduleToolStripMenuItem.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
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
            // workingHoursToolStripMenuItem
            // 
            this.workingHoursToolStripMenuItem.Name = "workingHoursToolStripMenuItem";
            this.workingHoursToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.workingHoursToolStripMenuItem.Text = "WorkingHours";
            this.workingHoursToolStripMenuItem.Click += new System.EventHandler(this.workingHoursToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 413);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Leadon Timberframe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetJobPlotsReportForDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.BindingSource GetJobPlotsReportForDatesBindingSource;
        private DataSet2TableAdapters.GetJobPlotsReportForDatesTableAdapter GetJobPlotsReportForDatesTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workingHoursToolStripMenuItem;
    }
}

