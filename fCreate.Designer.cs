namespace New_DOAN
{
    partial class frmCreate
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
            this.lblCreate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.datBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblHometown = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.comboJob = new System.Windows.Forms.ComboBox();
            this.nGHENGHIEPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testingDataSet6 = new New_DOAN.testingDataSet6();
            this.comboBoxQue = new System.Windows.Forms.ComboBox();
            this.nGHENGHIEPTableAdapter = new New_DOAN.testingDataSet6TableAdapters.NGHENGHIEPTableAdapter();
            this.lblPSINH = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nGHENGHIEPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreate.ForeColor = System.Drawing.Color.Red;
            this.lblCreate.Location = new System.Drawing.Point(161, 33);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(253, 32);
            this.lblCreate.TabIndex = 38;
            this.lblCreate.Text = "TẠO HỒ SƠ GỐC";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(181, 155);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(366, 22);
            this.txtName.TabIndex = 37;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(27, 158);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 16);
            this.lblName.TabIndex = 36;
            this.lblName.Text = "Họ và tên:";
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(221, 444);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(132, 50);
            this.btnGetInfo.TabIndex = 35;
            this.btnGetInfo.Text = "Tạo tài khoản";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(181, 390);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(366, 22);
            this.txtAddress.TabIndex = 34;
            // 
            // datBirthday
            // 
            this.datBirthday.Location = new System.Drawing.Point(181, 199);
            this.datBirthday.Name = "datBirthday";
            this.datBirthday.Size = new System.Drawing.Size(366, 22);
            this.datBirthday.TabIndex = 29;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(27, 205);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(80, 16);
            this.lblBirthday.TabIndex = 26;
            this.lblBirthday.Text = "Ngày sinh:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(27, 252);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(67, 16);
            this.lblSex.TabIndex = 25;
            this.lblSex.Text = "Giới tính:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(27, 393);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // lblHometown
            // 
            this.lblHometown.AutoSize = true;
            this.lblHometown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHometown.Location = new System.Drawing.Point(27, 346);
            this.lblHometown.Name = "lblHometown";
            this.lblHometown.Size = new System.Drawing.Size(77, 16);
            this.lblHometown.TabIndex = 23;
            this.lblHometown.Text = "Quê quán:";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.Location = new System.Drawing.Point(27, 299);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(99, 16);
            this.lblJob.TabIndex = 22;
            this.lblJob.Text = "Nghề nghiệp:";
            // 
            // comboJob
            // 
            this.comboJob.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nGHENGHIEPBindingSource, "TenNN", true));
            this.comboJob.DataSource = this.nGHENGHIEPBindingSource;
            this.comboJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboJob.FormattingEnabled = true;
            this.comboJob.Location = new System.Drawing.Point(181, 295);
            this.comboJob.Name = "comboJob";
            this.comboJob.Size = new System.Drawing.Size(366, 24);
            this.comboJob.TabIndex = 39;
            // 
            // nGHENGHIEPBindingSource
            // 
            this.nGHENGHIEPBindingSource.DataMember = "NGHENGHIEP";
            this.nGHENGHIEPBindingSource.DataSource = this.testingDataSet6;
            // 
            // testingDataSet6
            // 
            this.testingDataSet6.DataSetName = "testingDataSet6";
            this.testingDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxQue
            // 
            this.comboBoxQue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQue.FormattingEnabled = true;
            this.comboBoxQue.Location = new System.Drawing.Point(181, 342);
            this.comboBoxQue.Name = "comboBoxQue";
            this.comboBoxQue.Size = new System.Drawing.Size(366, 24);
            this.comboBoxQue.TabIndex = 40;
            // 
            // nGHENGHIEPTableAdapter
            // 
            this.nGHENGHIEPTableAdapter.ClearBeforeFill = true;
            // 
            // lblPSINH
            // 
            this.lblPSINH.AutoSize = true;
            this.lblPSINH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSINH.Location = new System.Drawing.Point(30, 105);
            this.lblPSINH.Name = "lblPSINH";
            this.lblPSINH.Size = new System.Drawing.Size(114, 16);
            this.lblPSINH.TabIndex = 41;
            this.lblPSINH.Text = "Ngày phát sinh:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(366, 22);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox1.Location = new System.Drawing.Point(179, 247);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(367, 24);
            this.comboBox1.TabIndex = 43;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(574, 511);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblPSINH);
            this.Controls.Add(this.comboBoxQue);
            this.Controls.Add(this.comboJob);
            this.Controls.Add(this.lblCreate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.datBirthday);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblHometown);
            this.Controls.Add(this.lblJob);
            this.Name = "frmCreate";
            this.Text = "Tạo hồ sơ";
            this.Load += new System.EventHandler(this.frmCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nGHENGHIEPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker datBirthday;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblHometown;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.ComboBox comboJob;
        private System.Windows.Forms.ComboBox comboBoxQue;
        private testingDataSet6 testingDataSet6;
        private System.Windows.Forms.BindingSource nGHENGHIEPBindingSource;
        private testingDataSet6TableAdapters.NGHENGHIEPTableAdapter nGHENGHIEPTableAdapter;
        private System.Windows.Forms.Label lblPSINH;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}