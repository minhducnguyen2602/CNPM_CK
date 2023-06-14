﻿using New_DOAN.DAO;
using New_DOAN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_DOAN
{
    public partial class frmAchive : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN8;Integrated Security=True");
        private AchiveDAO achiveDAO;
        public DataGridView MemberDataGridView { get; set; }
        public frmAchive()
        {
            InitializeComponent();
            achiveDAO = new AchiveDAO();
            conn.Open();
            LoadMemberList1();
        }

        private void comboAchiveName_SelectedIndexChanged(object sender, EventArgs e)
        {}


        public void LoadMemberList1()
        {
            string query = "Select * from THANHTICH";
            if (MemberDataGridView != null)
            {
                MemberDataGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
        }
        void loadTV()
        {
            var cmdq = new SqlCommand("Select HoTen from THANHVIEN", conn);
            var drq = cmdq.ExecuteReader();
            var dtq = new DataTable();
            dtq.Load(drq);
            drq.Dispose();
            comboAchiveName.DataSource = dtq;
            comboAchiveName.DisplayMember = "HoTen"; // Thiết lập cột hiển thị
            comboAchiveName.ValueMember = "HoTen"; // Thiết lập cột giá trị
        }
        void loadTT()
        {
            var cmd = new SqlCommand("Select TenTT from NHAPTT", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            comboAchiveType.DataSource = dt;
            comboAchiveType.DisplayMember = "LoaiNN"; // Thiết lập cột hiển thị
            comboAchiveType.ValueMember = "LoaiNN"; // Thiết lập cột giá trị
        }
        private void frmAchive_Load(object sender, EventArgs e)
        {
            loadTV();
            loadTT();
        }

        private void btnAchive_Click(object sender, EventArgs e)
        {
            AchiveDTO member = new AchiveDTO();
            member.HOTEN = comboAchiveName.SelectedValue.ToString();
            member.LOIATT = comboAchiveType.SelectedValue.ToString();
            member.NGPSINHTT = DateTime.Parse(dateTimePickerAchive.Text);
            member.MATT=member.HOTEN;
        }
    }
}
