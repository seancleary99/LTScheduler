﻿namespace ProductionSchedule
{
    partial class frmJobs
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
            this.btnSaveJob = new System.Windows.Forms.Button();
            this.lblCrane = new System.Windows.Forms.Label();
            this.tbLine = new System.Windows.Forms.TextBox();
            this.lblContractor = new System.Windows.Forms.Label();
            this.cbContractor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblJobIdVal = new System.Windows.Forms.Label();
            this.lblJobName = new System.Windows.Forms.Label();
            this.tbJobName = new System.Windows.Forms.TextBox();
            this.lblSiteName = new System.Windows.Forms.Label();
            this.tbSiteName = new System.Windows.Forms.TextBox();
            this.lblSiteContact = new System.Windows.Forms.Label();
            this.tbSiteContact = new System.Windows.Forms.TextBox();
            this.lblSiteCompleted = new System.Windows.Forms.Label();
            this.chkSiteComplete = new System.Windows.Forms.CheckBox();
            this.btnAddNewJob = new System.Windows.Forms.Button();
            this.lblProdDate = new System.Windows.Forms.Label();
            this.dtProductionDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtOnSite = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtCompletionDate = new System.Windows.Forms.DateTimePicker();
            this.dgJobs = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditPlot = new System.Windows.Forms.Button();
            this.btnRemovePlot = new System.Windows.Forms.Button();
            this.btnAddPlot = new System.Windows.Forms.Button();
            this.dgJobPlots = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProductionTime = new System.Windows.Forms.Label();
            this.tbProductionTime = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRecalc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtProdCompleteDate = new System.Windows.Forms.DateTimePicker();
            this.dtExportSchedStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnDeadTime = new System.Windows.Forms.Button();
            this.btnRecurring = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgJobs)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgJobPlots)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(116, 577);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 100;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // btnSaveJob
            // 
            this.btnSaveJob.Location = new System.Drawing.Point(12, 577);
            this.btnSaveJob.Name = "btnSaveJob";
            this.btnSaveJob.Size = new System.Drawing.Size(98, 23);
            this.btnSaveJob.TabIndex = 99;
            this.btnSaveJob.Text = "Save Job";
            this.btnSaveJob.UseVisualStyleBackColor = true;
            this.btnSaveJob.Click += new System.EventHandler(this.btnSaveJob_Click);
            // 
            // lblCrane
            // 
            this.lblCrane.AutoSize = true;
            this.lblCrane.Location = new System.Drawing.Point(12, 40);
            this.lblCrane.Name = "lblCrane";
            this.lblCrane.Size = new System.Drawing.Size(30, 13);
            this.lblCrane.TabIndex = 23;
            this.lblCrane.Text = "Line:";
            // 
            // tbLine
            // 
            this.tbLine.Location = new System.Drawing.Point(119, 37);
            this.tbLine.Name = "tbLine";
            this.tbLine.Size = new System.Drawing.Size(165, 20);
            this.tbLine.TabIndex = 1;
            // 
            // lblContractor
            // 
            this.lblContractor.AutoSize = true;
            this.lblContractor.Location = new System.Drawing.Point(12, 93);
            this.lblContractor.Name = "lblContractor";
            this.lblContractor.Size = new System.Drawing.Size(56, 13);
            this.lblContractor.TabIndex = 26;
            this.lblContractor.Text = "Contractor";
            // 
            // cbContractor
            // 
            this.cbContractor.FormattingEnabled = true;
            this.cbContractor.Location = new System.Drawing.Point(119, 93);
            this.cbContractor.Name = "cbContractor";
            this.cbContractor.Size = new System.Drawing.Size(165, 21);
            this.cbContractor.TabIndex = 3;
            this.cbContractor.Text = "Select Contractor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Job ID:";
            // 
            // lblJobIdVal
            // 
            this.lblJobIdVal.AutoSize = true;
            this.lblJobIdVal.Location = new System.Drawing.Point(116, 9);
            this.lblJobIdVal.Name = "lblJobIdVal";
            this.lblJobIdVal.Size = new System.Drawing.Size(0, 13);
            this.lblJobIdVal.TabIndex = 29;
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.Location = new System.Drawing.Point(12, 66);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(58, 13);
            this.lblJobName.TabIndex = 31;
            this.lblJobName.Text = "Job Name:";
            // 
            // tbJobName
            // 
            this.tbJobName.Location = new System.Drawing.Point(119, 66);
            this.tbJobName.Name = "tbJobName";
            this.tbJobName.Size = new System.Drawing.Size(165, 20);
            this.tbJobName.TabIndex = 2;
            // 
            // lblSiteName
            // 
            this.lblSiteName.AutoSize = true;
            this.lblSiteName.Location = new System.Drawing.Point(12, 130);
            this.lblSiteName.Name = "lblSiteName";
            this.lblSiteName.Size = new System.Drawing.Size(59, 13);
            this.lblSiteName.TabIndex = 33;
            this.lblSiteName.Text = "Site Name:";
            // 
            // tbSiteName
            // 
            this.tbSiteName.Location = new System.Drawing.Point(119, 130);
            this.tbSiteName.Name = "tbSiteName";
            this.tbSiteName.Size = new System.Drawing.Size(165, 20);
            this.tbSiteName.TabIndex = 4;
            // 
            // lblSiteContact
            // 
            this.lblSiteContact.AutoSize = true;
            this.lblSiteContact.Location = new System.Drawing.Point(12, 166);
            this.lblSiteContact.Name = "lblSiteContact";
            this.lblSiteContact.Size = new System.Drawing.Size(68, 13);
            this.lblSiteContact.TabIndex = 35;
            this.lblSiteContact.Text = "Site Contact:";
            // 
            // tbSiteContact
            // 
            this.tbSiteContact.Location = new System.Drawing.Point(119, 166);
            this.tbSiteContact.Name = "tbSiteContact";
            this.tbSiteContact.Size = new System.Drawing.Size(165, 20);
            this.tbSiteContact.TabIndex = 5;
            // 
            // lblSiteCompleted
            // 
            this.lblSiteCompleted.AutoSize = true;
            this.lblSiteCompleted.Location = new System.Drawing.Point(12, 368);
            this.lblSiteCompleted.Name = "lblSiteCompleted";
            this.lblSiteCompleted.Size = new System.Drawing.Size(87, 13);
            this.lblSiteCompleted.TabIndex = 37;
            this.lblSiteCompleted.Text = "Site Completed?:";
            // 
            // chkSiteComplete
            // 
            this.chkSiteComplete.AutoSize = true;
            this.chkSiteComplete.Location = new System.Drawing.Point(119, 368);
            this.chkSiteComplete.Name = "chkSiteComplete";
            this.chkSiteComplete.Size = new System.Drawing.Size(15, 14);
            this.chkSiteComplete.TabIndex = 6;
            this.chkSiteComplete.UseVisualStyleBackColor = true;
            this.chkSiteComplete.CheckedChanged += new System.EventHandler(this.chkSiteComplete_CheckedChanged);
            // 
            // btnAddNewJob
            // 
            this.btnAddNewJob.AutoSize = true;
            this.btnAddNewJob.Location = new System.Drawing.Point(206, 577);
            this.btnAddNewJob.Name = "btnAddNewJob";
            this.btnAddNewJob.Size = new System.Drawing.Size(81, 23);
            this.btnAddNewJob.TabIndex = 101;
            this.btnAddNewJob.Text = "Add New Job";
            this.btnAddNewJob.UseVisualStyleBackColor = true;
            this.btnAddNewJob.Click += new System.EventHandler(this.btnAddNewJob_Click);
            // 
            // lblProdDate
            // 
            this.lblProdDate.AutoSize = true;
            this.lblProdDate.Location = new System.Drawing.Point(12, 204);
            this.lblProdDate.Name = "lblProdDate";
            this.lblProdDate.Size = new System.Drawing.Size(87, 13);
            this.lblProdDate.TabIndex = 102;
            this.lblProdDate.Text = "Production Date:";
            // 
            // dtProductionDate
            // 
            this.dtProductionDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtProductionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtProductionDate.Location = new System.Drawing.Point(119, 198);
            this.dtProductionDate.Name = "dtProductionDate";
            this.dtProductionDate.Size = new System.Drawing.Size(200, 20);
            this.dtProductionDate.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 104;
            this.label3.Text = "OnSite Date:";
            // 
            // dtOnSite
            // 
            this.dtOnSite.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtOnSite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOnSite.Location = new System.Drawing.Point(119, 257);
            this.dtOnSite.Name = "dtOnSite";
            this.dtOnSite.Size = new System.Drawing.Size(200, 20);
            this.dtOnSite.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(12, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 106;
            this.label4.Text = "Completion Date:";
            // 
            // dtCompletionDate
            // 
            this.dtCompletionDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtCompletionDate.Enabled = false;
            this.dtCompletionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCompletionDate.Location = new System.Drawing.Point(119, 292);
            this.dtCompletionDate.Name = "dtCompletionDate";
            this.dtCompletionDate.Size = new System.Drawing.Size(200, 20);
            this.dtCompletionDate.TabIndex = 107;
            this.dtCompletionDate.Visible = false;
            // 
            // dgJobs
            // 
            this.dgJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgJobs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJobs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgJobs.Location = new System.Drawing.Point(15, 421);
            this.dgJobs.Name = "dgJobs";
            this.dgJobs.Size = new System.Drawing.Size(1097, 150);
            this.dgJobs.TabIndex = 108;
            this.dgJobs.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgJobs_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditPlot);
            this.panel1.Controls.Add(this.btnRemovePlot);
            this.panel1.Controls.Add(this.btnAddPlot);
            this.panel1.Controls.Add(this.dgJobPlots);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(589, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 317);
            this.panel1.TabIndex = 109;
            // 
            // btnEditPlot
            // 
            this.btnEditPlot.Location = new System.Drawing.Point(542, 249);
            this.btnEditPlot.Name = "btnEditPlot";
            this.btnEditPlot.Size = new System.Drawing.Size(109, 23);
            this.btnEditPlot.TabIndex = 4;
            this.btnEditPlot.Text = "Edit Plot";
            this.btnEditPlot.UseVisualStyleBackColor = true;
            this.btnEditPlot.Click += new System.EventHandler(this.btnEditPlot_Click);
            // 
            // btnRemovePlot
            // 
            this.btnRemovePlot.Location = new System.Drawing.Point(103, 249);
            this.btnRemovePlot.Name = "btnRemovePlot";
            this.btnRemovePlot.Size = new System.Drawing.Size(109, 23);
            this.btnRemovePlot.TabIndex = 3;
            this.btnRemovePlot.Text = "Remove Plot";
            this.btnRemovePlot.UseVisualStyleBackColor = true;
            this.btnRemovePlot.Click += new System.EventHandler(this.btnRemovePlot_Click);
            // 
            // btnAddPlot
            // 
            this.btnAddPlot.Location = new System.Drawing.Point(22, 249);
            this.btnAddPlot.Name = "btnAddPlot";
            this.btnAddPlot.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlot.TabIndex = 2;
            this.btnAddPlot.Text = "Add Plot";
            this.btnAddPlot.UseVisualStyleBackColor = true;
            this.btnAddPlot.Click += new System.EventHandler(this.btnAddPlot_Click);
            // 
            // dgJobPlots
            // 
            this.dgJobPlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJobPlots.Location = new System.Drawing.Point(22, 39);
            this.dgJobPlots.Name = "dgJobPlots";
            this.dgJobPlots.Size = new System.Drawing.Size(644, 185);
            this.dgJobPlots.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "JOB PLOTS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblProductionTime
            // 
            this.lblProductionTime.AutoSize = true;
            this.lblProductionTime.Enabled = false;
            this.lblProductionTime.Location = new System.Drawing.Point(12, 337);
            this.lblProductionTime.Name = "lblProductionTime";
            this.lblProductionTime.Size = new System.Drawing.Size(87, 13);
            this.lblProductionTime.TabIndex = 110;
            this.lblProductionTime.Text = "Production Time:";
            // 
            // tbProductionTime
            // 
            this.tbProductionTime.Enabled = false;
            this.tbProductionTime.Location = new System.Drawing.Point(119, 334);
            this.tbProductionTime.Name = "tbProductionTime";
            this.tbProductionTime.Size = new System.Drawing.Size(165, 20);
            this.tbProductionTime.TabIndex = 111;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1118, 501);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(122, 23);
            this.btnExport.TabIndex = 112;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRecalc
            // 
            this.btnRecalc.Location = new System.Drawing.Point(1118, 421);
            this.btnRecalc.Name = "btnRecalc";
            this.btnRecalc.Size = new System.Drawing.Size(122, 23);
            this.btnRecalc.TabIndex = 113;
            this.btnRecalc.Text = "Recalculate Schedule";
            this.btnRecalc.UseVisualStyleBackColor = true;
            this.btnRecalc.Click += new System.EventHandler(this.btnRecalc_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 114;
            this.label6.Text = "Production Complete:";
            // 
            // dtProdCompleteDate
            // 
            this.dtProdCompleteDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtProdCompleteDate.Enabled = false;
            this.dtProdCompleteDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtProdCompleteDate.Location = new System.Drawing.Point(119, 230);
            this.dtProdCompleteDate.Name = "dtProdCompleteDate";
            this.dtProdCompleteDate.Size = new System.Drawing.Size(200, 20);
            this.dtProdCompleteDate.TabIndex = 115;
            // 
            // dtExportSchedStartDate
            // 
            this.dtExportSchedStartDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtExportSchedStartDate.Enabled = false;
            this.dtExportSchedStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtExportSchedStartDate.Location = new System.Drawing.Point(1118, 475);
            this.dtExportSchedStartDate.Name = "dtExportSchedStartDate";
            this.dtExportSchedStartDate.Size = new System.Drawing.Size(118, 20);
            this.dtExportSchedStartDate.TabIndex = 116;
            this.dtExportSchedStartDate.Visible = false;
            // 
            // btnDeadTime
            // 
            this.btnDeadTime.Location = new System.Drawing.Point(428, 69);
            this.btnDeadTime.Name = "btnDeadTime";
            this.btnDeadTime.Size = new System.Drawing.Size(135, 23);
            this.btnDeadTime.TabIndex = 120;
            this.btnDeadTime.Text = "Record Dead Time";
            this.btnDeadTime.UseVisualStyleBackColor = true;
            this.btnDeadTime.Click += new System.EventHandler(this.btnDeadTime_Click);
            // 
            // btnRecurring
            // 
            this.btnRecurring.Location = new System.Drawing.Point(428, 37);
            this.btnRecurring.Name = "btnRecurring";
            this.btnRecurring.Size = new System.Drawing.Size(135, 23);
            this.btnRecurring.TabIndex = 121;
            this.btnRecurring.Text = "Configure Recurring";
            this.btnRecurring.UseVisualStyleBackColor = true;
            this.btnRecurring.Click += new System.EventHandler(this.btnRecurring_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "SCHEDULE OVERVIEW";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(1115, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 122;
            this.label7.Text = "Export schedule after this date:";
            this.label7.Visible = false;
            // 
            // frmJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 608);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRecurring);
            this.Controls.Add(this.btnDeadTime);
            this.Controls.Add(this.dtExportSchedStartDate);
            this.Controls.Add(this.dtProdCompleteDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRecalc);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.tbProductionTime);
            this.Controls.Add(this.lblProductionTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgJobs);
            this.Controls.Add(this.dtCompletionDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtOnSite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtProductionDate);
            this.Controls.Add(this.lblProdDate);
            this.Controls.Add(this.btnAddNewJob);
            this.Controls.Add(this.chkSiteComplete);
            this.Controls.Add(this.lblSiteCompleted);
            this.Controls.Add(this.lblSiteContact);
            this.Controls.Add(this.tbSiteContact);
            this.Controls.Add(this.lblSiteName);
            this.Controls.Add(this.tbSiteName);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.tbJobName);
            this.Controls.Add(this.lblJobIdVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbContractor);
            this.Controls.Add(this.lblContractor);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.btnSaveJob);
            this.Controls.Add(this.lblCrane);
            this.Controls.Add(this.tbLine);
            this.Name = "frmJobs";
            this.Text = "frmJobs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgJobs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgJobPlots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button btnSaveJob;
        private System.Windows.Forms.Label lblCrane;
        private System.Windows.Forms.TextBox tbLine;
        private System.Windows.Forms.Label lblContractor;
        private System.Windows.Forms.ComboBox cbContractor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJobIdVal;
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.TextBox tbJobName;
        private System.Windows.Forms.Label lblSiteName;
        private System.Windows.Forms.TextBox tbSiteName;
        private System.Windows.Forms.Label lblSiteContact;
        private System.Windows.Forms.TextBox tbSiteContact;
        private System.Windows.Forms.Label lblSiteCompleted;
        private System.Windows.Forms.CheckBox chkSiteComplete;
        private System.Windows.Forms.Button btnAddNewJob;
        private System.Windows.Forms.DateTimePicker dtProductionDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtOnSite;
        private System.Windows.Forms.Label lblProdDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtCompletionDate;
        private System.Windows.Forms.DataGridView dgJobs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditPlot;
        private System.Windows.Forms.Button btnRemovePlot;
        private System.Windows.Forms.Button btnAddPlot;
        private System.Windows.Forms.DataGridView dgJobPlots;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblProductionTime;
        private System.Windows.Forms.TextBox tbProductionTime;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnRecalc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtProdCompleteDate;
        private System.Windows.Forms.DateTimePicker dtExportSchedStartDate;
        private System.Windows.Forms.Button btnDeadTime;
        private System.Windows.Forms.Button btnRecurring;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}