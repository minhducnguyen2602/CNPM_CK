﻿namespace New_DOAN
{
    partial class frmAchive
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
            this.lblAchive = new System.Windows.Forms.Label();
            this.lblAchiveName = new System.Windows.Forms.Label();
            this.lblAchiveType = new System.Windows.Forms.Label();
            this.lblAchiveDate = new System.Windows.Forms.Label();
            this.comboAchiveName = new System.Windows.Forms.ComboBox();
            this.comboAchiveType = new System.Windows.Forms.ComboBox();
            this.btnAchive = new System.Windows.Forms.Button();
            this.dateTimePickerAchive = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblAchive
            // 
            this.lblAchive.AutoSize = true;
            this.lblAchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchive.ForeColor = System.Drawing.Color.Blue;
            this.lblAchive.Location = new System.Drawing.Point(163, 24);
            this.lblAchive.Name = "lblAchive";
            this.lblAchive.Size = new System.Drawing.Size(210, 25);
            this.lblAchive.TabIndex = 0;
            this.lblAchive.Text = "THÊM THÀNH TÍCH";
            // 
            // lblAchiveName
            // 
            this.lblAchiveName.AutoSize = true;
            this.lblAchiveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchiveName.Location = new System.Drawing.Point(50, 83);
            this.lblAchiveName.Name = "lblAchiveName";
            this.lblAchiveName.Size = new System.Drawing.Size(77, 16);
            this.lblAchiveName.TabIndex = 1;
            this.lblAchiveName.Text = "Họ và tên:";
            // 
            // lblAchiveType
            // 
            this.lblAchiveType.AutoSize = true;
            this.lblAchiveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchiveType.Location = new System.Drawing.Point(50, 154);
            this.lblAchiveType.Name = "lblAchiveType";
            this.lblAchiveType.Size = new System.Drawing.Size(110, 16);
            this.lblAchiveType.TabIndex = 2;
            this.lblAchiveType.Text = "Loại thành tích:";
            // 
            // lblAchiveDate
            // 
            this.lblAchiveDate.AutoSize = true;
            this.lblAchiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchiveDate.Location = new System.Drawing.Point(50, 225);
            this.lblAchiveDate.Name = "lblAchiveDate";
            this.lblAchiveDate.Size = new System.Drawing.Size(114, 16);
            this.lblAchiveDate.TabIndex = 3;
            this.lblAchiveDate.Text = "Ngày phát sinh:";
            // 
            // comboAchiveName
            // 
            this.comboAchiveName.FormattingEnabled = true;
            this.comboAchiveName.Location = new System.Drawing.Point(197, 79);
            this.comboAchiveName.Name = "comboAchiveName";
            this.comboAchiveName.Size = new System.Drawing.Size(299, 24);
            this.comboAchiveName.TabIndex = 4;
            this.comboAchiveName.SelectedIndexChanged += new System.EventHandler(this.comboAchiveName_SelectedIndexChanged);
            // 
            // comboAchiveType
            // 
            this.comboAchiveType.FormattingEnabled = true;
            this.comboAchiveType.Location = new System.Drawing.Point(197, 150);
            this.comboAchiveType.Name = "comboAchiveType";
            this.comboAchiveType.Size = new System.Drawing.Size(299, 24);
            this.comboAchiveType.TabIndex = 5;
            // 
            // btnAchive
            // 
            this.btnAchive.Location = new System.Drawing.Point(212, 284);
            this.btnAchive.Name = "btnAchive";
            this.btnAchive.Size = new System.Drawing.Size(75, 23);
            this.btnAchive.TabIndex = 7;
            this.btnAchive.Text = "Thêm";
            this.btnAchive.UseVisualStyleBackColor = true;
            this.btnAchive.Click += new System.EventHandler(this.btnAchive_Click);
            // 
            // dateTimePickerAchive
            // 
            this.dateTimePickerAchive.Location = new System.Drawing.Point(197, 222);
            this.dateTimePickerAchive.Name = "dateTimePickerAchive";
            this.dateTimePickerAchive.Size = new System.Drawing.Size(299, 22);
            this.dateTimePickerAchive.TabIndex = 8;
            // 
            // frmAchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 333);
            this.Controls.Add(this.dateTimePickerAchive);
            this.Controls.Add(this.btnAchive);
            this.Controls.Add(this.comboAchiveType);
            this.Controls.Add(this.comboAchiveName);
            this.Controls.Add(this.lblAchiveDate);
            this.Controls.Add(this.lblAchiveType);
            this.Controls.Add(this.lblAchiveName);
            this.Controls.Add(this.lblAchive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAchive";
            this.Text = "fAchive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAchive;
        private System.Windows.Forms.Label lblAchiveName;
        private System.Windows.Forms.Label lblAchiveType;
        private System.Windows.Forms.Label lblAchiveDate;
        private System.Windows.Forms.ComboBox comboAchiveName;
        private System.Windows.Forms.ComboBox comboAchiveType;
        private System.Windows.Forms.Button btnAchive;
        private System.Windows.Forms.DateTimePicker dateTimePickerAchive;
    }
}