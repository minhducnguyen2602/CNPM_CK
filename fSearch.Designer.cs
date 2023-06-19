namespace New_DOAN
{
    partial class frmSearch
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.comboSearchName = new System.Windows.Forms.ComboBox();
            this.tHANHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOAN8DataSet = new New_DOAN.DOAN8DataSet();
            this.tHANHVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvSearch = new System.Windows.Forms.DataGridView();
            this.tHANHVIENTableAdapter = new New_DOAN.DOAN8DataSetTableAdapters.THANHVIENTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerOccurred = new System.Windows.Forms.DateTimePicker();
            this.lblOccurrenceDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAN8DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHVIENBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Red;
            this.lblSearch.Location = new System.Drawing.Point(152, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(243, 25);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "TRA CỨU THÀNH VIÊN";
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchName.Location = new System.Drawing.Point(60, 87);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(73, 16);
            this.lblSearchName.TabIndex = 1;
            this.lblSearchName.Text = "Họ và tên";
            // 
            // comboSearchName
            // 
            this.comboSearchName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tHANHVIENBindingSource, "MaTV", true));
            this.comboSearchName.DataSource = this.tHANHVIENBindingSource1;
            this.comboSearchName.DisplayMember = "MaTV";
            this.comboSearchName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearchName.FormattingEnabled = true;
            this.comboSearchName.Location = new System.Drawing.Point(221, 83);
            this.comboSearchName.Name = "comboSearchName";
            this.comboSearchName.Size = new System.Drawing.Size(265, 24);
            this.comboSearchName.TabIndex = 2;
            this.comboSearchName.ValueMember = "MaTV";
            this.comboSearchName.SelectedIndexChanged += new System.EventHandler(this.comboSearchName_SelectedIndexChanged);
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
            // tHANHVIENBindingSource1
            // 
            this.tHANHVIENBindingSource1.DataMember = "THANHVIEN";
            this.tHANHVIENBindingSource1.DataSource = this.dOAN8DataSet;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(243, 346);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tra cứu";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvSearch);
            this.panel1.Location = new System.Drawing.Point(13, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 259);
            this.panel1.TabIndex = 4;
            // 
            // dtgvSearch
            // 
            this.dtgvSearch.AllowUserToAddRows = false;
            this.dtgvSearch.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dtgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSearch.Location = new System.Drawing.Point(4, 4);
            this.dtgvSearch.Name = "dtgvSearch";
            this.dtgvSearch.ReadOnly = true;
            this.dtgvSearch.RowHeadersWidth = 51;
            this.dtgvSearch.RowTemplate.Height = 24;
            this.dtgvSearch.Size = new System.Drawing.Size(514, 252);
            this.dtgvSearch.TabIndex = 0;
            this.dtgvSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tHANHVIENTableAdapter
            // 
            this.tHANHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thành viên cũ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tHANHVIENBindingSource, "MaTV", true));
            this.comboBox1.DataSource = this.tHANHVIENBindingSource1;
            this.comboBox1.DisplayMember = "MaTV";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "MaTV";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tHANHVIENBindingSource, "MaTV", true));
            this.comboBox2.DataSource = this.tHANHVIENBindingSource1;
            this.comboBox2.DisplayMember = "MaTV";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(221, 230);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(265, 24);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.ValueMember = "MaTV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quê quán";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tHANHVIENBindingSource, "MaTV", true));
            this.comboBox3.DataSource = this.tHANHVIENBindingSource1;
            this.comboBox3.DisplayMember = "MaTV";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(221, 180);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(265, 24);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.ValueMember = "MaTV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nghề nghiêp";
            // 
            // dateTimePickerOccurred
            // 
            this.dateTimePickerOccurred.Location = new System.Drawing.Point(221, 283);
            this.dateTimePickerOccurred.Name = "dateTimePickerOccurred";
            this.dateTimePickerOccurred.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerOccurred.TabIndex = 56;
            // 
            // lblOccurrenceDate
            // 
            this.lblOccurrenceDate.AutoSize = true;
            this.lblOccurrenceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccurrenceDate.Location = new System.Drawing.Point(60, 288);
            this.lblOccurrenceDate.Name = "lblOccurrenceDate";
            this.lblOccurrenceDate.Size = new System.Drawing.Size(114, 16);
            this.lblOccurrenceDate.TabIndex = 55;
            this.lblOccurrenceDate.Text = "Ngày phát sinh:";
            this.lblOccurrenceDate.Click += new System.EventHandler(this.lblOccurrenceDate_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(546, 681);
            this.Controls.Add(this.dateTimePickerOccurred);
            this.Controls.Add(this.lblOccurrenceDate);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboSearchName);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.lblSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearch";
            this.Text = "fSearch";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tHANHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAN8DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHVIENBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.ComboBox comboSearchName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvSearch;
        private DOAN8DataSet dOAN8DataSet;
        private System.Windows.Forms.BindingSource tHANHVIENBindingSource;
        private DOAN8DataSetTableAdapters.THANHVIENTableAdapter tHANHVIENTableAdapter;
        private System.Windows.Forms.BindingSource tHANHVIENBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerOccurred;
        private System.Windows.Forms.Label lblOccurrenceDate;
    }
}