using DOANCNPM_1.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANCNPM_1.DAO
{
    class MemberDAO
    {
        private string connectionString = "Data Source=MSI;Initial Catalog=DOAN;Integrated Security=True"; // Chuỗi kết nối đến cơ sở dữ liệu

        public MemberDAO()
        {
            
        }

        public void SaveMember(MemberDTO member)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Members (MAQH, NGPSINH, HOTEN, GT, NGSINH, MAQQ, MANN, DIACHI) " +
                                   "VALUES (@MAQH, @NGPSINH, @HOTEN, @GT, @NGSINH, @MAQQ, @MANN, @DIACHI)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MAQH", member.MAQH);
                        command.Parameters.AddWithValue("@NGPSINH", member.NGPSINH);
                        command.Parameters.AddWithValue("@HOTEN", member.HOTEN);
                        command.Parameters.AddWithValue("@GT", member.GT);
                        command.Parameters.AddWithValue("@NGSINH", member.NGSINH);
                        command.Parameters.AddWithValue("@MAQQ", member.MAQQ);
                        command.Parameters.AddWithValue("@MANN", member.MANN);
                        command.Parameters.AddWithValue("@DIACHI", member.DIACHI);

                        command.ExecuteNonQuery();
                    }
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
