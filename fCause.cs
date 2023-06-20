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
namespace New_DOAN
{
    public partial class frmCause : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN16;Integrated Security=True");
        public frmCause()
        {
            InitializeComponent();
            conn.Open();
        }
        void loadTOWN()
        {
            var cmd = new SqlCommand("Select LoaiNN from NNMAT WHERE LoaiNN <> 'NONE'", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "LoaiNN"; // Thiết lập cột hiển thị
            comboBox1.ValueMember = "LoaiNN"; // Thiết lập cột giá trị
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCause_Load(object sender, EventArgs e)
        {
            loadTOWN();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string add = txtAddValue.Text;
            string tencu = comboBox1.SelectedValue.ToString();
            string tenmoi = textBox1.Text;
            string connectionString = "Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN16;Integrated Security=True";

            string query1 = "UPDATE NNMAT\r\n\r\nSET LoaiNN = @moi\r\n\r\nWHERE LoaiNN = @cu";
            if(add!="")
            {
                var count1 = 0;
                var querydemmatv = "Select count(*) from NNMAT";
                using (SqlCommand command = new SqlCommand(querydemmatv, conn))
                {
                    count1 = (int)command.ExecuteScalar();
                }
                string mann = "nn" + (count1 + 1).ToString();
                string checkQuery = "SELECT COUNT(*) FROM NNMAT WHERE LoaiNN = @moi";
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
                string q = "INSERT INTO NNMAT (LoaiNN) values (@LNN)";
                using (SqlCommand command = new SqlCommand(q, conn))
                {
                    command.Parameters.AddWithValue("@MNN", mann);
                    command.Parameters.AddWithValue("@LNN", add);

                    command.ExecuteNonQuery();
                }
                loadTOWN();
                MessageBox.Show("Đã thêm thành tích");
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
                    string checkQuery = "SELECT COUNT(*) FROM NNMAT WHERE LoaiNN = @moi";
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
            string Mann = "SELECT MaNNhan FROM NNMAT WHERE LoaiNN = @moi";
            using (SqlCommand checkCommand = new SqlCommand(Mann, conn))
            {

                checkCommand.Parameters.AddWithValue("@moi", tencu);
                using (SqlDataReader reader = checkCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        maaa = reader.GetInt32(0); ;
                    }
                }
                string qq = "SELECT COUNT(*) FROM KETTHUC WHERE MaNNhan = @ma";
                using (SqlCommand command = new SqlCommand(qq, conn))
                {
                    command.Parameters.AddWithValue("@ma", maaa);
                    int cc = (int)command.ExecuteScalar();
                    if (cc > 0)
                    {
                        MessageBox.Show("Không thể xóa do đã tồn tại");
                        return;
                    }
                    else
                    {
                        string q = "DELETE FROM NNMAT WHERE LoaiNN=@TTT";
                        using (SqlCommand ccommand = new SqlCommand(q, conn))
                        {
                            ccommand.Parameters.AddWithValue("@TTT", tencu);

                            ccommand.ExecuteNonQuery();
                        }
                        loadTOWN();
                        MessageBox.Show("Đã xóa nguyên nhân");
                    }
                }
            }
        }
    }
}
