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
    public partial class frmType : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=DOAN9;Integrated Security=True");
        public frmType()
        {
            InitializeComponent();
            conn.Open();
        }
        void loadTOWN()
        {
            var cmd = new SqlCommand("Select TenTT from NHAPTT", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "TenTT"; // Thiết lập cột hiển thị
            comboBox1.ValueMember = "TenTT"; // Thiết lập cột giá trị
        }
         private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmType_Load(object sender, EventArgs e)
        {
            loadTOWN();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            

            string tencu = comboBox1.SelectedValue.ToString();
            string tenmoi = textBox1.Text;
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

            string connectionString = "Data Source=MSI;Initial Catalog=DOAN9;Integrated Security=True";

            string query1 = "UPDATE NHAPTT\r\n\r\nSET TenTT = @moi\r\n\r\nWHERE TenTT = @cu";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Kiểm tra nếu tên mới đã tồn tại trong tên cũ
                string checkQuery = "SELECT COUNT(*) FROM NHAPTT WHERE TenTT = @moi";
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
}
