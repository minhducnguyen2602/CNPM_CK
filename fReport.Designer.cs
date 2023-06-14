namespace New_DOAN
{
    partial class frmReport
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblYear1 = new System.Windows.Forms.Label();
            this.lblYear2 = new System.Windows.Forms.Label();
            this.btnBorn = new System.Windows.Forms.Button();
            this.btnAchive = new System.Windows.Forms.Button();
            this.lblReport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(203, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(203, 139);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(300, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // lblYear1
            // 
            this.lblYear1.AutoSize = true;
            this.lblYear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear1.Location = new System.Drawing.Point(43, 82);
            this.lblYear1.Name = "lblYear1";
            this.lblYear1.Size = new System.Drawing.Size(80, 16);
            this.lblYear1.TabIndex = 2;
            this.lblYear1.Text = "Bắt đầu từ:";
            // 
            // lblYear2
            // 
            this.lblYear2.AutoSize = true;
            this.lblYear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear2.Location = new System.Drawing.Point(46, 144);
            this.lblYear2.Name = "lblYear2";
            this.lblYear2.Size = new System.Drawing.Size(34, 16);
            this.lblYear2.TabIndex = 3;
            this.lblYear2.Text = "Tới:";
            // 
            // btnBorn
            // 
            this.btnBorn.Location = new System.Drawing.Point(88, 192);
            this.btnBorn.Name = "btnBorn";
            this.btnBorn.Size = new System.Drawing.Size(92, 50);
            this.btnBorn.TabIndex = 4;
            this.btnBorn.Text = "Báo cáo tăng / giảm";
            this.btnBorn.UseVisualStyleBackColor = true;
            // 
            // btnAchive
            // 
            this.btnAchive.Location = new System.Drawing.Point(367, 192);
            this.btnAchive.Name = "btnAchive";
            this.btnAchive.Size = new System.Drawing.Size(92, 50);
            this.btnAchive.TabIndex = 5;
            this.btnAchive.Text = "Báo cáo thành tích";
            this.btnAchive.UseVisualStyleBackColor = true;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.ForeColor = System.Drawing.Color.Blue;
            this.lblReport.Location = new System.Drawing.Point(194, 26);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(159, 25);
            this.lblReport.TabIndex = 7;
            this.lblReport.Text = "LẬP BÁO CÁO";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 742);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.btnAchive);
            this.Controls.Add(this.btnBorn);
            this.Controls.Add(this.lblYear2);
            this.Controls.Add(this.lblYear1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReport";
            this.Text = "fReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblYear1;
        private System.Windows.Forms.Label lblYear2;
        private System.Windows.Forms.Button btnBorn;
        private System.Windows.Forms.Button btnAchive;
        private System.Windows.Forms.Label lblReport;
    }
}