using New_DOAN.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_DOAN
{
    public partial class frmMain : Form
    {
        private int key = 1;
        public frmMain()
        {
            InitializeComponent();
            LoadMemberList();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmAdd frm = new frmAdd() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pContainer.Controls.Add(frm);
            frm.Show();
        }
        private void LoadForm(Form form)
        {
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;

            this.pContainer.Controls.Clear();
            this.pContainer.Controls.Add(form);
            form.Show();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            key = 1;
            LoadForm(new frmAdd());
            string query = "Select * from THANHVIEN";
            dtgvShow.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            key = 2;
            LoadForm(new frmMinus());
            string query = "Select * from KETTHUC";
            dtgvShow.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void btnAchive_Click(object sender, EventArgs e)
        {
            key = 3;
            LoadForm(new frmAchive());
            string query = "Select MaTV as 'Họ Tên', LoaiTT as 'Loại Thành Tích' , NgPSinhTT as 'Ngày Phát Sinh Thành Tích' from THANHTICH";
            dtgvShow.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            LoadForm(new frmReport());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            key = 4;
            LoadForm(new frmSearch());
            string query = "Select MaTV as 'Họ Tên', NgSinh as 'Ngày Sinh' , Doi as 'Đời', MaQH as 'Cha/Mẹ' from THANHVIEN";
            dtgvShow.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        public void LoadMemberList()
        {
            if (key == 1)
            {
                string query = "Select * from THANHVIEN";
                dtgvShow.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (key == 2)
            {
                string query = "Select * from KETTHUC";
                dtgvShow.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (key == 3)
            {
                string query = "Select MaTV as 'Họ Tên', LoaiTT as 'Loại Thành Tích' , NgPSinhTT as 'Ngày Phát Sinh Thành Tích' from THANHTICH";
                dtgvShow.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (key == 4)
            {
                string query = "Select MaTV as 'Họ Tên', NgSinh as 'Ngày Sinh' , Doi as 'Đời', MaQH as 'Cha/Mẹ' from THANHVIEN";
                dtgvShow.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }    
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất phần mềm không?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }
    }
    
}
