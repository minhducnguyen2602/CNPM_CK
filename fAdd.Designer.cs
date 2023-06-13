namespace DOANCNPM_1
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
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.comboRelationship = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOccurred = new System.Windows.Forms.DateTimePicker();
            this.comboExistingMember = new System.Windows.Forms.ComboBox();
            this.comboJob = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtHometown = new System.Windows.Forms.TextBox();
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
            this.btnAddMem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(399, 213);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(45, 20);
            this.radFemale.TabIndex = 38;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Nữ";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(255, 215);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(57, 20);
            this.radMale.TabIndex = 37;
            this.radMale.TabStop = true;
            this.radMale.Text = "Nam";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // comboRelationship
            // 
            this.comboRelationship.FormattingEnabled = true;
            this.comboRelationship.Items.AddRange(new object[] {
            "Vợ / Chồng",
            "Con"});
            this.comboRelationship.Location = new System.Drawing.Point(238, 98);
            this.comboRelationship.Name = "comboRelationship";
            this.comboRelationship.Size = new System.Drawing.Size(277, 24);
            this.comboRelationship.TabIndex = 36;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(238, 248);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(277, 22);
            this.dateTimePickerBirth.TabIndex = 35;
            // 
            // dateTimePickerOccurred
            // 
            this.dateTimePickerOccurred.Location = new System.Drawing.Point(238, 132);
            this.dateTimePickerOccurred.Name = "dateTimePickerOccurred";
            this.dateTimePickerOccurred.Size = new System.Drawing.Size(277, 22);
            this.dateTimePickerOccurred.TabIndex = 34;
            // 
            // comboExistingMember
            // 
            this.comboExistingMember.FormattingEnabled = true;
            this.comboExistingMember.Location = new System.Drawing.Point(238, 63);
            this.comboExistingMember.Name = "comboExistingMember";
            this.comboExistingMember.Size = new System.Drawing.Size(277, 24);
            this.comboExistingMember.TabIndex = 33;
            // 
            // comboJob
            // 
            this.comboJob.FormattingEnabled = true;
            this.comboJob.Items.AddRange(new object[] {
            "Sinh viên"});
            this.comboJob.Location = new System.Drawing.Point(238, 364);
            this.comboJob.Name = "comboJob";
            this.comboJob.Size = new System.Drawing.Size(277, 24);
            this.comboJob.TabIndex = 32;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(238, 323);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(277, 22);
            this.txtAddress.TabIndex = 31;
            // 
            // txtHometown
            // 
            this.txtHometown.Location = new System.Drawing.Point(238, 291);
            this.txtHometown.Name = "txtHometown";
            this.txtHometown.Size = new System.Drawing.Size(277, 22);
            this.txtHometown.TabIndex = 30;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(238, 170);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(277, 22);
            this.txtFullName.TabIndex = 29;
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupation.Location = new System.Drawing.Point(77, 368);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(99, 16);
            this.lblOccupation.TabIndex = 28;
            this.lblOccupation.Text = "Nghề nghiệp:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(77, 330);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 27;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // lblHometown
            // 
            this.lblHometown.AutoSize = true;
            this.lblHometown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHometown.Location = new System.Drawing.Point(77, 292);
            this.lblHometown.Name = "lblHometown";
            this.lblHometown.Size = new System.Drawing.Size(77, 16);
            this.lblHometown.TabIndex = 26;
            this.lblHometown.Text = "Quê quán:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(77, 254);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(80, 16);
            this.lblBirthDate.TabIndex = 25;
            this.lblBirthDate.Text = "Ngày sinh:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(77, 216);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(67, 16);
            this.lblGender.TabIndex = 24;
            this.lblGender.Text = "Giới tính:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(77, 178);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(77, 16);
            this.lblFullName.TabIndex = 23;
            this.lblFullName.Text = "Họ và tên:";
            // 
            // lblOccurrenceDate
            // 
            this.lblOccurrenceDate.AutoSize = true;
            this.lblOccurrenceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccurrenceDate.Location = new System.Drawing.Point(77, 140);
            this.lblOccurrenceDate.Name = "lblOccurrenceDate";
            this.lblOccurrenceDate.Size = new System.Drawing.Size(114, 16);
            this.lblOccurrenceDate.TabIndex = 22;
            this.lblOccurrenceDate.Text = "Ngày phát sinh:";
            // 
            // lblRelationshipType
            // 
            this.lblRelationshipType.AutoSize = true;
            this.lblRelationshipType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelationshipType.Location = new System.Drawing.Point(77, 102);
            this.lblRelationshipType.Name = "lblRelationshipType";
            this.lblRelationshipType.Size = new System.Drawing.Size(100, 16);
            this.lblRelationshipType.TabIndex = 21;
            this.lblRelationshipType.Text = "Loại quan hệ:";
            // 
            // lblExistingMember
            // 
            this.lblExistingMember.AutoSize = true;
            this.lblExistingMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistingMember.Location = new System.Drawing.Point(77, 64);
            this.lblExistingMember.Name = "lblExistingMember";
            this.lblExistingMember.Size = new System.Drawing.Size(107, 16);
            this.lblExistingMember.TabIndex = 20;
            this.lblExistingMember.Text = "Thành viên cũ:";
            // 
            // btnAddMem
            // 
            this.btnAddMem.Location = new System.Drawing.Point(255, 421);
            this.btnAddMem.Name = "btnAddMem";
            this.btnAddMem.Size = new System.Drawing.Size(75, 23);
            this.btnAddMem.TabIndex = 39;
            this.btnAddMem.Text = "Thêm";
            this.btnAddMem.UseVisualStyleBackColor = true;
            this.btnAddMem.Click += new System.EventHandler(this.btnAddMem_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 463);
            this.Controls.Add(this.btnAddMem);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.comboRelationship);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.dateTimePickerOccurred);
            this.Controls.Add(this.comboExistingMember);
            this.Controls.Add(this.comboJob);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtHometown);
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
            this.Name = "frmAdd";
            this.Text = "Thêm thành viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.ComboBox comboRelationship;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.DateTimePicker dateTimePickerOccurred;
        private System.Windows.Forms.ComboBox comboExistingMember;
        private System.Windows.Forms.ComboBox comboJob;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtHometown;
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
        private System.Windows.Forms.Button btnAddMem;
    }
}