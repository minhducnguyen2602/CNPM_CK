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
using New_DOAN.DAO;
using New_DOAN.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Runtime.Remoting.Contexts;

namespace New_DOAN
{
    public partial class frmSearch : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN16;Integrated Security=True");

        public frmSearch()
        {
            InitializeComponent();
            conn.Open();

        }
        private void frmSearch_Load(object sender, EventArgs e)
        {
            

        }
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            if (dtp.Value == dtp.MinDate)
            {
                dtp.CustomFormat = "";
            }
            else
            {
                dtp.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int intValue;
            string madh = "";
            string ten = txtName.Text;
            string tennn = txtJob.Text;
            string tenqq = txtHometown.Text;
            string mann = "";

            int count = 0;
            using (SqlCommand commanddd = new SqlCommand("SELECT COUNT(*) FROM NGHENGHIEP WHERE TenNN = @MemberCode", conn))
            {
                commanddd.Parameters.AddWithValue("@MemberCode", tennn);
                count = (int)commanddd.ExecuteScalar();

            }
            int count11 = 0;
            using (SqlCommand commanddd = new SqlCommand("SELECT COUNT(*) FROM QUEQUAN WHERE TenQueQuan = @MemberCode", conn))
            {
                commanddd.Parameters.AddWithValue("@MemberCode", tenqq);
                count11 = (int)commanddd.ExecuteScalar();

            }
            
            if (!string.IsNullOrEmpty(tennn) && count != 0)
            {
               
                using (SqlCommand commandđ = new SqlCommand("SELECT MaNNghiep FROM NGHENGHIEP WHERE TenNN = @NGHENGHIEP", conn))
                {
                    commandđ.Parameters.AddWithValue("@NGHENGHIEP", tennn);

                    using (SqlDataReader reader = commandđ.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                          
                            mann = reader.GetInt32(0).ToString();
                        }
                    }
                }
            }

            string maqq = "";

            if (!string.IsNullOrEmpty(tenqq) && count11 != 0)
            {
                using (SqlCommand commandd = new SqlCommand("SELECT MaQQ FROM QUEQUAN WHERE TenQueQuan = @QUEQUAN", conn))
                {
                    commandd.Parameters.AddWithValue("@QUEQUAN", tenqq);

                    using (SqlDataReader reader = commandd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            maqq = reader.GetInt32(0).ToString();
                        }
                    }
                }
            }
            

            string namsinh = textBox1.Text;
            if (namsinh!=""&&(!int.TryParse(namsinh, out intValue)))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox1, "Sai dữ liệu");
                return;
            }
            using (SqlCommand command1 = new SqlCommand("SELECT MaQH FROM THANHVIEN WHERE HoTen = @HOTEN", conn))
            {
                command1.Parameters.AddWithValue("@HOTEN", ten);

                using (SqlDataReader reader = command1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        madh = reader.GetString(0);
                    }
                }
            }

            
            string query = "SELECT MaTV, HoTen, Doi,\r\n       CASE WHEN MaQH = 'qh1' THEN (SELECT HoTen FROM Thanhvien t2 WHERE t2.MaTV = t1.TVCu)\r\n            WHEN MaQH = 'qh2' THEN (SELECT HoTen FROM Thanhvien t3 WHERE t3.MaTV = (SELECT TVCu FROM Thanhvien t4 WHERE t4.MaTV = t3.TVCu))\r\n       END AS TVCU\r\nFROM Thanhvien t1\r\nWHERE (@MANN <> '' OR @TENTV <> '' OR @MAQQ <> '' OR @NGAYSINH <> '')\r\n    AND (MaNNghiep = @MANN OR @MANN = '')\r\n    AND (HoTen = @TENTV OR @TENTV = '')\r\n    AND (MaQQ = @MAQQ OR @MAQQ = '')\r\n    AND (YEAR(NgSinh) = YEAR(@NGAYSINH) OR @NGAYSINH = '');";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@TENTV", ten);
            command.Parameters.AddWithValue("@MANN", mann);
            command.Parameters.AddWithValue("@MAQQ", maqq);
            command.Parameters.AddWithValue("@NGAYSINH", namsinh);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dtgvSearch.DataSource = data;
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void lblOccurrenceDate_Click(object sender, EventArgs e)
        {

        }
    }
}
