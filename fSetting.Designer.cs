namespace New_DOAN
{
    partial class frmSetting
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.comboMaTV = new System.Windows.Forms.ComboBox();
            this.tHANHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOAN8DataSet = new New_DOAN.DOAN8DataSet();
            this.comboMemberJob = new System.Windows.Forms.ComboBox();
            this.nGHENGHIEPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboTown = new System.Windows.Forms.ComboBox();
            this.qUEQUANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.tHANHVIENTableAdapter = new New_DOAN.DOAN8DataSetTableAdapters.THANHVIENTableAdapter();
            this.qUEQUANTableAdapter = new New_DOAN.DOAN8DataSetTableAdapters.QUEQUANTableAdapter();
            this.nGHENGHIEPTableAdapter = new New_DOAN.DOAN8DataSetTableAdapters.NGHENGHIEPTableAdapter();
            this.lblMaTV = new System.Windows.Forms.Label();
            this.comboExistingMember = new System.Windows.Forms.ComboBox();
            this.lblExistingMember = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.comboRelationship = new System.Windows.Forms.ComboBox();
            this.lblRelationshipType = new System.Windows.Forms.Label();
            this.comboBoxGT = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dateTimePickerphatsinh = new System.Windows.Forms.DateTimePicker();
            this.lblOccurrenceDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAN8DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGHENGHIEPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUEQUANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(148, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(238, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THAY ĐỔI THÔNG TIN";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.Location = new System.Drawing.Point(39, 415);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(99, 16);
            this.lblJob.TabIndex = 1;
            this.lblJob.Text = "Nghề nghiệp:";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(39, 468);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(77, 16);
            this.lblTown.TabIndex = 3;
            this.lblTown.Text = "Quê quán:";
            // 
            // comboMaTV
            // 
            this.comboMaTV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tHANHVIENBindingSource, "MaTV", true));
            this.comboMaTV.DataSource = this.tHANHVIENBindingSource;
            this.comboMaTV.DisplayMember = "MaTV";
            this.comboMaTV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMaTV.FormattingEnabled = true;
            this.comboMaTV.Location = new System.Drawing.Point(211, 55);
            this.comboMaTV.Name = "comboMaTV";
            this.comboMaTV.Size = new System.Drawing.Size(280, 24);
            this.comboMaTV.TabIndex = 4;
            this.comboMaTV.ValueMember = "MaTV";
            this.comboMaTV.SelectedIndexChanged += new System.EventHandler(this.comboMaTV_SelectedIndexChanged_1);
            // 
            // tHANHVIENBindingSource
            // 
            this.tHANHVIENBindingSource.DataMember = "THANHVIEN";
            this.tHANHVIENBindingSource.DataSource = this.dOAN8DataSet;
            // 
            // dOAN8DataSet
            // 
            this.dOAN8DataSet.DataSetName = "DOAN8DataSet";
            this.dOAN8DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboMemberJob
            // 
            this.comboMemberJob.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nGHENGHIEPBindingSource, "TenNN", true));
            this.comboMemberJob.DataSource = this.nGHENGHIEPBindingSource;
            this.comboMemberJob.DisplayMember = "TenNN";
            this.comboMemberJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMemberJob.FormattingEnabled = true;
            this.comboMemberJob.Location = new System.Drawing.Point(211, 411);
            this.comboMemberJob.Name = "comboMemberJob";
            this.comboMemberJob.Size = new System.Drawing.Size(280, 24);
            this.comboMemberJob.TabIndex = 5;
            this.comboMemberJob.ValueMember = "TenNN";
            // 
            // nGHENGHIEPBindingSource
            // 
            this.nGHENGHIEPBindingSource.DataMember = "NGHENGHIEP";
            this.nGHENGHIEPBindingSource.DataSource = this.dOAN8DataSet;
            // 
            // comboTown
            // 
            this.comboTown.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.qUEQUANBindingSource, "TenQueQuan", true));
            this.comboTown.DataSource = this.qUEQUANBindingSource;
            this.comboTown.DisplayMember = "TenQueQuan";
            this.comboTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTown.FormattingEnabled = true;
            this.comboTown.Location = new System.Drawing.Point(211, 464);
            this.comboTown.Name = "comboTown";
            this.comboTown.Size = new System.Drawing.Size(280, 24);
            this.comboTown.TabIndex = 6;
            this.comboTown.ValueMember = "TenQueQuan";
            // 
            // qUEQUANBindingSource
            // 
            this.qUEQUANBindingSource.DataMember = "QUEQUAN";
            this.qUEQUANBindingSource.DataSource = this.dOAN8DataSet;
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Location = new System.Drawing.Point(204, 573);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(123, 36);
            this.btnUpdateMember.TabIndex = 7;
            this.btnUpdateMember.Text = "Thay đổi";
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            this.btnUpdateMember.Click += new System.EventHandler(this.button1_Click);
            // 
            // tHANHVIENTableAdapter
            // 
            this.tHANHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // qUEQUANTableAdapter
            // 
            this.qUEQUANTableAdapter.ClearBeforeFill = true;
            // 
            // nGHENGHIEPTableAdapter
            // 
            this.nGHENGHIEPTableAdapter.ClearBeforeFill = true;
            // 
            // lblMaTV
            // 
            this.lblMaTV.AutoSize = true;
            this.lblMaTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTV.Location = new System.Drawing.Point(39, 59);
            this.lblMaTV.Name = "lblMaTV";
            this.lblMaTV.Size = new System.Drawing.Size(102, 16);
            this.lblMaTV.TabIndex = 2;
            this.lblMaTV.Text = "Mã thành viên";
            // 
            // comboExistingMember
            // 
            this.comboExistingMember.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tHANHVIENBindingSource, "HoTen", true));
            this.comboExistingMember.DataSource = this.tHANHVIENBindingSource;
            this.comboExistingMember.DisplayMember = "HoTen";
            this.comboExistingMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExistingMember.FormattingEnabled = true;
            this.comboExistingMember.Location = new System.Drawing.Point(211, 108);
            this.comboExistingMember.Name = "comboExistingMember";
            this.comboExistingMember.Size = new System.Drawing.Size(280, 24);
            this.comboExistingMember.TabIndex = 55;
            this.comboExistingMember.ValueMember = "HoTen";
            // 
            // lblExistingMember
            // 
            this.lblExistingMember.AutoSize = true;
            this.lblExistingMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistingMember.Location = new System.Drawing.Point(39, 112);
            this.lblExistingMember.Name = "lblExistingMember";
            this.lblExistingMember.Size = new System.Drawing.Size(122, 16);
            this.lblExistingMember.TabIndex = 54;
            this.lblExistingMember.Text = "Mã thành viên cũ";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(211, 253);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(280, 22);
            this.txtFullName.TabIndex = 57;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(39, 256);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(77, 16);
            this.lblFullName.TabIndex = 56;
            this.lblFullName.Text = "Họ và tên:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(211, 518);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(280, 22);
            this.txtAddress.TabIndex = 66;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(39, 521);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 65;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // comboRelationship
            // 
            this.comboRelationship.DisplayMember = "LoaiQH";
            this.comboRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRelationship.FormattingEnabled = true;
            this.comboRelationship.Location = new System.Drawing.Point(211, 161);
            this.comboRelationship.Name = "comboRelationship";
            this.comboRelationship.Size = new System.Drawing.Size(280, 24);
            this.comboRelationship.TabIndex = 70;
            this.comboRelationship.ValueMember = "LoaiQH";
            // 
            // lblRelationshipType
            // 
            this.lblRelationshipType.AutoSize = true;
            this.lblRelationshipType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelationshipType.Location = new System.Drawing.Point(39, 165);
            this.lblRelationshipType.Name = "lblRelationshipType";
            this.lblRelationshipType.Size = new System.Drawing.Size(100, 16);
            this.lblRelationshipType.TabIndex = 69;
            this.lblRelationshipType.Text = "Loại quan hệ:";
            // 
            // comboBoxGT
            // 
            this.comboBoxGT.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBoxGT.AllowDrop = true;
            this.comboBoxGT.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam"});
            this.comboBoxGT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxGT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGT.FormattingEnabled = true;
            this.comboBoxGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBoxGT.Location = new System.Drawing.Point(211, 305);
            this.comboBoxGT.Name = "comboBoxGT";
            this.comboBoxGT.Size = new System.Drawing.Size(280, 24);
            this.comboBoxGT.TabIndex = 72;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(39, 309);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(67, 16);
            this.lblGender.TabIndex = 71;
            this.lblGender.Text = "Giới tính:";
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(211, 359);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(280, 22);
            this.dateTimePickerBirth.TabIndex = 74;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(39, 362);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(80, 16);
            this.lblBirthDate.TabIndex = 73;
            this.lblBirthDate.Text = "Ngày sinh:";
            // 
            // dateTimePickerphatsinh
            // 
            this.dateTimePickerphatsinh.Location = new System.Drawing.Point(211, 205);
            this.dateTimePickerphatsinh.Name = "dateTimePickerphatsinh";
            this.dateTimePickerphatsinh.Size = new System.Drawing.Size(280, 22);
            this.dateTimePickerphatsinh.TabIndex = 76;
            // 
            // lblOccurrenceDate
            // 
            this.lblOccurrenceDate.AutoSize = true;
            this.lblOccurrenceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccurrenceDate.Location = new System.Drawing.Point(39, 211);
            this.lblOccurrenceDate.Name = "lblOccurrenceDate";
            this.lblOccurrenceDate.Size = new System.Drawing.Size(114, 16);
            this.lblOccurrenceDate.TabIndex = 75;
            this.lblOccurrenceDate.Text = "Ngày phát sinh:";
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(530, 623);
            this.Controls.Add(this.dateTimePickerphatsinh);
            this.Controls.Add(this.lblOccurrenceDate);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.comboBoxGT);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.comboRelationship);
            this.Controls.Add(this.lblRelationshipType);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.comboExistingMember);
            this.Controls.Add(this.lblExistingMember);
            this.Controls.Add(this.btnUpdateMember);
            this.Controls.Add(this.comboTown);
            this.Controls.Add(this.comboMemberJob);
            this.Controls.Add(this.comboMaTV);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblMaTV);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetting";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tHANHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAN8DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGHENGHIEPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUEQUANBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.ComboBox comboMaTV;
        private System.Windows.Forms.ComboBox comboMemberJob;
        private System.Windows.Forms.ComboBox comboTown;
        private System.Windows.Forms.Button btnUpdateMember;
        private DOAN8DataSet dOAN8DataSet;
        private System.Windows.Forms.BindingSource tHANHVIENBindingSource;
        private DOAN8DataSetTableAdapters.THANHVIENTableAdapter tHANHVIENTableAdapter;
        private System.Windows.Forms.BindingSource qUEQUANBindingSource;
        private DOAN8DataSetTableAdapters.QUEQUANTableAdapter qUEQUANTableAdapter;
        private System.Windows.Forms.BindingSource nGHENGHIEPBindingSource;
        private DOAN8DataSetTableAdapters.NGHENGHIEPTableAdapter nGHENGHIEPTableAdapter;
        private System.Windows.Forms.Label lblMaTV;
        private System.Windows.Forms.ComboBox comboExistingMember;
        private System.Windows.Forms.Label lblExistingMember;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox comboRelationship;
        private System.Windows.Forms.Label lblRelationshipType;
        private System.Windows.Forms.ComboBox comboBoxGT;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerphatsinh;
        private System.Windows.Forms.Label lblOccurrenceDate;
    }
}