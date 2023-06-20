namespace New_DOAN
{
    partial class frmTown
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblReplace = new System.Windows.Forms.Label();
            this.lblFix = new System.Windows.Forms.Label();
            this.lblFixTown = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAddValue = new System.Windows.Forms.TextBox();
            this.lblAddValue = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(119, 250);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 47);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(242, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplace.Location = new System.Drawing.Point(58, 148);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(110, 16);
            this.lblReplace.TabIndex = 0;
            this.lblReplace.Text = "Giá trị thay thế:";
            // 
            // lblFix
            // 
            this.lblFix.AutoSize = true;
            this.lblFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFix.Location = new System.Drawing.Point(58, 99);
            this.lblFix.Name = "lblFix";
            this.lblFix.Size = new System.Drawing.Size(110, 16);
            this.lblFix.TabIndex = 0;
            this.lblFix.Text = "Giá trị cần sửa:";
            // 
            // lblFixTown
            // 
            this.lblFixTown.AutoSize = true;
            this.lblFixTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixTown.ForeColor = System.Drawing.Color.Red;
            this.lblFixTown.Location = new System.Drawing.Point(169, 35);
            this.lblFixTown.Name = "lblFixTown";
            this.lblFixTown.Size = new System.Drawing.Size(177, 25);
            this.lblFixTown.TabIndex = 0;
            this.lblFixTown.Text = "SỬA QUÊ QUÁN";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtAddValue
            // 
            this.txtAddValue.Location = new System.Drawing.Point(242, 198);
            this.txtAddValue.Name = "txtAddValue";
            this.txtAddValue.Size = new System.Drawing.Size(215, 22);
            this.txtAddValue.TabIndex = 2;
            // 
            // lblAddValue
            // 
            this.lblAddValue.AutoSize = true;
            this.lblAddValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddValue.Location = new System.Drawing.Point(58, 201);
            this.lblAddValue.Name = "lblAddValue";
            this.lblAddValue.Size = new System.Drawing.Size(118, 16);
            this.lblAddValue.TabIndex = 0;
            this.lblAddValue.Text = "Thêm quê quán:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(297, 250);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 47);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa quê quán";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmTown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(515, 321);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtAddValue);
            this.Controls.Add(this.lblAddValue);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.lblFix);
            this.Controls.Add(this.lblFixTown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTown";
            this.Text = "fTown";
            this.Load += new System.EventHandler(this.frmTown_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Label lblFix;
        private System.Windows.Forms.Label lblFixTown;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtAddValue;
        private System.Windows.Forms.Label lblAddValue;
        private System.Windows.Forms.Button btnDelete;
    }
}