﻿namespace New_DOAN
{
    partial class frmType
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
            this.lblFixType = new System.Windows.Forms.Label();
            this.lblFix = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAddValue = new System.Windows.Forms.Label();
            this.txtAddValue = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFixType
            // 
            this.lblFixType.AutoSize = true;
            this.lblFixType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixType.ForeColor = System.Drawing.Color.Red;
            this.lblFixType.Location = new System.Drawing.Point(125, 25);
            this.lblFixType.Name = "lblFixType";
            this.lblFixType.Size = new System.Drawing.Size(250, 25);
            this.lblFixType.TabIndex = 0;
            this.lblFixType.Text = "SỬA LOẠI THÀNH TÍCH";
            // 
            // lblFix
            // 
            this.lblFix.AutoSize = true;
            this.lblFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFix.Location = new System.Drawing.Point(51, 89);
            this.lblFix.Name = "lblFix";
            this.lblFix.Size = new System.Drawing.Size(110, 16);
            this.lblFix.TabIndex = 1;
            this.lblFix.Text = "Giá trị cần sửa:";
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplace.Location = new System.Drawing.Point(51, 139);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(110, 16);
            this.lblReplace.TabIndex = 2;
            this.lblReplace.Text = "Giá trị thay thế:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(235, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(98, 252);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 47);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblAddValue
            // 
            this.lblAddValue.AutoSize = true;
            this.lblAddValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddValue.Location = new System.Drawing.Point(51, 192);
            this.lblAddValue.Name = "lblAddValue";
            this.lblAddValue.Size = new System.Drawing.Size(149, 16);
            this.lblAddValue.TabIndex = 7;
            this.lblAddValue.Text = "Thêm loại thành tích:";
            this.lblAddValue.Click += new System.EventHandler(this.lblAddValue_Click);
            // 
            // txtAddValue
            // 
            this.txtAddValue.Location = new System.Drawing.Point(235, 189);
            this.txtAddValue.Name = "txtAddValue";
            this.txtAddValue.Size = new System.Drawing.Size(215, 22);
            this.txtAddValue.TabIndex = 2;
            this.txtAddValue.TextChanged += new System.EventHandler(this.txtAddValue_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(301, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 47);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa thành tích";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(500, 328);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtAddValue);
            this.Controls.Add(this.lblAddValue);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.lblFix);
            this.Controls.Add(this.lblFixType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmType";
            this.Text = "fType";
            this.Load += new System.EventHandler(this.frmType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFixType;
        private System.Windows.Forms.Label lblFix;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtAddValue;
        private System.Windows.Forms.Label lblAddValue;
        private System.Windows.Forms.Button btnDelete;
    }
}