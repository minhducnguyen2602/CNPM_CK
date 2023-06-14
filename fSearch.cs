using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using New_DOAN.DAO;
using New_DOAN.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace New_DOAN
{
    public partial class frmSearch : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN8;Integrated Security=True");
        private MemberDAO memberDAO;
        public DataGridView MemberDataGridView { get; set; }

        public frmSearch()
        {
            InitializeComponent();
            memberDAO = new MemberDAO();
            conn.Open();

        }
        public void LoadMemberList1(string query)
        {
            
            if (MemberDataGridView != null)
            {
                MemberDataGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
        }
        void loadTVcu()
        {
            var cmdq = new SqlCommand("Select HoTen from THANHVIEN", conn);
            var drq = cmdq.ExecuteReader();
            var dtq = new DataTable();
            dtq.Load(drq);
            drq.Dispose();
            comboSearchName.DataSource = dtq;
            comboSearchName.DisplayMember = "HoTen"; // Thiết lập cột hiển thị
            comboSearchName.ValueMember = "HoTen"; // Thiết lập cột giá trị
        }
        private void frmSearch_Load(object sender, EventArgs e)
        {

            loadTVcu();

        }

        private void comboSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ten = comboSearchName.SelectedValue.ToString();
            string query = "Select * from THANHVIEN WHERE HoTen = @HOTEN";
            using (SqlCommand command = new SqlCommand("Select HoTen from THANHVIEN where HoTen = @HOTEN", conn))
            {
                // Thêm tham số @HOTEN và giá trị của biến vào câu truy vấn
                command.Parameters.AddWithValue("@HOTEN", ten);

            }
            LoadMemberList1(query);
        }
    }
}
