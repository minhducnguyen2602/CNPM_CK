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
        public bool CheckMaTVExists(string maTV)
        {
            string connectionString1 = "Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN10;Integrated Security=True";
            string query1 = "SELECT COUNT(*) FROM KETTHUC WHERE MaTV = @maTV";

            using (SqlConnection connection = new SqlConnection(connectionString1))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    command.Parameters.AddWithValue("@maTV", maTV);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
        public
        void SaveMinus(MinusDTO member)
        {
            string connectionString = "Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN10;Integrated Security=True";

            bool exists = CheckMaTVExists(member.MATV);
            if (exists)
            {

                string query = "UPDATE KETTHUC SET NgayMat= @NGAYMAT,  MaNNhan= @NNMAT, MaDD=@DDMT WHERE MaTV = @MATV";
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {

                        connection.Open();
                        command.Parameters.AddWithValue("@MATV", member.MATV);
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
            else
            {
                string query = "INSERT INTO KETTHUC (MaTV, NgayMat, MaNNhan, MaDD) VALUES (@MATV, @NGAYMAT, @NNMAT, @DDMT)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {

                        connection.Open();
                        command.Parameters.AddWithValue("@MAKT", member.MAKT);
                        command.Parameters.AddWithValue("@MATV", member.MATV);
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
}
