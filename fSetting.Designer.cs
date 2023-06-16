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
            this.comboMemberJob = new System.Windows.Forms.ComboBox();
            this.comboTown = new System.Windows.Forms.ComboBox();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.dOAN8DataSet = new New_DOAN.DOAN8DataSet();
            this.tHANHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHANHVIENTableAdapter = new New_DOAN.DOAN8DataSetTableAdapters.THANHVIENTableAdapter();
            this.qUEQUANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUEQUANTableAdapter = new New_DOAN.DOAN8DataSetTableAdapters.QUEQUANTableAdapter();
            this.nGHENGHIEPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGHENGHIEPTableAdapter = new New_DOAN.DOAN8DataSetTableAdapters.NGHENGHIEPTableAdapter();
            this.lblMaTV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dOAN8DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUEQUANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGHENGHIEPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(141, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(238, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THAY ĐỔI THÔNG TIN";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.Location = new System.Drawing.Point(61, 202);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(99, 16);
            this.lblJob.TabIndex = 1;
            this.lblJob.Text = "Nghề nghiệp:";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(61, 273);
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
            this.comboMaTV.FormattingEnabled = true;
            this.comboMaTV.Location = new System.Drawing.Point(205, 138);
            this.comboMaTV.Name = "comboMaTV";
            this.comboMaTV.Size = new System.Drawing.Size(280, 24);
            this.comboMaTV.TabIndex = 4;
            this.comboMaTV.ValueMember = "MaTV";
            // 
            // comboMemberJob
            // 
            this.comboMemberJob.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nGHENGHIEPBindingSource, "TenNN", true));
            this.comboMemberJob.DataSource = this.nGHENGHIEPBindingSource;
            this.comboMemberJob.DisplayMember = "TenNN";
            this.comboMemberJob.FormattingEnabled = true;
            this.comboMemberJob.Location = new System.Drawing.Point(205, 202);
            this.comboMemberJob.Name = "comboMemberJob";
            this.comboMemberJob.Size = new System.Drawing.Size(280, 24);
            this.comboMemberJob.TabIndex = 5;
            this.comboMemberJob.ValueMember = "TenNN";
            // 
            // comboTown
            // 
            this.comboTown.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.qUEQUANBindingSource, "TenQueQuan", true));
            this.comboTown.DataSource = this.qUEQUANBindingSource;
            this.comboTown.DisplayMember = "TenQueQuan";
            this.comboTown.FormattingEnabled = true;
            this.comboTown.Location = new System.Drawing.Point(205, 265);
            this.comboTown.Name = "comboTown";
            this.comboTown.Size = new System.Drawing.Size(280, 24);
            this.comboTown.TabIndex = 6;
            this.comboTown.ValueMember = "TenQueQuan";
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Location = new System.Drawing.Point(205, 341);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(123, 36);
            this.btnUpdateMember.TabIndex = 7;
            this.btnUpdateMember.Text = "Thay đổi";
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            this.btnUpdateMember.Click += new System.EventHandler(this.button1_Click);
            // 
            // dOAN8DataSet
            // 
            this.dOAN8DataSet.DataSetName = "DOAN8DataSet";
            this.dOAN8DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHANHVIENBindingSource
            // 
            this.tHANHVIENBindingSource.DataMember = "THANHVIEN";
            this.tHANHVIENBindingSource.DataSource = this.dOAN8DataSet;
            // 
            // tHANHVIENTableAdapter
            // 
            this.tHANHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // qUEQUANBindingSource
            // 
            this.qUEQUANBindingSource.DataMember = "QUEQUAN";
            this.qUEQUANBindingSource.DataSource = this.dOAN8DataSet;
            // 
            // qUEQUANTableAdapter
            // 
            this.qUEQUANTableAdapter.ClearBeforeFill = true;
            // 
            // nGHENGHIEPBindingSource
            // 
            this.nGHENGHIEPBindingSource.DataMember = "NGHENGHIEP";
            this.nGHENGHIEPBindingSource.DataSource = this.dOAN8DataSet;
            // 
            // nGHENGHIEPTableAdapter
            // 
            this.nGHENGHIEPTableAdapter.ClearBeforeFill = true;
            // 
            // lblMaTV
            // 
            this.lblMaTV.AutoSize = true;
            this.lblMaTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTV.Location = new System.Drawing.Point(61, 138);
            this.lblMaTV.Name = "lblMaTV";
            this.lblMaTV.Size = new System.Drawing.Size(112, 16);
            this.lblMaTV.TabIndex = 2;
            this.lblMaTV.Text = "Tên thành viên:";
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.dOAN8DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUEQUANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGHENGHIEPBindingSource)).EndInit();
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
    }
}