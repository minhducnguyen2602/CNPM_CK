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
    public partial class fLogin : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN9;Integrated Security=True");
        public fLogin()
        {
            InitializeComponent();
            txtAccount.Text = "";
            txtPassword.Text = "";
            conn.Open();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string madd = "";
            string tendd = "TV0";
            
            using (SqlCommand command = new SqlCommand("Select HoTen from THANHVIEN where MaTV = @DIADIEM", conn))
            {

                command.Parameters.AddWithValue("@DIADIEM", tendd);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        madd = reader.GetString(0);
                    }
                }
            }

            if (txtAccount.Text != madd)
            {
  
                errorProvider1.SetError(txtAccount, "Bạn chưa điền tên đăng nhập/Tên đăng nhập sai");
            }    
                
            else
            {

                errorProvider1.Clear();
                if (txtPassword.Text != "1")
                    errorProvider1.SetError(txtPassword, "Bạn chưa nhập mật khẩu/Sai mật khẩu");
                else
                {

                    frmMain f = new frmMain();
                    this.Hide();
                    f.ShowDialog();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi phần mềm không?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreate f = new frmCreate();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
