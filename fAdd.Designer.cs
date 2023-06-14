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
            this.btnAddMem = new System.Windows.Forms.Button();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.comboRelationship = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOccurred = new System.Windows.Forms.DateTimePicker();
            this.comboExistingMember = new System.Windows.Forms.ComboBox();
            this.comboJob = new System.Windows.Forms.ComboBox();
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
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(330, 301);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(45, 20);
            this.radFemale.TabIndex = 58;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Nữ";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(186, 301);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(57, 20);
            this.radMale.TabIndex = 57;
            this.radMale.TabStop = true;
            this.radMale.Text = "Nam";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // comboRelationship
            // 
            this.comboRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRelationship.FormattingEnabled = true;
            this.comboRelationship.Items.AddRange(new object[] {
            "Vợ / Chồng",
            "Con"});
            this.comboRelationship.Location = new System.Drawing.Point(169, 129);
            this.comboRelationship.Name = "comboRelationship";
            this.comboRelationship.Size = new System.Drawing.Size(342, 24);
            this.comboRelationship.TabIndex = 56;
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
            this.comboExistingMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExistingMember.FormattingEnabled = true;
            this.comboExistingMember.Location = new System.Drawing.Point(169, 75);
            this.comboExistingMember.Name = "comboExistingMember";
            this.comboExistingMember.Size = new System.Drawing.Size(342, 24);
            this.comboExistingMember.TabIndex = 53;
            // 
            // comboJob
            // 
            this.comboJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboJob.FormattingEnabled = true;
            this.comboJob.Items.AddRange(new object[] {
            "Sinh viên"});
            this.comboJob.Location = new System.Drawing.Point(169, 515);
            this.comboJob.Name = "comboJob";
            this.comboJob.Size = new System.Drawing.Size(342, 24);
            this.comboJob.TabIndex = 52;
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
            this.lblExistingMember.Size = new System.Drawing.Size(107, 16);
            this.lblExistingMember.TabIndex = 40;
            this.lblExistingMember.Text = "Thành viên cũ:";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.Blue;
            this.lblAdd.Location = new System.Drawing.Point(166, 25);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(209, 25);
            this.lblAdd.TabIndex = 60;
            this.lblAdd.Text = "THÊM THÀNH VIÊN";
            // 
            // comboBoxQue
            // 
            this.comboBoxQue.FormattingEnabled = true;
            this.comboBoxQue.Location = new System.Drawing.Point(169, 409);
            this.comboBoxQue.Name = "comboBoxQue";
            this.comboBoxQue.Size = new System.Drawing.Size(342, 24);
            this.comboBoxQue.TabIndex = 61;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 624);
            this.Controls.Add(this.comboBoxQue);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnAddMem);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMem;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
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
    }
}