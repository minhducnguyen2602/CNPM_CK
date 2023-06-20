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
        public void SaveAchive(AchiveDTO member)
        {

            string connectionString = "Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN16;Integrated Security=True";
            string query = "INSERT INTO THANHTICH (MaTV, LoaiTT, NgPSinhTT) VALUES (@MATV, @LOAITT, @NGPSINHTT)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@MATT", member.MATT);
                    command.Parameters.AddWithValue("@MATV", member.MATV);
                    command.Parameters.AddWithValue("@LOAITT", member.LOAITT);
                    command.Parameters.AddWithValue("@NGPSINHTT", member.NGPSINHTT);
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
