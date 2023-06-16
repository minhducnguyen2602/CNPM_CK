using New_DOAN.DAO;
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
    public partial class frmMain : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN8;Integrated Security=True");
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
            string query = "Select THANHVIEN.MaTV as 'Mã thành viên',TVCU as 'Thành viên cũ', QUANHE.LoaiQH as 'Loại quan hệ', NgPSinh as 'Ngày phát sinh', HoTen as 'Họ và tên', GioiTinh as 'Giới tính', NgSinh as 'Ngày sinh', QUEQUAN.TenQueQuan as 'Quê quán', NGHENGHIEP.TenNN as 'Nghề nghiệp', DiaChi as 'Địa chỉ'  from THANHVIEN, QUEQUAN, NGHENGHIEP, QUANHE where THANHVIEN.MaQH = QUANHE.MaQH and THANHVIEN.MaQQ = QUEQUAN.MaQQ and THANHVIEN.MaNNghiep = NGHENGHIEP.MaNNghiep";
            dtgvShow.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            key = 2;
            LoadForm(new frmMinus());
            string query = "select THANHVIEN.MaTV as 'Mã thành viên',THANHVIEN.HoTen as 'Họ tên', KETTHUC.NgayMat as 'Ngày giờ mất', NNMAT.LoaiNN as 'Nguyên nhân', DDMT.DiaDiem as 'Địa điểm mai táng'\r\nfrom THANHVIEN, NNMAT, DDMT, KETTHUC\r\nwhere THANHVIEN.MaTV = KETTHUC.MaTV and KETTHUC.MaDD = DDMT.MaDD and KETTHUC.MaNNhan = NNMAT.MaNNhan";
            dtgvShow.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void btnAchive_Click(object sender, EventArgs e)
        {
            key = 3;
            LoadForm(new frmAchive());
            string query = "select THANHVIEN.MaTV as 'Mã thành viên',THANHVIEN.HoTen as 'Họ tên', NHAPTT.TenTT as 'Loại thành tích', THANHTICH.NgPSinhTT as 'Ngày phát sinh'\r\nfrom THANHVIEN, NHAPTT,THANHTICH\r\nwhere THANHVIEN.MaTV = THANHTICH.MaTV and THANHTICH.LoaiTT = NHAPTT.LoaiTT";
            dtgvShow.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            key = 5;
            LoadForm(new frmReport());
            string query = "Select THANHVIEN.MaTV as 'Mã thành viên',TVCU as 'Thành viên cũ', QUANHE.LoaiQH as 'Loại quan hệ', NgPSinh as 'Ngày phát sinh', HoTen as 'Họ và tên', GioiTinh as 'Giới tính', NgSinh as 'Ngày sinh', QUEQUAN.TenQueQuan as 'Quê quán', NGHENGHIEP.TenNN as 'Nghề nghiệp', DiaChi as 'Địa chỉ'  from THANHVIEN, QUEQUAN, NGHENGHIEP, QUANHE where THANHVIEN.MaQH = QUANHE.MaQH and THANHVIEN.MaQQ = QUEQUAN.MaQQ and THANHVIEN.MaNNghiep = NGHENGHIEP.MaNNghiep";
            dtgvShow.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            key = 4;
            LoadForm(new frmSearch());
            string query = "Select THANHVIEN.MaTV as 'Mã thành viên', TVCU as 'Thành viên cũ', QUANHE.LoaiQH as 'Loại quan hệ', NgPSinh as 'Ngày phát sinh', HoTen as 'Họ và tên', GioiTinh as 'Giới tính', NgSinh as 'Ngày sinh', QUEQUAN.TenQueQuan as 'Quê quán', NGHENGHIEP.TenNN as 'Nghề nghiệp', DiaChi as 'Địa chỉ'  from THANHVIEN, QUEQUAN, NGHENGHIEP, QUANHE where THANHVIEN.MaQH = QUANHE.MaQH and THANHVIEN.MaQQ = QUEQUAN.MaQQ and THANHVIEN.MaNNghiep = NGHENGHIEP.MaNNghiep";
            dtgvShow.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        public void LoadMemberList()
        {
            if (key == 1)
            {
                string query = "Select MaTV as 'Mã thành viên', TVCU as 'Thành viên cũ', QUANHE.LoaiQH as 'Loại quan hệ', NgPSinh as 'Ngày phát sinh', HoTen as 'Họ và tên', GioiTinh as 'Giới tính', NgSinh as 'Ngày sinh', QUEQUAN.TenQueQuan as 'Quê quán', NGHENGHIEP.TenNN as 'Nghề nghiệp', DiaChi as 'Địa chỉ'  from THANHVIEN, QUEQUAN, NGHENGHIEP, QUANHE where THANHVIEN.MaQH = QUANHE.MaQH and THANHVIEN.MaQQ = QUEQUAN.MaQQ and THANHVIEN.MaNNghiep = NGHENGHIEP.MaNNghiep";
                dtgvShow.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (key == 2)
            {
                string query = "select THANHVIEN.MaTV as 'Mã thành viên',THANHVIEN.HoTen as 'Họ tên', KETTHUC.NgayMat as 'Ngày giờ mất', NNMAT.LoaiNN as 'Nguyên nhân', DDMT.DiaDiem as 'Địa điểm mai táng'\r\nfrom THANHVIEN, NNMAT, DDMT, KETTHUC\r\nwhere THANHVIEN.MaTV = KETTHUC.MaTV and KETTHUC.MaDD = DDMT.MaDD and KETTHUC.MaNNhan = NNMAT.MaNNhan";
                dtgvShow.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (key == 3)
            {
                string query = "select THANHVIEN.MaTV as 'Mã thành viên',THANHVIEN.HoTen as 'Họ tên', NHAPTT.TenTT as 'Loại thành tích', THANHTICH.NgPSinhTT as 'Ngày phát sinh'\r\nfrom THANHVIEN, NHAPTT,THANHTICH\r\nwhere THANHVIEN.MaTV = THANHTICH.MaTV and THANHTICH.LoaiTT = NHAPTT.LoaiTT";
                dtgvShow.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            if (key == 4)
            {
                string query = "Select THANHVIEN.MaTV as 'Mã thành viên',TVCU as 'Thành viên cũ', QUANHE.LoaiQH as 'Loại quan hệ', NgPSinh as 'Ngày phát sinh', HoTen as 'Họ và tên', GioiTinh as 'Giới tính', NgSinh as 'Ngày sinh', QUEQUAN.TenQueQuan as 'Quê quán', NGHENGHIEP.TenNN as 'Nghề nghiệp', DiaChi as 'Địa chỉ'  from THANHVIEN, QUEQUAN, NGHENGHIEP, QUANHE where THANHVIEN.MaQH = QUANHE.MaQH and THANHVIEN.MaQQ = QUEQUAN.MaQQ and THANHVIEN.MaNNghiep = NGHENGHIEP.MaNNghiep";
                dtgvShow.DataSource = DataProvider.Instance.ExecuteQuery(query);
            } 
            if (key == 5)
            {
                string query = "Select THANHVIEN.MaTV as 'Mã thành viên',TVCU as 'Thành viên cũ', QUANHE.LoaiQH as 'Loại quan hệ', NgPSinh as 'Ngày phát sinh', HoTen as 'Họ và tên', GioiTinh as 'Giới tính', NgSinh as 'Ngày sinh', QUEQUAN.TenQueQuan as 'Quê quán', NGHENGHIEP.TenNN as 'Nghề nghiệp', DiaChi as 'Địa chỉ'  from THANHVIEN, QUEQUAN, NGHENGHIEP, QUANHE where THANHVIEN.MaQH = QUANHE.MaQH and THANHVIEN.MaQQ = QUEQUAN.MaQQ and THANHVIEN.MaNNghiep = NGHENGHIEP.MaNNghiep";
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
            if (result == DialogResult.Yes)
            {
                fLogin lg = new fLogin();
                this.Hide();

                
                lg.ShowDialog();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            key = 1;
            LoadForm(new frmSetting());
            string query = "Select MaTV as 'Mã thành viên', TVCU as 'Thành viên cũ', QUANHE.LoaiQH as 'Loại quan hệ', NgPSinh as 'Ngày phát sinh', HoTen as 'Họ và tên', GioiTinh as 'Giới tính', NgSinh as 'Ngày sinh', QUEQUAN.TenQueQuan as 'Quê quán', NGHENGHIEP.TenNN as 'Nghề nghiệp', DiaChi as 'Địa chỉ'  from THANHVIEN, QUEQUAN, NGHENGHIEP, QUANHE where THANHVIEN.MaQH = QUANHE.MaQH and THANHVIEN.MaQQ = QUEQUAN.MaQQ and THANHVIEN.MaNNghiep = NGHENGHIEP.MaNNghiep";
            dtgvShow.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
               
        }

        private void khởiTạoLạiThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN8;Integrated Security=True"))
            {
                connection.Open();
                string query = "Delete from THANHVIEN; DELETE from THANHTICH; DELETE from KETTHUC";
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa hết dữ liệu liên quan đến thành viên");
                    fLogin lg = new fLogin();
                    this.Hide();


                    lg.ShowDialog();
                }    

            }

        }

        private void khởiTạoLạiThànhTíchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN8;Integrated Security=True"))
            {
                connection.Open();
                string query = "DELETE from THANHTICH";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa hết dữ liệu liên quan đến thành tích");
                }

            }
        }

        private void khởiTạoLạiGhiNhậnKếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN8;Integrated Security=True"))
            {
                connection.Open();
                string query = "DELETE from KETTHUC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa hết dữ liệu liên quan đến ghi nhận kết thúc");
                }

            }
        }
    }
    
}
