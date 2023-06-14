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
            member.HOTEN = comboMinusName.SelectedValue.ToString();
            member.NGAYMAT = DateTime.Parse(dateTimePickerMinus.Text);
            member.NNMAT = comboMinusCause.SelectedValue.ToString();
            member.DDMT = comboMinusPlace.SelectedValue.ToString();
            member.MAKT = member.HOTEN;
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
