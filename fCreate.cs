using New_DOAN.DAO;
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
    public partial class frmCreate : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN16;Integrated Security=True");
        private MemberDAO memberDAO;
        public frmCreate()
        {
            InitializeComponent();
            memberDAO = new MemberDAO();
            connect.Open();
            this.comboBox1.SelectedIndex = 0;
        }

        void loadNghe()
        {
            var cmd = new SqlCommand("Select TenNN from NGHENGHIEP", connect);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            comboJob.DataSource = dt;
            comboJob.DisplayMember = "TenNN"; // Thiết lập cột hiển thị
            comboJob.ValueMember = "TenNN"; // Thiết lập cột giá trị
        }

        void loadQue()
        {
            var cmdq = new SqlCommand("Select TenQueQuan from QUEQUAN", connect);
            var drq = cmdq.ExecuteReader();
            var dtq = new DataTable();
            dtq.Load(drq);
            drq.Dispose();
            comboBoxQue.DataSource = dtq;
            comboBoxQue.DisplayMember = "TenQueQuan"; // Thiết lập cột hiển thị
            comboBoxQue.ValueMember = "TenQueQuan"; // Thiết lập cột giá trị
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu mã thành viên "Them0" đã tồn tại
            
            if(txtName.Text=="")
            {
                errorProvider1.SetError(txtName, "Chưa nhập thông tin");
                return;
            }
            MemberDTO newMember = new MemberDTO();
            newMember.MAQH = "qh0";
            newMember.NGPSINH = DateTime.Parse(dateTimePicker1.Text);
            newMember.HOTEN = txtName.Text;
            newMember.GT = comboBox1.SelectedItem.ToString();
            int maqq = 0;
            string tenqq = comboBoxQue.SelectedValue.ToString();
            using (SqlCommand command = new SqlCommand("Select MaQQ from QUEQUAN where TenQueQuan = @QUEQUAN", connect))
            {

                command.Parameters.AddWithValue("@QUEQUAN", tenqq);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        maqq = reader.GetInt32(0);
                    }
                }
            }
            int mann = 0;
            string tennn = comboJob.SelectedValue.ToString();
            using (SqlCommand command = new SqlCommand("Select MaNNghiep from NGHENGHIEP where TenNN = @NGHENGHIEP", connect))
            {

                command.Parameters.AddWithValue("@NGHENGHIEP", tennn);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mann = reader.GetInt32(0);
                    }
                }
            }
            connect = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN16;Integrated Security=True");
            int count = 0;
            connect.Open();
            string name = "";
            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM THANHVIEN WHERE MaTV = @MemberCode", connect))
            {
                command.Parameters.AddWithValue("@MemberCode", "TV0");
                count = (int)command.ExecuteScalar();
  
            }
            if (count != 0)
            {
                using (SqlCommand command = new SqlCommand("SELECT HoTen FROM THANHVIEN WHERE MaTV = @MemberCode", connect))
                {
                    command.Parameters.AddWithValue("@MemberCode", "TV0");
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            name = reader.GetString(0);
                        }
                    }
                    connect.Close();

                }
                MessageBox.Show("Đã tồn tại một cây gia phả! Tên tài khoản cũ của bạn là: " + name.ToString(), "Thông báo");
                fLogin l = new fLogin();
                this.Hide();
                l.ShowDialog();
                this.Show();

            }
            newMember.NGSINH = DateTime.Parse(datBirthday.Text);
            newMember.MAQQ = maqq;// Lấy giá trị từ cột giá trị
            newMember.MANN = mann;// Lấy giá trị từ cột giá trị
            newMember.DIACHI = txtAddress.Text;
     
            newMember.MATV = "TV0";
            newMember.TVCU = newMember.MATV;
            newMember.DOI = 0;
            if (newMember.NGPSINH != newMember.NGSINH)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(dateTimePicker1, "Sai thông tin");
                return;
            }
            memberDAO.SaveRoot(newMember);
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void frmCreate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testingDataSet6.NGHENGHIEP' table. You can move, or remove it, as needed.
            //this.nGHENGHIEPTableAdapter.Fill(this.testingDataSet6.NGHENGHIEP);
            loadNghe();
            loadQue();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
