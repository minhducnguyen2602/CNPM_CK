namespace New_DOAN
{
    partial class frmMinus
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
            this.lblMinusName = new System.Windows.Forms.Label();
            this.lblCause = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.comboMinusName = new System.Windows.Forms.ComboBox();
            this.tHANHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testingDataSet = new New_DOAN.testingDataSet();
            this.comboMinusCause = new System.Windows.Forms.ComboBox();
            this.nNMATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testingDataSet1 = new New_DOAN.testingDataSet1();
            this.comboMinusPlace = new System.Windows.Forms.ComboBox();
            this.dDMTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testingDataSet2 = new New_DOAN.testingDataSet2();
            this.lblMinus = new System.Windows.Forms.Label();
            this.lblMinusDate = new System.Windows.Forms.Label();
            this.dateTimePickerMinus = new System.Windows.Forms.DateTimePicker();
            this.tHANHVIENTableAdapter = new New_DOAN.testingDataSetTableAdapters.THANHVIENTableAdapter();
            this.nNMATTableAdapter = new New_DOAN.testingDataSet1TableAdapters.NNMATTableAdapter();
            this.dDMTTableAdapter = new New_DOAN.testingDataSet2TableAdapters.DDMTTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNMATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDMTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMinusName
            // 
            this.lblMinusName.AutoSize = true;
            this.lblMinusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusName.Location = new System.Drawing.Point(35, 87);
            this.lblMinusName.Name = "lblMinusName";
            this.lblMinusName.Size = new System.Drawing.Size(102, 16);
            this.lblMinusName.TabIndex = 0;
            this.lblMinusName.Text = "Mã thành viên";
            // 
            // lblCause
            // 
            this.lblCause.AutoSize = true;
            this.lblCause.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCause.Location = new System.Drawing.Point(35, 191);
            this.lblCause.Name = "lblCause";
            this.lblCause.Size = new System.Drawing.Size(130, 16);
            this.lblCause.TabIndex = 1;
            this.lblCause.Text = "Nguyên nhân mất:";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(35, 243);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(135, 16);
            this.lblPlace.TabIndex = 2;
            this.lblPlace.Text = "Địa điểm mai táng:";
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(305, 292);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(155, 33);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "Ghi nhận / Cập Nhật";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // comboMinusName
            // 
            this.comboMinusName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tHANHVIENBindingSource, "HoTen", true));
            this.comboMinusName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMinusName.FormattingEnabled = true;
            this.comboMinusName.Location = new System.Drawing.Point(224, 83);
            this.comboMinusName.Name = "comboMinusName";
            this.comboMinusName.Size = new System.Drawing.Size(287, 24);
            this.comboMinusName.TabIndex = 0;
            this.comboMinusName.SelectedIndexChanged += new System.EventHandler(this.comboMinusName_SelectedIndexChanged);
            // 
            // tHANHVIENBindingSource
            // 
            this.tHANHVIENBindingSource.DataMember = "THANHVIEN";
            this.tHANHVIENBindingSource.DataSource = this.testingDataSet;
            // 
            // testingDataSet
            // 
            this.testingDataSet.DataSetName = "testingDataSet";
            this.testingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboMinusCause
            // 
            this.comboMinusCause.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nNMATBindingSource, "LoaiNN", true));
            this.comboMinusCause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMinusCause.FormattingEnabled = true;
            this.comboMinusCause.Location = new System.Drawing.Point(224, 187);
            this.comboMinusCause.Name = "comboMinusCause";
            this.comboMinusCause.Size = new System.Drawing.Size(287, 24);
            this.comboMinusCause.TabIndex = 2;
            // 
            // nNMATBindingSource
            // 
            this.nNMATBindingSource.DataMember = "NNMAT";
            this.nNMATBindingSource.DataSource = this.testingDataSet1;
            // 
            // testingDataSet1
            // 
            this.testingDataSet1.DataSetName = "testingDataSet1";
            this.testingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboMinusPlace
            // 
            this.comboMinusPlace.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dDMTBindingSource, "DiaDiem", true));
            this.comboMinusPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMinusPlace.FormattingEnabled = true;
            this.comboMinusPlace.Location = new System.Drawing.Point(224, 239);
            this.comboMinusPlace.Name = "comboMinusPlace";
            this.comboMinusPlace.Size = new System.Drawing.Size(287, 24);
            this.comboMinusPlace.TabIndex = 3;
            // 
            // dDMTBindingSource
            // 
            this.dDMTBindingSource.DataMember = "DDMT";
            this.dDMTBindingSource.DataSource = this.testingDataSet2;
            // 
            // testingDataSet2
            // 
            this.testingDataSet2.DataSetName = "testingDataSet2";
            this.testingDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMinus
            // 
            this.lblMinus.AutoSize = true;
            this.lblMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinus.ForeColor = System.Drawing.Color.Red;
            this.lblMinus.Location = new System.Drawing.Point(158, 31);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(230, 25);
            this.lblMinus.TabIndex = 7;
            this.lblMinus.Text = "GHI NHẬN KẾT THÚC";
            // 
            // lblMinusDate
            // 
            this.lblMinusDate.AutoSize = true;
            this.lblMinusDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusDate.Location = new System.Drawing.Point(35, 139);
            this.lblMinusDate.Name = "lblMinusDate";
            this.lblMinusDate.Size = new System.Drawing.Size(77, 16);
            this.lblMinusDate.TabIndex = 8;
            this.lblMinusDate.Text = "Ngày mất:";
            // 
            // dateTimePickerMinus
            // 
            this.dateTimePickerMinus.Location = new System.Drawing.Point(224, 136);
            this.dateTimePickerMinus.Name = "dateTimePickerMinus";
            this.dateTimePickerMinus.Size = new System.Drawing.Size(287, 22);
            this.dateTimePickerMinus.TabIndex = 1;
            // 
            // tHANHVIENTableAdapter
            // 
            this.tHANHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // nNMATTableAdapter
            // 
            this.nNMATTableAdapter.ClearBeforeFill = true;
            // 
            // dDMTTableAdapter
            // 
            this.dDMTTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(79, 292);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(155, 33);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // frmMinus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(547, 354);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dateTimePickerMinus);
            this.Controls.Add(this.lblMinusDate);
            this.Controls.Add(this.lblMinus);
            this.Controls.Add(this.comboMinusPlace);
            this.Controls.Add(this.comboMinusCause);
            this.Controls.Add(this.comboMinusName);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblCause);
            this.Controls.Add(this.lblMinusName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMinus";
            this.Text = "Ghi nhận kết thúc";
            this.Load += new System.EventHandler(this.frmMinus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tHANHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNMATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDMTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinusName;
        private System.Windows.Forms.Label lblCause;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.ComboBox comboMinusName;
        private System.Windows.Forms.ComboBox comboMinusCause;
        private System.Windows.Forms.ComboBox comboMinusPlace;
        private System.Windows.Forms.Label lblMinus;
        private System.Windows.Forms.Label lblMinusDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerMinus;
        private testingDataSet testingDataSet;
        private System.Windows.Forms.BindingSource tHANHVIENBindingSource;
        private testingDataSetTableAdapters.THANHVIENTableAdapter tHANHVIENTableAdapter;
        private testingDataSet1 testingDataSet1;
        private System.Windows.Forms.BindingSource nNMATBindingSource;
        private testingDataSet1TableAdapters.NNMATTableAdapter nNMATTableAdapter;
        private testingDataSet2 testingDataSet2;
        private System.Windows.Forms.BindingSource dDMTBindingSource;
        private testingDataSet2TableAdapters.DDMTTableAdapter dDMTTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonDelete;
    }
}