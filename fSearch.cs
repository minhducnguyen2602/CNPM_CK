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
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN10;Integrated Security=True");

        public frmSearch()
        {
            InitializeComponent();
            conn.Open();

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
            string madh = "";
            string tendh = comboSearchName.SelectedValue.ToString();
            using (SqlCommand command1 = new SqlCommand("Select MaQH from THANHVIEN where HoTen = @HOTEN", conn))
            {

                command1.Parameters.AddWithValue("@HOTEN", tendh);


                using (SqlDataReader reader = command1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        madh = reader.GetString(0);
                    }
                }
            }
            string query = "";
            if (madh == "qh0")
            {
                query = "SELECT HoTen AS 'Họ Tên', NgSinh AS 'Ngày Sinh', Doi AS 'Đời', @TVCU AS 'Cha/Mẹ' FROM THANHVIEN WHERE HoTen = @HoTen";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@HoTen", tendh);
                command.Parameters.AddWithValue("@TVCU", "NONE");
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                dtgvSearch.DataSource = data;
            }
            else if (madh == "qh1")
            {

                query = "SELECT T1.HoTen AS 'Họ Tên', T1.NgSinh AS 'Ngày Sinh', T1.Doi AS 'Đời', T2.HoTen AS 'Cha/Mẹ'\r\nFROM THANHVIEN T1\r\nJOIN THANHVIEN T2 ON T1.TVCu = T2.Matv\r\nWHERE T1.HoTen = @HOTEN;";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@HoTen", tendh);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                dtgvSearch.DataSource = data;
            }
            else
            {
                string tenchong = "";
                string tenbochong = "";
                using (SqlCommand command1 = new SqlCommand("Select TVCu from THANHVIEN where HoTen = @HOTEN", conn))
                {

                    command1.Parameters.AddWithValue("@HOTEN", tendh);


                    using (SqlDataReader reader = command1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tenchong = reader.GetString(0);
                        }
                    }
                }
                using (SqlCommand command1 = new SqlCommand("Select TVCu from THANHVIEN where MaTV = @HOTENCHONG", conn))
                {

                    command1.Parameters.AddWithValue("@HOTENCHONG", tenchong);


                    using (SqlDataReader reader = command1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tenbochong = reader.GetString(0);
                        }
                    }
                }
                string tenbochong1 = "";
                using (SqlCommand command1 = new SqlCommand("Select HoTen from THANHVIEN where MaTV = @HOTENCHONG", conn))
                {

                    command1.Parameters.AddWithValue("@HOTENCHONG", tenbochong);


                    using (SqlDataReader reader = command1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tenbochong1 = reader.GetString(0);
                        }
                    }
                }
                if (tenchong == "TV0")
                {
                    tenbochong1 = "NONE";
                }    
                query = "SELECT HoTen AS 'Họ Tên', NgSinh AS 'Ngày Sinh', Doi AS 'Đời', @tenchong AS 'Cha/Mẹ' FROM THANHVIEN WHERE HoTen = @HoTen";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@HoTen", tendh);
                command.Parameters.AddWithValue("@tenchong", tenbochong1);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                dtgvSearch.DataSource = data;

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblOccurrenceDate_Click(object sender, EventArgs e)
        {

        }
    }
}
