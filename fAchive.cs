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
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN9;Integrated Security=True");
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
            var cmd = new SqlCommand("Select TenTT from NHAPTT", conn);
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
            //string matvv = "";
            //string ten = comboAchiveName.SelectedValue.ToString();
            //using (SqlCommand command = new SqlCommand("Select MaTV from THANHVIEN where HoTen = @HOTEN", conn))
            //{

            //    command.Parameters.AddWithValue("@HOTEN", ten);


            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            matvv = reader.GetString(0);
            //        }
            //    }
            //}
            member.MATV = comboAchiveName.SelectedValue.ToString();

            string mattt = "";
            string tentt = comboAchiveType.SelectedValue.ToString();
            using (SqlCommand command = new SqlCommand("Select LOAITT from NHAPTT where TenTT = @Tentt", conn))
            {

                command.Parameters.AddWithValue("@Tentt", tentt);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mattt = reader.GetString(0);
                    }
                }
            }
            member.LOAITT = mattt.ToString();

            member.NGPSINHTT = DateTime.Parse(dateTimePickerAchive.Text);
            var querydemmatv = "Select count(*) from THANHTICH";
            var count1 = 0;
            using (SqlCommand command = new SqlCommand(querydemmatv, conn))
            {
                count1 = (int)command.ExecuteScalar();
            }
            member.MATT="ThanhTich"+count1.ToString();
            
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
    }
}
