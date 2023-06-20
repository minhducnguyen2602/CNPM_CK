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
    public partial class frmAchive : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN10;Integrated Security=True");
        private AchiveDAO achiveDAO;
        public DataGridView MemberDataGridView { get; set; }
        public frmAchive()
        {
            InitializeComponent();
            achiveDAO = new AchiveDAO();
            conn.Open();
            LoadMemberList11();
        }

       


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
            var cmdq = new SqlCommand("Select MaTV from THANHVIEN", conn);
            var drq = cmdq.ExecuteReader();
            var dtq = new DataTable();
            dtq.Load(drq);
            drq.Dispose();
            comboAchiveName.DataSource = dtq;
            comboAchiveName.DisplayMember = "MaTV"; // Thiết lập cột hiển thị
            comboAchiveName.ValueMember = "MaTV"; // Thiết lập cột giá trị
        }
        void loadTT()
        {
            var cmd = new SqlCommand("Select TenTT from NHAPTT WHERE TenTT <> 'NONE'", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            comboAchiveType.DataSource = dt;
            comboAchiveType.DisplayMember = "TenTT"; // Thiết lập cột hiển thị
            comboAchiveType.ValueMember = "TenTT"; // Thiết lập cột giá trị
        }
        public void LoadMemberList11()
        {
            string query = "Select * from THANHTICH";
            if (MemberDataGridView != null)
            {
                MemberDataGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);

            }
        }
        private void btnAchive_Click(object sender, EventArgs e)
        {
            AchiveDTO member = new AchiveDTO();
            member.MATV = comboAchiveName.SelectedValue.ToString();

            int mattt = 0;
            string tentt = comboAchiveType.SelectedValue.ToString();
            using (SqlCommand command = new SqlCommand("Select LOAITT from NHAPTT where TenTT = @Tentt", conn))
            {

                command.Parameters.AddWithValue("@Tentt", tentt);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mattt = reader.GetInt32(0);
                    }
                }
            }
            member.LOAITT = mattt;

            member.NGPSINHTT = DateTime.Parse(dateTimePickerAchive.Text);
            var querydemmatv = "Select count(*) from THANHTICH";
            var count1 = 0;
            using (SqlCommand command = new SqlCommand(querydemmatv, conn))
            {
                count1 = (int)command.ExecuteScalar();
            }
            member.MATT="ThanhTich"+count1.ToString();
            var querydem = "Select count(*) from THANHTICH where MaTV = @MATV and LoaiTT = @MATT and NgPSinhTT = @NGPS";
            var count5 = 0;
            using (SqlCommand command = new SqlCommand(querydem, conn))
            {
                command.Parameters.AddWithValue("@MATV", member.MATV);
                command.Parameters.AddWithValue("@MATT", member.LOAITT);
                command.Parameters.AddWithValue("@NGPS", member.NGPSINHTT);
                count5 = (int)command.ExecuteScalar();
            }

            if(count5 != 0)
            {
                MessageBox.Show("Đã tồn tại một thành tích với thông tin y hệt");
                return;
            }    
            achiveDAO.SaveAchive(member);
            loadTV();
        }

        private void frmAchive_Load_1(object sender, EventArgs e)
        {
            loadTV();
            loadTT();

        }
        private void comboAchiveName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AchiveDTO member = new AchiveDTO();
            member.MATV = comboAchiveName.SelectedValue.ToString();

            int mattt = 0;
            string tentt = comboAchiveType.SelectedValue.ToString();
            using (SqlCommand command = new SqlCommand("Select LOAITT from NHAPTT where TenTT = @Tentt", conn))
            {

                command.Parameters.AddWithValue("@Tentt", tentt);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mattt = reader.GetInt32(0);
                    }
                }
            }
            member.LOAITT = mattt;

            member.NGPSINHTT = DateTime.Parse(dateTimePickerAchive.Text);
            var querydemmatv = "Select count(*) from THANHTICH";
            var count1 = 0;
            using (SqlCommand command = new SqlCommand(querydemmatv, conn))
            {
                count1 = (int)command.ExecuteScalar();
            }
            int matt = 0;
            member.MATT = "ThanhTich" + count1.ToString();
            var querydem = "Select count(*) from THANHTICH where MaTV = @MATV and LoaiTT = @MATT and NgPSinhTT = @NGPS";
            var count5 = 0;
            using (SqlCommand command = new SqlCommand(querydem, conn))
            {
                
                command.Parameters.AddWithValue("@MATV", member.MATV);
                command.Parameters.AddWithValue("@MATT", member.LOAITT);
                command.Parameters.AddWithValue("@NGPS", member.NGPSINHTT);
                count5 = (int)command.ExecuteScalar();
            }
            if (count5 == 0)
            {
                MessageBox.Show("Không có thành tích nào có thông tin như vậy");
                return;
            }
            using (SqlCommand command = new SqlCommand("Select MaTT from THANHTICH where MaTV = @MATV and LoaiTT = @MATT and NgPSinhTT = @NGPS", conn))
            {

                command.Parameters.AddWithValue("@MATV", member.MATV);
                command.Parameters.AddWithValue("@MATT", member.LOAITT);
                command.Parameters.AddWithValue("@NGPS", member.NGPSINHTT);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        matt = reader.GetInt32(0);
                    }
                }
            }
            using (SqlCommand command = new SqlCommand("DELETE FROM THANHTICH WHERE MaTT = @GiaTri", conn))
            {
                command.Parameters.AddWithValue("@GiaTri", matt);

                // Thực thi câu lệnh DELETE
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show("Đã xóa");
            }

        }
    }
}
