namespace ProductionSchedule
{
    partial class frmHouseTypes
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
            this.dgHouseTypes = new System.Windows.Forms.DataGridView();
            this.SaveHouseType = new System.Windows.Forms.Button();
            this.lblHouseType = new System.Windows.Forms.Label();
            this.tbHouseType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgHouseTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(322, 9);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dgHouseTypes
            // 
            this.dgHouseTypes.AllowUserToOrderColumns = true;
            this.dgHouseTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHouseTypes.Location = new System.Drawing.Point(50, 51);
            this.dgHouseTypes.Name = "dgHouseTypes";
            this.dgHouseTypes.Size = new System.Drawing.Size(325, 198);
            this.dgHouseTypes.TabIndex = 10;
            this.dgHouseTypes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgHouseTypes_RowHeaderMouseClick);
            // 
            // SaveHouseType
            // 
            this.SaveHouseType.Location = new System.Drawing.Point(218, 9);
            this.SaveHouseType.Name = "SaveHouseType";
            this.SaveHouseType.Size = new System.Drawing.Size(98, 23);
            this.SaveHouseType.TabIndex = 9;
            this.SaveHouseType.Text = "SaveHouseType";
            this.SaveHouseType.UseVisualStyleBackColor = true;
            this.SaveHouseType.Click += new System.EventHandler(this.SaveHouseType_Click);
            // 
            // lblHouseType
            // 
            this.lblHouseType.AutoSize = true;
            this.lblHouseType.Location = new System.Drawing.Point(37, 9);
            this.lblHouseType.Name = "lblHouseType";
            this.lblHouseType.Size = new System.Drawing.Size(68, 13);
            this.lblHouseType.TabIndex = 8;
            this.lblHouseType.Text = "House Type:";
            // 
            // tbHouseType
            // 
            this.tbHouseType.Location = new System.Drawing.Point(112, 9);
            this.tbHouseType.Name = "tbHouseType";
            this.tbHouseType.Size = new System.Drawing.Size(100, 20);
            this.tbHouseType.TabIndex = 7;
            // 
            // frmHouseTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dgHouseTypes);
            this.Controls.Add(this.SaveHouseType);
            this.Controls.Add(this.lblHouseType);
            this.Controls.Add(this.tbHouseType);
            this.Name = "frmHouseTypes";
            this.Text = "HouseTypes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHouseTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHouseTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView dgHouseTypes;
        private System.Windows.Forms.Button SaveHouseType;
        private System.Windows.Forms.Label lblHouseType;
        private System.Windows.Forms.TextBox tbHouseType;
    }
}