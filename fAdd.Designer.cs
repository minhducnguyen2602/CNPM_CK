namespace New_DOAN
{
    partial class frmAdd
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
            this.btnAddMem = new System.Windows.Forms.Button();
            this.comboRelationship = new System.Windows.Forms.ComboBox();
            this.qUANHEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOAN8DataSet = new New_DOAN.DOAN8DataSet();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOccurred = new System.Windows.Forms.DateTimePicker();
            this.comboExistingMember = new System.Windows.Forms.ComboBox();
            this.tHANHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboJob = new System.Windows.Forms.ComboBox();
            this.nGHENGHIEPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblHometown = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblOccurrenceDate = new System.Windows.Forms.Label();
            this.lblRelationshipType = new System.Windows.Forms.Label();
            this.lblExistingMember = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.comboBoxQue = new System.Windows.Forms.ComboBox();
            this.qUEQUANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHANHVIENTableAdapter = new New_DOAN.DOAN8DataSetTableAdapters.THANHVIENTableAdapter();
            this.qUEQUANTableAdapter = new New_DOAN.DOAN8DataSetTableAdapters.QUEQUANTableAdapter();
            this.nGHENGHIEPTableAdapter = new New_DOAN.DOAN8DataSetTableAdapters.NGHENGHIEPTableAdapter();
            this.comboBoxGT = new System.Windows.Forms.ComboBox();
            this.qUANHETableAdapter = new New_DOAN.DOAN8DataSetTableAdapters.QUANHETableAdapter();
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qUANHEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAN8DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGHENGHIEPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUEQUANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddMem
            // 
            this.btnAddMem.Location = new System.Drawing.Point(212, 582);
            this.btnAddMem.Name = "btnAddMem";
            this.btnAddMem.Size = new System.Drawing.Size(75, 23);
            this.btnAddMem.TabIndex = 59;
            this.btnAddMem.Text = "Thêm";
            this.btnAddMem.UseVisualStyleBackColor = true;
            this.btnAddMem.Click += new System.EventHandler(this.btnAddMem_Click);
            // 
            // comboRelationship
            // 
            this.comboRelationship.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.qUANHEBindingSource, "LoaiQH", true));
            this.comboRelationship.DataSource = this.qUANHEBindingSource;
            this.comboRelationship.DisplayMember = "LoaiQH";
            this.comboRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRelationship.FormattingEnabled = true;
            this.comboRelationship.Location = new System.Drawing.Point(169, 129);
            this.comboRelationship.Name = "comboRelationship";
            this.comboRelationship.Size = new System.Drawing.Size(342, 24);
            this.comboRelationship.TabIndex = 56;
            this.comboRelationship.ValueMember = "LoaiQH";
            // 
            // qUANHEBindingSource
            // 
            this.qUANHEBindingSource.DataMember = "QUANHE";
            this.qUANHEBindingSource.DataSource = this.dOAN8DataSet;
            // 
            // dOAN8DataSet
            // 
            this.dOAN8DataSet.DataSetName = "DOAN8DataSet";
            this.dOAN8DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(169, 354);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(342, 22);
            this.dateTimePickerBirth.TabIndex = 55;
            // 
            // dateTimePickerOccurred
            // 
            this.dateTimePickerOccurred.Location = new System.Drawing.Point(169, 184);
            this.dateTimePickerOccurred.Name = "dateTimePickerOccurred";
            this.dateTimePickerOccurred.Size = new System.Drawing.Size(342, 22);
            this.dateTimePickerOccurred.TabIndex = 54;
            // 
            // comboExistingMember
            // 
            this.comboExistingMember.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tHANHVIENBindingSource, "HoTen", true));
            this.comboExistingMember.DataSource = this.tHANHVIENBindingSource;
            this.comboExistingMember.DisplayMember = "HoTen";
            this.comboExistingMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExistingMember.FormattingEnabled = true;
            this.comboExistingMember.Location = new System.Drawing.Point(169, 75);
            this.comboExistingMember.Name = "comboExistingMember";
            this.comboExistingMember.Size = new System.Drawing.Size(342, 24);
            this.comboExistingMember.TabIndex = 53;
            this.comboExistingMember.ValueMember = "HoTen";
            // 
            // tHANHVIENBindingSource
            // 
            this.tHANHVIENBindingSource.DataMember = "THANHVIEN";
            this.tHANHVIENBindingSource.DataSource = this.dOAN8DataSet;
            // 
            // comboJob
            // 
            this.comboJob.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nGHENGHIEPBindingSource, "TenNN", true));
            this.comboJob.DataSource = this.nGHENGHIEPBindingSource;
            this.comboJob.DisplayMember = "TenNN";
            this.comboJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboJob.FormattingEnabled = true;
            this.comboJob.Location = new System.Drawing.Point(169, 515);
            this.comboJob.Name = "comboJob";
            this.comboJob.Size = new System.Drawing.Size(342, 24);
            this.comboJob.TabIndex = 52;
            this.comboJob.ValueMember = "TenNN";
            // 
            // nGHENGHIEPBindingSource
            // 
            this.nGHENGHIEPBindingSource.DataMember = "NGHENGHIEP";
            this.nGHENGHIEPBindingSource.DataSource = this.dOAN8DataSet;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(169, 462);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(342, 22);
            this.txtAddress.TabIndex = 51;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(169, 238);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(342, 22);
            this.txtFullName.TabIndex = 49;
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupation.Location = new System.Drawing.Point(30, 521);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(99, 16);
            this.lblOccupation.TabIndex = 48;
            this.lblOccupation.Text = "Nghề nghiệp:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(30, 467);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 47;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // lblHometown
            // 
            this.lblHometown.AutoSize = true;
            this.lblHometown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHometown.Location = new System.Drawing.Point(30, 413);
            this.lblHometown.Name = "lblHometown";
            this.lblHometown.Size = new System.Drawing.Size(77, 16);
            this.lblHometown.TabIndex = 46;
            this.lblHometown.Text = "Quê quán:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(30, 359);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(80, 16);
            this.lblBirthDate.TabIndex = 45;
            this.lblBirthDate.Text = "Ngày sinh:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(30, 305);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(67, 16);
            this.lblGender.TabIndex = 44;
            this.lblGender.Text = "Giới tính:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(30, 243);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(77, 16);
            this.lblFullName.TabIndex = 43;
            this.lblFullName.Text = "Họ và tên:";
            // 
            // lblOccurrenceDate
            // 
            this.lblOccurrenceDate.AutoSize = true;
            this.lblOccurrenceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccurrenceDate.Location = new System.Drawing.Point(30, 189);
            this.lblOccurrenceDate.Name = "lblOccurrenceDate";
            this.lblOccurrenceDate.Size = new System.Drawing.Size(114, 16);
            this.lblOccurrenceDate.TabIndex = 42;
            this.lblOccurrenceDate.Text = "Ngày phát sinh:";
            // 
            // lblRelationshipType
            // 
            this.lblRelationshipType.AutoSize = true;
            this.lblRelationshipType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelationshipType.Location = new System.Drawing.Point(30, 135);
            this.lblRelationshipType.Name = "lblRelationshipType";
            this.lblRelationshipType.Size = new System.Drawing.Size(100, 16);
            this.lblRelationshipType.TabIndex = 41;
            this.lblRelationshipType.Text = "Loại quan hệ:";
            // 
            // lblExistingMember
            // 
            this.lblExistingMember.AutoSize = true;
            this.lblExistingMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistingMember.Location = new System.Drawing.Point(30, 81);
            this.lblExistingMember.Name = "lblExistingMember";
            this.lblExistingMember.Size = new System.Drawing.Size(122, 16);
            this.lblExistingMember.TabIndex = 40;
            this.lblExistingMember.Text = "Mã thành viên cũ";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.Red;
            this.lblAdd.Location = new System.Drawing.Point(166, 25);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(209, 25);
            this.lblAdd.TabIndex = 60;
            this.lblAdd.Text = "THÊM THÀNH VIÊN";
            // 
            // comboBoxQue
            // 
            this.comboBoxQue.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.qUEQUANBindingSource, "TenQueQuan", true));
            this.comboBoxQue.DataSource = this.qUEQUANBindingSource;
            this.comboBoxQue.DisplayMember = "TenQueQuan";
            this.comboBoxQue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQue.FormattingEnabled = true;
            this.comboBoxQue.Location = new System.Drawing.Point(169, 409);
            this.comboBoxQue.Name = "comboBoxQue";
            this.comboBoxQue.Size = new System.Drawing.Size(342, 24);
            this.comboBoxQue.TabIndex = 61;
            this.comboBoxQue.ValueMember = "TenQueQuan";
            // 
            // qUEQUANBindingSource
            // 
            this.qUEQUANBindingSource.DataMember = "QUEQUAN";
            this.qUEQUANBindingSource.DataSource = this.dOAN8DataSet;
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
            this.comboBoxGT.Location = new System.Drawing.Point(171, 299);
            this.comboBoxGT.Name = "comboBoxGT";
            this.comboBoxGT.Size = new System.Drawing.Size(339, 24);
            this.comboBoxGT.TabIndex = 62;
            this.comboBoxGT.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // qUANHETableAdapter
            // 
            this.qUANHETableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(540, 624);
            this.Controls.Add(this.comboBoxGT);
            this.Controls.Add(this.comboBoxQue);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnAddMem);
            this.Controls.Add(this.comboRelationship);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.dateTimePickerOccurred);
            this.Controls.Add(this.comboExistingMember);
            this.Controls.Add(this.comboJob);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblOccupation);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblHometown);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblOccurrenceDate);
            this.Controls.Add(this.lblRelationshipType);
            this.Controls.Add(this.lblExistingMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdd";
            this.Text = "Thêm thành viên";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qUANHEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAN8DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGHENGHIEPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUEQUANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMem;
        private System.Windows.Forms.ComboBox comboRelationship;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.DateTimePicker dateTimePickerOccurred;
        private System.Windows.Forms.ComboBox comboExistingMember;
        private System.Windows.Forms.ComboBox comboJob;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblHometown;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblOccurrenceDate;
        private System.Windows.Forms.Label lblRelationshipType;
        private System.Windows.Forms.Label lblExistingMember;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.ComboBox comboBoxQue;
        private DOAN8DataSet dOAN8DataSet;
        private System.Windows.Forms.BindingSource tHANHVIENBindingSource;
        private DOAN8DataSetTableAdapters.THANHVIENTableAdapter tHANHVIENTableAdapter;
        private System.Windows.Forms.BindingSource qUEQUANBindingSource;
        private DOAN8DataSetTableAdapters.QUEQUANTableAdapter qUEQUANTableAdapter;
        private System.Windows.Forms.BindingSource nGHENGHIEPBindingSource;
        private DOAN8DataSetTableAdapters.NGHENGHIEPTableAdapter nGHENGHIEPTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxGT;
        private System.Windows.Forms.BindingSource qUANHEBindingSource;
        private DOAN8DataSetTableAdapters.QUANHETableAdapter qUANHETableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider5;
    }
}