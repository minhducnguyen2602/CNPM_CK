using New_DOAN.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_DOAN
{
    public partial class frmReport : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN8;Integrated Security=True");
        public DataGridView MemberDataGridView { get; set; }

        public frmReport()
        {
            InitializeComponent();
            conn.Open();
            LoadMemberList1();
        }

        public void LoadMemberList1()
        {
            string query = "Select * from THANHTICH";
            if (MemberDataGridView != null)
            {
                MemberDataGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
        }

        private void btnBorn_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            int avalue = Convert.ToInt32(a);
            int bvalue = Convert.ToInt32(b);
            string query2 = "DECLARE @NamTable TABLE (Nam INT);\r\nINSERT INTO @NamTable (Nam)\r\nSELECT TOP (@NamKetThuc - @NamBatDau + 1)\r\n    ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) + @NamBatDau - 1\r\nFROM sys.columns;\r\n\r\n-- Truy vấn kết quả\r\nSELECT \r\n    N.Nam AS 'Năm',\r\n    COALESCE(A.SoLuongSinh, 0) AS 'Số lượng sinh',\r\n    COALESCE(A.SoLuongKetHon, 0) AS 'Số lượng kết hôn',\r\n    COALESCE(B.SoNgayMat, 0) AS 'Ngày Mất'\r\nFROM\r\n    @NamTable N\r\nLEFT JOIN\r\n    (\r\n    SELECT \r\n        YEAR(NgPSinh) AS NamSinh,\r\n        COUNT(CASE WHEN MaQH = 'qh1' THEN 1 END) AS SoLuongSinh,\r\n       COUNT(CASE WHEN MaQH = 'qh2' THEN 1 END) AS SoLuongKetHon\r\n    FROM\r\n        THANHVIEN AS TV\r\n    full JOIN\r\n        KETTHUC AS KT ON TV.MaTV = KT.MaTV\r\n    WHERE\r\n        YEAR(NgPSinh) BETWEEN @NamBatDau AND @NamKetThuc\r\n    GROUP BY\r\n        YEAR(NgPSinh)\r\n    ) AS A ON N.Nam = A.NamSinh\r\nLEFT JOIN\r\n    (\r\n    SELECT \r\n        YEAR(NgayMat) AS NamMat,\r\n        COUNT(NgayMat) AS SoNgayMat\r\n    FROM\r\n        KETTHUC\r\n    WHERE\r\n        YEAR(NgayMat) BETWEEN @NamBatDau AND @NamKetThuc\r\n    GROUP BY\r\n        YEAR(NgayMat)\r\n    ) AS B ON N.Nam = B.NamMat;\r\n";
            using (SqlCommand cmd = new SqlCommand(query2, conn))
            {
                cmd.Parameters.AddWithValue("@NamBatDau", avalue);
                cmd.Parameters.AddWithValue("@NamKetThuc", bvalue);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                dtgvReport.DataSource = data;

            }
        }

        private void btnAchive_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            int avalue= Convert.ToInt32(a);
            int bvalue= Convert.ToInt32(b);
            string query2 = "select TenTT as 'Loại Thành Tích' ,count(MaTT) as 'Số Lượng' from THANHTICH as TT join NHAPTT as NTT on TT.LoaiTT = NTT.LoaiTT where @a <= Year(NgPSinhTT) and Year(NgPSinhTT) <= @b group by TenTT";
            using (SqlCommand cmd = new SqlCommand(query2, conn))
            {
                cmd.Parameters.AddWithValue("@a", avalue);
                cmd.Parameters.AddWithValue("@b", bvalue);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                dtgvReport.DataSource = data;

            }
           
        }
    }
}
