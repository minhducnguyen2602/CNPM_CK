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
    internal class MinusDAO
    {
        public MinusDAO() { }
        public void SaveMinus(MinusDTO member)
        {

            string connectionString = "Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN8;Integrated Security=True";
            string query = "INSERT INTO KETTHUC (MaKT, MaTV, NgayMat, MaNNhan, MaDD) VALUES (@MAKT, @HOTEN, @NGAYMAT, @NNMAT, @DDMT)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@MAKT", member.MAKT);
                    command.Parameters.AddWithValue("@HOTEN", member.HOTEN);
                    command.Parameters.AddWithValue("@NGAYMAT", member.NGAYMAT);
                    command.Parameters.AddWithValue("@NNMAT", member.NNMAT);
                    command.Parameters.AddWithValue("@DDMT", member.DDMT);

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
