using New_DOAN.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_DOAN.DAO
{
    class MemberDAO
    {

        public MemberDAO()
        {
            
        }
    
        
        public void SaveMember(MemberDTO member)
        {

            string connectionString = "Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN8;Integrated Security=True";
            string query = "INSERT INTO THANHVIEN (MaTV, HoTen, NgPSinh, GioiTinh, MaNNghiep, DiaChi, TVCu, MaQH, MaQQ, NgSinh, Doi) VALUES (@MATV, @HOTEN, @NGPSINH, @GT, @MANN, @DIACHI, @TVCU, @MAQH, @MAQQ, @NGSINH, @Doi)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {

                    connection.Open();
                    command.Parameters.AddWithValue("@MATV", member.MATV);
                    command.Parameters.AddWithValue("@HOTEN", member.HOTEN);
                    command.Parameters.AddWithValue("@NGPSINH", member.NGPSINH);
                    command.Parameters.AddWithValue("@GT", member.GT);
                    command.Parameters.AddWithValue("@MANN", member.MANN);
                    command.Parameters.AddWithValue("@DIACHI", member.DIACHI);
                    command.Parameters.AddWithValue("@TVCU", member.TVCU);
                    command.Parameters.AddWithValue("@MAQH", member.MAQH);
                    command.Parameters.AddWithValue("@MAQQ", member.MAQQ);
                    command.Parameters.AddWithValue("@NGSINH", member.NGSINH);
                    command.Parameters.AddWithValue("@DOI", member.DOI);
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

        public void SaveRoot(MemberDTO member)
        {

            string connectionString = "Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN8;Integrated Security=True";
            string query = "INSERT INTO THANHVIEN (MaTV, HoTen, NGPSINH, GioiTinh, MaNNghiep, DiaChi, TVCu, MaQH, MaQQ, NgSinh, Doi) VALUES (@MATV, @HOTEN, @NGPSINH, @GT, @MANN, @DIACHI, @TVCU, @MAQH, @MAQQ, @NGSINH, @DOI)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@MATV", member.MATV);
                    command.Parameters.AddWithValue("@HOTEN", member.HOTEN);
                    command.Parameters.AddWithValue("@NGPSINH", member.NGPSINH);
                    command.Parameters.AddWithValue("@GT", member.GT);
                    command.Parameters.AddWithValue("@MANN", member.MANN);
                    command.Parameters.AddWithValue("@DIACHI", member.DIACHI);
                    command.Parameters.AddWithValue("@TVCU", "NONE");
                    command.Parameters.AddWithValue("@MAQH", member.MAQH);
                    command.Parameters.AddWithValue("@MAQQ", member.MAQQ);
                    command.Parameters.AddWithValue("@NGSINH", member.NGSINH);
                    command.Parameters.AddWithValue("@DOI", member.DOI);


                    command.ExecuteNonQuery();

                    // Thông báo thành công
                    MessageBox.Show("Tên đăng nhập của bạn là: " + member.HOTEN.ToString() + " , mật khẩu là: 1");

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
