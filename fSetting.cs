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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace New_DOAN
{
    public partial class frmSetting : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=DOAN9;Integrated Security=True");
        private MemberDAO memberDAO;

        public object MemberDataGridView { get; private set; }

        public frmSetting()
        {
            InitializeComponent();
            memberDAO = new MemberDAO();
            conn.Open();
        }
        
        void loadMaTV()
        {
            var cmdq = new SqlCommand("Select MaTV from THANHVIEN", conn);
            var drq = cmdq.ExecuteReader();
            var dtq = new DataTable();
            dtq.Load(drq);
            drq.Dispose();
            comboMaTV.DataSource = dtq;
            comboMaTV.DisplayMember = "MaTV"; // Thiết lập cột hiển thị
            comboMaTV.ValueMember = "MaTV"; // Thiết lập cột giá trị
        }
        void loadNN()
        {
            var cmdq = new SqlCommand("SELECT TenNN from NGHENGHIEP", conn);
            var drq = cmdq.ExecuteReader();
            var dtq = new DataTable();
            dtq.Load(drq);
            drq.Dispose();
            comboMemberJob.DataSource = dtq;
            comboMemberJob.DisplayMember = "TenNN"; // Thiết lập cột hiển thị
            comboMemberJob.ValueMember = "TenNN"; // Thiết lập cột giá trị
        }
        void loadQQ()
        {
            var cmdq = new SqlCommand("Select TenQueQuan from QUEQUAN", conn);
            var drq = cmdq.ExecuteReader();
            var dtq = new DataTable();
            dtq.Load(drq);
            drq.Dispose();
            comboTown.DataSource = dtq;
            comboTown.DisplayMember = "TenQueQuan"; // Thiết lập cột hiển thị
            comboTown.ValueMember = "TenQueQuan"; // Thiết lập cột giá trị
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            MemberDTO newMember = new MemberDTO();
            string hoten = comboMaTV.SelectedValue.ToString();
            string mann = "";
            string tennn = comboMemberJob.SelectedValue.ToString();
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
            string tenqq = comboTown.SelectedValue.ToString();
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
            string connectionString = "Data Source=MSI;Initial Catalog=DOAN9;Integrated Security=True";
            string query = "UPDATE THANHVIEN SET MaNNghiep = @MANN, MaQQ = @MAQQ WHERE MaTV = @MATV";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@MANN", mann);
                    command.Parameters.AddWithValue("@MAQQ", maqq);
                    command.Parameters.AddWithValue("@MATV", hoten);

                    command.ExecuteNonQuery();

                    // Thông báo thành công
                    MessageBox.Show("Dữ liệu đã được gửi thành công!");

                }
                catch (Exception ex)
                {
                    // Handle the exception appropriately (e.g., show an error message)
                    Console.WriteLine("An error occurred while saving member: " + ex.Message);
                }
            }

        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            loadMaTV();
            loadNN();
            loadQQ();
        }
    }
}
