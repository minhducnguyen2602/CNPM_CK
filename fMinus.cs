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
using System.Windows.Media.Converters;

namespace New_DOAN
{
    public partial class frmMinus : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN8;Integrated Security=True");
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
            var cmdq = new SqlCommand("Select HoTen from THANHVIEN", conn);
            var drq = cmdq.ExecuteReader();
            var dtq = new DataTable();
            dtq.Load(drq);
            drq.Dispose();
            comboMinusName.DataSource = dtq;
            comboMinusName.DisplayMember = "HoTen"; // Thiết lập cột hiển thị
            comboMinusName.ValueMember = "HoTen"; // Thiết lập cột giá trị
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

        private void btnMinus_Click(object sender, EventArgs e)
        {
 
            MinusDTO member = new MinusDTO();
            string matvv = "";
            string ten = comboMinusName.SelectedValue.ToString();
            using (SqlCommand command = new SqlCommand("Select MaTV from THANHVIEN where HoTen = @HOTEN", conn))
            {
         
                command.Parameters.AddWithValue("@HOTEN", ten);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       matvv = reader.GetString(0);
                    }
                }
            }
            member.MATV = matvv;
            string mann = "";
            string tennn = comboMinusCause.SelectedValue.ToString();
            using (SqlCommand command = new SqlCommand("Select MaNNhan from NNMAT where LoaiNN = @LOAINN", conn))
            {

                command.Parameters.AddWithValue("@LOAINN", tennn);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mann = reader.GetString(0);
                    }
                }
            }
            member.NGAYMAT = DateTime.Parse(dateTimePickerMinus.Text);
            member.NNMAT = mann.ToString();
            string madd = "";
            string tendd = comboMinusPlace.SelectedValue.ToString();
            using (SqlCommand command = new SqlCommand("Select MaDD from DDMT where DiaDiem = @DIADIEM", conn))
            {

                command.Parameters.AddWithValue("@DIADIEM", tendd);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        madd = reader.GetString(0);
                    }
                }
            }
            member.DDMT = madd.ToString();
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
    }
}
