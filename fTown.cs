﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace New_DOAN
{
    public partial class frmTown : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN16;Integrated Security=True");
        public frmTown()
        {
            InitializeComponent();
            conn.Open();
        }
        void loadTOWN()
        {
            var cmd = new SqlCommand("Select TenQueQuan from QUEQUAN where TenQueQuan <> 'NONE'", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "TenQueQuan"; // Thiết lập cột hiển thị
            comboBox1.ValueMember = "TenQueQuan"; // Thiết lập cột giá trị
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }


        private void frmTown_Load(object sender, EventArgs e)
        {
            loadTOWN();
        }
    
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string add=txtAddValue.Text;
            string tencu = comboBox1.SelectedValue.ToString();
            string tenmoi = textBox1.Text;
            string connectionString = "Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN16;Integrated Security=True";

            string query1 = "UPDATE QUEQUAN\r\n\r\nSET TenQueQuan = @moi\r\n\r\nWHERE TenQueQuan = @cu";
            if (add != "")
            {
                var count1 = 0;
                var querydemmatv = "Select count(*) from QUEQUAN";
                using (SqlCommand command = new SqlCommand(querydemmatv, conn))
                {
                    count1 = (int)command.ExecuteScalar();
                }
                string matt = "q" + (count1 + 1).ToString();
                string checkQuery = "SELECT COUNT(*) FROM QUEQUAN WHERE TenQueQuan = @moi";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, conn))
                {
                    checkCommand.Parameters.AddWithValue("@moi", add);
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Đã tồn tại");
                        return;
                    }
                }
                string q = "INSERT INTO QUEQUAN (TenQueQuan) values (@TQQ)";
                using (SqlCommand command = new SqlCommand(q, conn))
                {
                    command.Parameters.AddWithValue("@TQQ", add);
                    command.Parameters.AddWithValue("@MQQ", matt);

                    command.ExecuteNonQuery();
                }
                loadTOWN();
                MessageBox.Show("Đã thêm quê quán");
            }
            else
            {
                if (tenmoi == "")
                {
                    errorProvider1.SetError(textBox1, "Thông tin trống");
                    return;
                }
                errorProvider1.Clear();
                if (tenmoi == tencu)
                {
                    MessageBox.Show("Đã tồn tại");
                    return;
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Kiểm tra nếu tên mới đã tồn tại trong tên cũ
                    string checkQuery = "SELECT COUNT(*) FROM QUEQUAN WHERE TenQueQuan = @moi";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@moi", tenmoi);
                        int count = (int)checkCommand.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Đã tồn tại");
                            return;
                        }
                    }

                    // Tiến hành cập nhật nếu không có tên mới trong tên cũ
                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                        command.Parameters.AddWithValue("@moi", tenmoi);
                        command.Parameters.AddWithValue("@cu", tencu);
                        command.ExecuteNonQuery();
                    }
                }
                loadTOWN();
                MessageBox.Show("Đã sửa");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string tencu = comboBox1.SelectedValue.ToString();
            int maaa = 0;
            string Matt = "SELECT MaQQ FROM QUEQUAN WHERE TenQueQuan = @moi";
            using (SqlCommand checkCommand = new SqlCommand(Matt, conn))
            {
                checkCommand.Parameters.AddWithValue("@moi", tencu);
                using (SqlDataReader reader = checkCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        maaa = reader.GetInt32(0); ;
                    }
                }
                string qqq = "SELECT COUNT(*) FROM THANHVIEN WHERE MaQQ = @ma";
                using (SqlCommand command = new SqlCommand(qqq, conn))
                {
                    command.Parameters.AddWithValue("@ma", maaa);
                    int cc = (int)command.ExecuteScalar();
                    if (cc > 0)
                    {
                        MessageBox.Show("Không thể xóa do đã được liên kết");
                        return;
                    }
                    else
                    {
                        string q = "DELETE FROM QUEQUAN WHERE TenQueQuan=@TTT";
                        using (SqlCommand ccommand = new SqlCommand(q, conn))
                        {
                            ccommand.Parameters.AddWithValue("@TTT", tencu);

                            ccommand.ExecuteNonQuery();
                        }
                        loadTOWN();
                        MessageBox.Show("Đã xóa quê quán");
                    }
                }
            }
        }
    }
}
