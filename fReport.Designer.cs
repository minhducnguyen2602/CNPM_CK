﻿namespace New_DOAN
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
            this.components = new System.ComponentModel.Container();
            this.lblYear1 = new System.Windows.Forms.Label();
            this.lblYear2 = new System.Windows.Forms.Label();
            this.btnBorn = new System.Windows.Forms.Button();
            this.btnAchive = new System.Windows.Forms.Button();
            this.lblReport = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dtgvReport = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblReportName = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYear1
            // 
            this.lblYear1.AutoSize = true;
            this.lblYear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear1.Location = new System.Drawing.Point(43, 82);
            this.lblYear1.Name = "lblYear1";
            this.lblYear1.Size = new System.Drawing.Size(99, 16);
            this.lblYear1.TabIndex = 2;
            this.lblYear1.Text = "Năm bắt đầu:";
            // 
            // lblYear2
            // 
            this.lblYear2.AutoSize = true;
            this.lblYear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear2.Location = new System.Drawing.Point(46, 144);
            this.lblYear2.Name = "lblYear2";
            this.lblYear2.Size = new System.Drawing.Size(100, 16);
            this.lblYear2.TabIndex = 3;
            this.lblYear2.Text = "Năm kết thúc:";
            // 
            // btnBorn
            // 
            this.btnBorn.Location = new System.Drawing.Point(88, 192);
            this.btnBorn.Name = "btnBorn";
            this.btnBorn.Size = new System.Drawing.Size(92, 50);
            this.btnBorn.TabIndex = 2;
            this.btnBorn.Text = "Báo cáo tăng / giảm";
            this.btnBorn.UseVisualStyleBackColor = true;
            this.btnBorn.Click += new System.EventHandler(this.btnBorn_Click);
            // 
            // btnAchive
            // 
            this.btnAchive.Location = new System.Drawing.Point(367, 192);
            this.btnAchive.Name = "btnAchive";
            this.btnAchive.Size = new System.Drawing.Size(92, 50);
            this.btnAchive.TabIndex = 3;
            this.btnAchive.Text = "Báo cáo thành tích";
            this.btnAchive.UseVisualStyleBackColor = true;
            this.btnAchive.Click += new System.EventHandler(this.btnAchive_Click);
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.ForeColor = System.Drawing.Color.Red;
            this.lblReport.Location = new System.Drawing.Point(194, 26);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(159, 25);
            this.lblReport.TabIndex = 7;
            this.lblReport.Text = "LẬP BÁO CÁO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(293, 22);
            this.textBox2.TabIndex = 1;
            // 
            // dtgvReport
            // 
            this.dtgvReport.AllowUserToAddRows = false;
            this.dtgvReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgvReport.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dtgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReport.Location = new System.Drawing.Point(13, 271);
            this.dtgvReport.Name = "dtgvReport";
            this.dtgvReport.ReadOnly = true;
            this.dtgvReport.RowHeadersWidth = 51;
            this.dtgvReport.RowTemplate.Height = 24;
            this.dtgvReport.Size = new System.Drawing.Size(522, 388);
            this.dtgvReport.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(380, 678);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(112, 40);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Lưu báo cáo";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblReportName
            // 
            this.lblReportName.AutoSize = true;
            this.lblReportName.Location = new System.Drawing.Point(13, 690);
            this.lblReportName.Name = "lblReportName";
            this.lblReportName.Size = new System.Drawing.Size(77, 16);
            this.lblReportName.TabIndex = 12;
            this.lblReportName.Text = "Tên bản lưu";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(108, 687);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(265, 22);
            this.textBox3.TabIndex = 4;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(547, 742);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblReportName);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dtgvReport);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.btnAchive);
            this.Controls.Add(this.btnBorn);
            this.Controls.Add(this.lblYear2);
            this.Controls.Add(this.lblYear1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReport";
            this.Text = "fReport";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblYear1;
        private System.Windows.Forms.Label lblYear2;
        private System.Windows.Forms.Button btnBorn;
        private System.Windows.Forms.Button btnAchive;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dtgvReport;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblReportName;
    }
}