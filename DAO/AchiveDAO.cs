using New_DOAN.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_DOAN.DAO
{
    internal class AchiveDAO
    {
        public AchiveDAO() { }
        public void SaveMinus(AchiveDTO member)
        {

            string connectionString = "Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN8;Integrated Security=True";
            string query = "INSERT INTO KETTHUC (MaTT, HoTen, LoaiTT, NgPSinhTT) VALUES (@MATT, @HOTEN, @LOAITT, @NGPSINHTT)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@MAKT", member.MATT);
                    command.Parameters.AddWithValue("@HOTEN", member.HOTEN);
                    command.Parameters.AddWithValue("@NGAYMAT", member.LOIATT);
                    command.Parameters.AddWithValue("@NNMAT", member.NGPSINHTT);

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
    }
}
