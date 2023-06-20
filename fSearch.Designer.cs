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
            this.tHANHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOAN8DataSet = new New_DOAN.DOAN8DataSet();
            this.tHANHVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvSearch = new System.Windows.Forms.DataGridView();
            this.tHANHVIENTableAdapter = new New_DOAN.DOAN8DataSetTableAdapters.THANHVIENTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblOccurrenceDate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHometown = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
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
            this.btnSearch.Location = new System.Drawing.Point(236, 279);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tra cứu";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvSearch);
            this.panel1.Location = new System.Drawing.Point(13, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 351);
            this.panel1.TabIndex = 4;
            // 
            // dtgvSearch
            // 
            this.dtgvSearch.AllowUserToAddRows = false;
            this.dtgvSearch.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dtgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSearch.Location = new System.Drawing.Point(4, 3);
            this.dtgvSearch.Name = "dtgvSearch";
            this.dtgvSearch.ReadOnly = true;
            this.dtgvSearch.RowHeadersWidth = 51;
            this.dtgvSearch.RowTemplate.Height = 24;
            this.dtgvSearch.Size = new System.Drawing.Size(514, 345);
            this.dtgvSearch.TabIndex = 0;
            this.dtgvSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tHANHVIENTableAdapter
            // 
            this.tHANHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quê quán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nghề nghiêp";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(221, 231);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // lblOccurrenceDate
            // 
            this.lblOccurrenceDate.AutoSize = true;
            this.lblOccurrenceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccurrenceDate.Location = new System.Drawing.Point(60, 234);
            this.lblOccurrenceDate.Name = "lblOccurrenceDate";
            this.lblOccurrenceDate.Size = new System.Drawing.Size(80, 16);
            this.lblOccurrenceDate.TabIndex = 55;
            this.lblOccurrenceDate.Text = "Ngày sinh:";
            this.lblOccurrenceDate.Click += new System.EventHandler(this.lblOccurrenceDate_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(221, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 22);
            this.txtName.TabIndex = 56;
            // 
            // txtHometown
            // 
            this.txtHometown.Location = new System.Drawing.Point(221, 182);
            this.txtHometown.Name = "txtHometown";
            this.txtHometown.Size = new System.Drawing.Size(265, 22);
            this.txtHometown.TabIndex = 57;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(221, 133);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(265, 22);
            this.txtJob.TabIndex = 58;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(546, 681);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtHometown);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblOccurrenceDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvSearch;
        private DOAN8DataSet dOAN8DataSet;
        private System.Windows.Forms.BindingSource tHANHVIENBindingSource;
        private DOAN8DataSetTableAdapters.THANHVIENTableAdapter tHANHVIENTableAdapter;
        private System.Windows.Forms.BindingSource tHANHVIENBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblOccurrenceDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHometown;
        private System.Windows.Forms.TextBox txtJob;
    }
}