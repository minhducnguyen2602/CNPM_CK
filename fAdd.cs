using New_DOAN.DAO;
using New_DOAN.DTO;
using System;
using System.Collections;
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
    public partial class frmAdd : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN8;Integrated Security=True");
        private MemberDAO memberDAO;
        public DataGridView MemberDataGridView { get; set; }

        public frmAdd()
        {
            InitializeComponent();
            memberDAO = new MemberDAO();
            conn.Open();
            LoadMemberList1();
        }

        void loadNghe()
        {
            var cmd = new SqlCommand("Select TenNN from NGHENGHIEP", conn);
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
            var cmdq = new SqlCommand("Select TenQueQuan from QUEQUAN", conn);
            var drq = cmdq.ExecuteReader();
            var dtq = new DataTable();
            dtq.Load(drq);
            drq.Dispose();
            comboBoxQue.DataSource = dtq;
            comboBoxQue.DisplayMember = "TenQueQuan"; // Thiết lập cột hiển thị
            comboBoxQue.ValueMember = "TenQueQuan"; // Thiết lập cột giá trị
        }

        

        void loadTVcu()
        {
            var cmdq = new SqlCommand("Select HoTen from THANHVIEN", conn);
            var drq = cmdq.ExecuteReader();
            var dtq = new DataTable();
            dtq.Load(drq);
            drq.Dispose();
            comboExistingMember.DataSource = dtq;
            comboExistingMember.DisplayMember = "HoTen"; // Thiết lập cột hiển thị
            comboExistingMember.ValueMember = "HoTen"; // Thiết lập cột giá trị
        }

        public void LoadMemberList1()
        {
            string query = "Select * from THANHVIEN";
            if (MemberDataGridView != null)
            {
                MemberDataGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
        }


        private void btnAddMem_Click(object sender, EventArgs e)
        {

            MemberDTO newMember = new MemberDTO();
            if (comboExistingMember.SelectedItem != null)
            {
                newMember.TVCU = comboExistingMember.SelectedValue.ToString(); // Lấy giá trị từ cột giá trị
            }
            string mann = "";
            string tennn = comboJob.SelectedValue.ToString();
            using (SqlCommand command = new SqlCommand("Select MaNNghiep from NGHENGHIEP where TenNN = @NGHENGHIEP", conn))
            {

                command.Parameters.AddWithValue("@NGHENGHIEP", tennn);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mann = reader.GetString(0);
                    }
                }
            }
            string maqq = "";
            string tenqq = comboBoxQue.SelectedValue.ToString();
            using (SqlCommand command = new SqlCommand("Select MaQQ from QUEQUAN where TenQueQuan = @QUEQUAN", conn))
            {

                command.Parameters.AddWithValue("@QUEQUAN", tenqq);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        maqq = reader.GetString(0);
                    }
                }
            }
            newMember.MAQH = comboRelationship.SelectedItem.ToString();
            newMember.NGPSINH = DateTime.Parse(dateTimePickerOccurred.Text);
            newMember.HOTEN = txtFullName.Text;
            newMember.GT = comboBoxGT.SelectedItem.ToString();
            newMember.NGSINH = DateTime.Parse(dateTimePickerBirth.Text);
            newMember.MAQQ = maqq;// Lấy giá trị từ cột giá trị
            newMember.MANN = mann; // Lấy giá trị từ cột giá trị
            newMember.DIACHI = txtAddress.Text;
            var querydemmatv = "Select count(*) from THANHVIEN";
            var count = 0;
            using (SqlCommand command = new SqlCommand(querydemmatv, conn))
            {
                count = (int)command.ExecuteScalar();
            }
            int count1 = 0;
            using (SqlCommand command = new SqlCommand("Select Doi from THANHVIEN where HoTen = @HOTEN", conn))
            {
                // Thêm tham số @HOTEN và giá trị của biến vào câu truy vấn
                command.Parameters.AddWithValue("@HOTEN", newMember.TVCU);

                // Thực thi truy vấn và lấy kết quả
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Đọc giá trị cột 'Doi' từ mỗi hàng kết quả
                        count1 = reader.GetInt32(reader.GetOrdinal("Doi"));

                        // Xử lý dữ liệu tùy ý với giá trị 'doi' ở đây
                    }
                }
            }
            string makt = "Them" + count.ToString();
            ; newMember.MATV = makt;
            if (newMember.MAQH == "Con")
            {
                newMember.DOI = count1 + 1;
            }
            else newMember.DOI = count1;

            memberDAO.SaveMember(newMember);
            loadTVcu();

        }
        public void frmAdd_Load(object sender, EventArgs e)
        {

            loadNghe();
            loadQue();
            loadTVcu();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
