using New_DOAN.DAO;
using New_DOAN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace New_DOAN
{
    public partial class frmSetting : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN16;Integrated Security=True");
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
        void loadTVcu()
        {
            var cmdq = new SqlCommand("Select MaTV from THANHVIEN", conn);
            var drq = cmdq.ExecuteReader();
            var dtq = new DataTable();
            dtq.Load(drq);
            drq.Dispose();
            comboExistingMember.DataSource = dtq;
            comboExistingMember.DisplayMember = "MaTV"; // Thiết lập cột hiển thị
            comboExistingMember.ValueMember = "MaTV"; // Thiết lập cột giá trị
        }
        void loadQH()
        {
            var cmdq = new SqlCommand("SELECT LoaiQH\r\nFROM (\r\n  SELECT LoaiQH, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum\r\n  FROM QUANHE\r\n) AS T\r\nWHERE RowNum > 1;\r\n", conn);
            var drq = cmdq.ExecuteReader();
            var dtq = new DataTable();
            dtq.Load(drq);
            drq.Dispose();
            comboRelationship.DataSource = dtq;
            comboRelationship.DisplayMember = "LoaiQH"; // Thiết lập cột hiển thị
            comboRelationship.ValueMember = "LoaiQH"; // Thiết lập cột giá trị
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MemberDTO newMember = new MemberDTO();
            //string hoten = comboMaTV.SelectedValue.ToString();
            //string mann = "";
            //string tennn = comboMemberJob.SelectedValue.ToString();
            //using (SqlCommand command = new SqlCommand("Select MaNNghiep from NGHENGHIEP where TenNN = @NGHENGHIEP", conn))
            //{

            //    command.Parameters.AddWithValue("@NGHENGHIEP", tennn);


            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            mann = reader.GetString(0);
            //        }
            //    }
            //}
            //string maqq = "";
            //string tenqq = comboTown.SelectedValue.ToString();
            //using (SqlCommand command = new SqlCommand("Select MaQQ from QUEQUAN where TenQueQuan = @QUEQUAN", conn))
            //{

            //    command.Parameters.AddWithValue("@QUEQUAN", tenqq);


            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            maqq = reader.GetString(0);
            //        }
            //    }
            //}
            //string connectionString = "Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN16;Integrated Security=True";
            //string query = "UPDATE THANHVIEN SET MaNNghiep = @MANN, MaQQ = @MAQQ, NgSinh = @NgSinh, GioiTinh = @GioiTinh, TVCu = @TVCU, WHERE MaTV = @MATV";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //using (SqlCommand command = new SqlCommand(query, conn))
            //{
            //    try
            //    {
            //        connection.Open();
            //        command.Parameters.AddWithValue("@MANN", mann);
            //        command.Parameters.AddWithValue("@MAQQ", maqq);
            //        command.Parameters.AddWithValue("@MATV", hoten);

            //        command.ExecuteNonQuery();

            //        // Thông báo thành công
            //        MessageBox.Show("Dữ liệu đã được gửi thành công!");

            //    }
            //    catch (Exception ex)
            //    {
            //        // Handle the exception appropriately (e.g., show an error message)
            //        Console.WriteLine("An error occurred while saving member: " + ex.Message);
            //    }
            //}
            conn.Close();
            string matv = comboMaTV.SelectedValue.ToString();
            string matvcu = comboExistingMember.SelectedValue.ToString();
            string maqh = comboRelationship.SelectedValue.ToString();
            string ten = txtFullName.Text;
            string gioitinh = comboBoxGT.SelectedItem.ToString();
            string mann = comboMemberJob.SelectedValue.ToString();
            string maqq = comboTown.SelectedValue.ToString();
            string diachi = txtAddress.Text;
            DateTime ngps = DateTime.Parse(dateTimePickerphatsinh.Text);
            DateTime ngs = DateTime.Parse(dateTimePickerBirth.Text);
            if (matv == "TV0" && matvcu != "TV0")
            {
                MessageBox.Show("Sửa đổi thành viên gốc thì thành viên cũ phải là 'TV0'");
                return;
            }
            int qq = 0;
            using (SqlCommand commandd = new SqlCommand("Select MaQQ from QUEQUAN where TenQueQuan = @QUEQUAN", conn))
            {

                commandd.Parameters.AddWithValue("@QUEQUAN", maqq);

                conn.Open();
                using (SqlDataReader readerr = commandd.ExecuteReader())
                {
                    while (readerr.Read())
                    {
                        qq = readerr.GetInt32(0);
                    }
                }
            }
            conn.Close();
            string qh = "";
            using (SqlCommand commandd = new SqlCommand("Select MaQH from QUANHE where LoaiQH = @QH", conn))
            {

                commandd.Parameters.AddWithValue("@QH", maqh);

                conn.Open();
                using (SqlDataReader readerr = commandd.ExecuteReader())
                {
                    while (readerr.Read())
                    {
                        qh = readerr.GetString(0);
                    }
                }
            }
            conn.Close();
            int nn = 0;
            using (SqlCommand commandd = new SqlCommand("Select MaNNghiep from NGHENGHIEP where TenNN = @NN", conn))
            {

                commandd.Parameters.AddWithValue("@NN", mann);
                conn.Open();

                using (SqlDataReader readerr = commandd.ExecuteReader())
                {
                    while (readerr.Read())
                    {
                        nn = readerr.GetInt32(0);
                    }
                }
            }
            if (matv == "TV0")
            {
                qh = "QH0";
            }
            conn.Close();
            string query = "update THANHVIEN set TVCu = @matvcu, MaQH = @maqh, NgPSinh = @ngps, HoTen = @hoten, GioiTinh = @gt, NgSinh = @ngs, MaNNghiep = @mann, MaQQ = @maqq, DiaChi = @DiaChi where MaTV = @matv";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@matvcu", matvcu);
            command.Parameters.AddWithValue("@maqh", qh);
            command.Parameters.AddWithValue("@ngps", ngps);
            command.Parameters.AddWithValue("@hoten", ten);
            command.Parameters.AddWithValue("@gt", gioitinh);
            command.Parameters.AddWithValue("@ngs", ngs);
            command.Parameters.AddWithValue("@mann", nn);
            command.Parameters.AddWithValue("@maqq", qq);
            command.Parameters.AddWithValue("@DiaChi", diachi);
            command.Parameters.AddWithValue("@matv", matv);

            if (conn.State != ConnectionState.Open)
                conn.Open();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

        }


        private void frmSetting_Load(object sender, EventArgs e)
        {
            loadMaTV();
            loadNN();
            loadQQ();
            loadTVcu();
            loadQH();
        }



        private void comboMaTV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string hoten = comboMaTV.SelectedValue.ToString();
            string queryyyy = "SELECT TVCu, MaQH, HoTen, GioiTinh, NgSinh, MaNNghiep, MaQQ, DiaChi, NgPSinh FROM THANHVIEN WHERE MaTV = @MemberId";
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN16;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryyyy, connection))
                {
                    command.Parameters.AddWithValue("@MemberId", hoten);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            DateTime ngaySinh = Convert.ToDateTime(reader["NgSinh"]);
                            string tvcu = reader["TVCu"].ToString();
                            string gioitinh = reader["GioiTinh"].ToString();
                            string mann = reader["MaNNghiep"].ToString();
                            string maqq = reader["MaQQ"].ToString();
                            string diachi = reader["DiaChi"].ToString();
                            string hotenn = reader["HoTen"].ToString();
                            string maqh = reader["MaQH"].ToString();
                            DateTime ngps = Convert.ToDateTime(reader["NgPSinh"]);
                            conn.Close();
                            // Gán giá trị đề xuất cho các ô tương ứng
                            string hoteenn = "";
                            using (SqlCommand commandd = new SqlCommand("Select HoTen from THANHVIEN where MaTV = @tvcu", conn))
                            {

                                commandd.Parameters.AddWithValue("@tvcu", tvcu);
                                conn.Open();

                                using (SqlDataReader readerr = commandd.ExecuteReader())
                                {
                                    while (readerr.Read())
                                    {
                                        hoteenn = readerr.GetString(0);
                                    }
                                }
                            }

                            conn.Close();
                            string hoteen = "";
                            using (SqlCommand commandd = new SqlCommand("Select MaTV from THANHVIEN where HoTen = @tvcu", conn))
                            {

                                commandd.Parameters.AddWithValue("@tvcu", hoteenn);
                                conn.Open();

                                using (SqlDataReader readerr = commandd.ExecuteReader())
                                {
                                    while (readerr.Read())
                                    {
                                        hoteen = readerr.GetString(0);
                                    }
                                }
                            }

                            conn.Close();
                            string qq = "";
                            using (SqlCommand commandd = new SqlCommand("Select TenQueQuan from QUEQUAN where MaQQ = @QUEQUAN", conn))
                            {

                                commandd.Parameters.AddWithValue("@QUEQUAN", maqq);

                                conn.Open();
                                using (SqlDataReader readerr = commandd.ExecuteReader())
                                {
                                    while (readerr.Read())
                                    {
                                        qq = readerr.GetString(0);
                                    }
                                }
                            }
                            conn.Close();
                            string qh = "";
                            using (SqlCommand commandd = new SqlCommand("Select LoaiQH from QUANHE where MaQH = @QH", conn))
                            {

                                commandd.Parameters.AddWithValue("@QH", maqh);

                                conn.Open();
                                using (SqlDataReader readerr = commandd.ExecuteReader())
                                {
                                    while (readerr.Read())
                                    {
                                        qh = readerr.GetString(0);
                                    }
                                }
                            }
                            conn.Close();
                            string nn = "";
                            using (SqlCommand commandd = new SqlCommand("Select TenNN from NGHENGHIEP where MaNNghiep = @NN", conn))
                            {

                                commandd.Parameters.AddWithValue("@NN", mann);

                                conn.Open();
                                using (SqlDataReader readerr = commandd.ExecuteReader())
                                {
                                    while (readerr.Read())
                                    {
                                        nn = readerr.GetString(0);
                                    }
                                }
                            }

                            comboTown.Text = qq;
                            comboBoxGT.Text = gioitinh;
                            comboExistingMember.Text = hoteen;
                            comboRelationship.Text = qh;
                            txtAddress.Text = diachi;
                            txtFullName.Text = hotenn;
                            comboMemberJob.Text = nn;
                            dateTimePickerBirth.Value = ngaySinh;
                            dateTimePickerphatsinh.Value = ngps;

                        }
                    }
                }
            }
        }
    }
}
