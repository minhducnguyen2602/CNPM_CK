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
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvSearch = new System.Windows.Forms.DataGridView();
            this.tHANHVIENTableAdapter = new New_DOAN.DOAN8DataSetTableAdapters.THANHVIENTableAdapter();
            this.tHANHVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tHANHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAN8DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHVIENBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Blue;
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
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(236, 137);
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
            this.panel1.Location = new System.Drawing.Point(13, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 259);
            this.panel1.TabIndex = 4;
            // 
            // dtgvSearch
            // 
            this.dtgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSearch.Location = new System.Drawing.Point(4, 4);
            this.dtgvSearch.Name = "dtgvSearch";
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
            // tHANHVIENBindingSource1
            // 
            this.tHANHVIENBindingSource1.DataMember = "THANHVIEN";
            this.tHANHVIENBindingSource1.DataSource = this.dOAN8DataSet;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 441);
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHVIENBindingSource1)).EndInit();
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
    }
}