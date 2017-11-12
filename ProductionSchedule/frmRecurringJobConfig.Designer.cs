namespace ProductionSchedule
{
    partial class frmRecurringJobConfig
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
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNextProdDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFreqDays = new System.Windows.Forms.TextBox();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.rbFortnight = new System.Windows.Forms.RadioButton();
            this.rbWeekly = new System.Windows.Forms.RadioButton();
            this.rbDaily = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFirstProdDate = new System.Windows.Forms.DateTimePicker();
            this.btnSaveRecurringSchedule = new System.Windows.Forms.Button();
            this.lblJobId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 121;
            this.label7.Text = "Job Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 127;
            this.label2.Text = "Next Production:";
            // 
            // dtNextProdDate
            // 
            this.dtNextProdDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtNextProdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNextProdDate.Location = new System.Drawing.Point(133, 204);
            this.dtNextProdDate.Name = "dtNextProdDate";
            this.dtNextProdDate.Size = new System.Drawing.Size(128, 20);
            this.dtNextProdDate.TabIndex = 130;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 128;
            this.label8.Text = "days";
            // 
            // tbFreqDays
            // 
            this.tbFreqDays.Enabled = false;
            this.tbFreqDays.Location = new System.Drawing.Point(133, 152);
            this.tbFreqDays.Name = "tbFreqDays";
            this.tbFreqDays.Size = new System.Drawing.Size(69, 20);
            this.tbFreqDays.TabIndex = 129;
            this.tbFreqDays.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFreqDays_KeyUp);
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(42, 152);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(60, 17);
            this.rbCustom.TabIndex = 126;
            this.rbCustom.TabStop = true;
            this.rbCustom.Text = "Custom";
            this.rbCustom.UseVisualStyleBackColor = true;
            this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCustom_CheckedChanged);
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Location = new System.Drawing.Point(42, 129);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(62, 17);
            this.rbMonthly.TabIndex = 125;
            this.rbMonthly.TabStop = true;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            this.rbMonthly.CheckedChanged += new System.EventHandler(this.rbMonthly_CheckedChanged);
            // 
            // rbFortnight
            // 
            this.rbFortnight.AutoSize = true;
            this.rbFortnight.Location = new System.Drawing.Point(42, 106);
            this.rbFortnight.Name = "rbFortnight";
            this.rbFortnight.Size = new System.Drawing.Size(73, 17);
            this.rbFortnight.TabIndex = 124;
            this.rbFortnight.TabStop = true;
            this.rbFortnight.Text = "Fortnightly";
            this.rbFortnight.UseVisualStyleBackColor = true;
            this.rbFortnight.CheckedChanged += new System.EventHandler(this.rbFortnight_CheckedChanged);
            // 
            // rbWeekly
            // 
            this.rbWeekly.AutoSize = true;
            this.rbWeekly.Location = new System.Drawing.Point(41, 85);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(61, 17);
            this.rbWeekly.TabIndex = 123;
            this.rbWeekly.TabStop = true;
            this.rbWeekly.Text = "Weekly";
            this.rbWeekly.UseVisualStyleBackColor = true;
            this.rbWeekly.CheckedChanged += new System.EventHandler(this.rbWeekly_CheckedChanged);
            // 
            // rbDaily
            // 
            this.rbDaily.AutoSize = true;
            this.rbDaily.Location = new System.Drawing.Point(42, 62);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(48, 17);
            this.rbDaily.TabIndex = 122;
            this.rbDaily.TabStop = true;
            this.rbDaily.Text = "Daily";
            this.rbDaily.UseVisualStyleBackColor = true;
            this.rbDaily.CheckedChanged += new System.EventHandler(this.rbDaily_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 131;
            this.label1.Text = "First Production:";
            // 
            // dtFirstProdDate
            // 
            this.dtFirstProdDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtFirstProdDate.Enabled = false;
            this.dtFirstProdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFirstProdDate.Location = new System.Drawing.Point(133, 178);
            this.dtFirstProdDate.Name = "dtFirstProdDate";
            this.dtFirstProdDate.Size = new System.Drawing.Size(128, 20);
            this.dtFirstProdDate.TabIndex = 132;
            // 
            // btnSaveRecurringSchedule
            // 
            this.btnSaveRecurringSchedule.Location = new System.Drawing.Point(100, 247);
            this.btnSaveRecurringSchedule.Name = "btnSaveRecurringSchedule";
            this.btnSaveRecurringSchedule.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRecurringSchedule.TabIndex = 133;
            this.btnSaveRecurringSchedule.Text = "Save";
            this.btnSaveRecurringSchedule.UseVisualStyleBackColor = true;
            this.btnSaveRecurringSchedule.Click += new System.EventHandler(this.btnSaveRecurringSchedule_Click);
            // 
            // lblJobId
            // 
            this.lblJobId.AutoSize = true;
            this.lblJobId.Location = new System.Drawing.Point(130, 37);
            this.lblJobId.Name = "lblJobId";
            this.lblJobId.Size = new System.Drawing.Size(0, 13);
            this.lblJobId.TabIndex = 134;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(52, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 17);
            this.label3.TabIndex = 135;
            this.label3.Text = "Configure Recurring Job";
            // 
            // frmRecurringJobConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 292);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblJobId);
            this.Controls.Add(this.btnSaveRecurringSchedule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFirstProdDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtNextProdDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbFreqDays);
            this.Controls.Add(this.rbCustom);
            this.Controls.Add(this.rbMonthly);
            this.Controls.Add(this.rbFortnight);
            this.Controls.Add(this.rbWeekly);
            this.Controls.Add(this.rbDaily);
            this.Controls.Add(this.label7);
            this.Name = "frmRecurringJobConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecurringJobConfig";
            this.Load += new System.EventHandler(this.frmRecurringJobConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNextProdDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFreqDays;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.RadioButton rbFortnight;
        private System.Windows.Forms.RadioButton rbWeekly;
        private System.Windows.Forms.RadioButton rbDaily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFirstProdDate;
        private System.Windows.Forms.Button btnSaveRecurringSchedule;
        private System.Windows.Forms.Label lblJobId;
        private System.Windows.Forms.Label label3;
    }
}