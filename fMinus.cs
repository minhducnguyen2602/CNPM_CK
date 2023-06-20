using New_DOAN.DAO;
using New_DOAN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Converters;

namespace New_DOAN
{
    public partial class frmMinus : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN10;Integrated Security=True");
        private MinusDAO minusDAO;
        public DataGridView MemberDataGridView { get; set; }
        public frmMinus()
        {
            InitializeComponent();
            minusDAO = new MinusDAO();
            conn.Open();
            LoadMemberList1();
        }
        void loadTV()
        {
            var cmdq = new SqlCommand("Select MaTV from THANHVIEN", conn);
            var drq = cmdq.ExecuteReader();
            var dtq = new DataTable();
            dtq.Load(drq);
            drq.Dispose();
            comboMinusName.DataSource = dtq;
            comboMinusName.DisplayMember = "MaTV"; // Thiết lập cột hiển thị
            comboMinusName.ValueMember = "MaTV"; // Thiết lập cột giá trị
        }
        void loadNN()
        {
            var cmd = new SqlCommand("Select LoaiNN from NNMAT", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            comboMinusCause.DataSource = dt;
            comboMinusCause.DisplayMember = "LoaiNN"; // Thiết lập cột hiển thị
            comboMinusCause.ValueMember = "LoaiNN"; // Thiết lập cột giá trị
        }
        void loadDD()
        {
            var cmd = new SqlCommand("Select DiaDiem from DDMT", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            comboMinusPlace.DataSource = dt;
            comboMinusPlace.DisplayMember = "DiaDiem"; // Thiết lập cột hiển thị
            comboMinusPlace.ValueMember = "DiaDiem"; // Thiết lập cột giá trị
        }

        public void LoadMemberList1()
        {
            string query = "Select * from KETTHUC";
            if (MemberDataGridView != null)
            {
                MemberDataGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
        }

        public bool IsMemberExist(string matv)
        {
            string query = "SELECT COUNT(*) FROM KETTHUC WHERE MaTV = @MATV";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@MATV", matv);

            bool exists = false;

            if (conn.State != ConnectionState.Open)
                conn.Open();

            try
            {
                int count = (int)command.ExecuteScalar();
                exists = count > 0;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

            return exists;
        }



        
        private void btnMinus_Click(object sender, EventArgs e)
        {
 
            MinusDTO member = new MinusDTO();
            
            member.MATV = comboMinusName.SelectedValue.ToString();
            string matv=member.MATV;
            int mann = 0;
            string tennn = comboMinusCause.SelectedValue.ToString();
            using (SqlCommand command = new SqlCommand("Select MaNNhan from NNMAT where LoaiNN = @LOAINN", conn))
            {

                command.Parameters.AddWithValue("@LOAINN", tennn);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mann = reader.GetInt32(0);
                    }
                }
            }
            member.NGAYMAT = DateTime.Parse(dateTimePickerMinus.Text);
            string query = "SELECT NgSinh FROM THANHVIEN WHERE MaTV = @MATV";

            // Chuẩn bị và thực thi câu truy vấn
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@MATV", matv);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime ngSinh = reader.GetDateTime(0);
                        if (ngSinh > member.NGAYMAT)
                        {
                            errorProvider1.Clear();
                            errorProvider1.SetError(dateTimePickerMinus, "Sai dữ liệu");
                            return;
                        }
                        
                    }
                }
            }
            member.NNMAT = mann;
            int madd = 0;
            string tendd = comboMinusPlace.SelectedValue.ToString();
            using (SqlCommand command = new SqlCommand("Select MaDD from DDMT where DiaDiem = @DIADIEM", conn))
            {

                command.Parameters.AddWithValue("@DIADIEM", tendd);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        madd = reader.GetInt32(0);
                    }
                }
            }
            member.DDMT = madd;
            var count = 0;
            var querydemmatv = "Select count(*) from KETTHUC";
            using (SqlCommand command = new SqlCommand(querydemmatv, conn))
            {
                count = (int)command.ExecuteScalar();
            }
            member.MAKT = "KETTHUC" + count.ToString();

            minusDAO.SaveMinus(member);
        }


        private void frmMinus_Load(object sender, EventArgs e)
        {
            loadTV();
            loadNN();
            loadDD();
        }

        private void comboMinusName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string matv = comboMinusName.SelectedValue.ToString();
            var count = 0;
            var querydemmatv = "Select count(*) from KETTHUC where MaTV = @MATV";
            using (SqlCommand command = new SqlCommand(querydemmatv, conn))
            {
                command.Parameters.AddWithValue("@MATV", matv);
                count = (int)command.ExecuteScalar();
            }
            if(count == 0)
            {
                MessageBox.Show("Thành viên này chưa được ghi nhận kết thúc");
                return;
            }    
            using (SqlCommand command = new SqlCommand("DELETE FROM KETTHUC WHERE MaTV = @GiaTri", conn))
            {
                command.Parameters.AddWithValue("@GiaTri", matv);

                // Thực thi câu lệnh DELETE
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show("Đã xóa");
                // rowsAffected là số hàng bị ảnh hưởng bởi câu lệnh DELETE
            }



        }
    }
}
