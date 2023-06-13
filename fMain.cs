using doanQLGP.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANCNPM_1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            LoadMemberList();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
       
        void LoadMemberList()
        {
            string query = "Select * from THANHVIEN";
            DataProvider provider = new DataProvider();
            dtgvMember.DataSource = provider.ExecuteQuery(query);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fmADD f = new fmADD();
            f.ShowDialog();
            this.Show();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnAchive_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes) this.Close();
        }
    }
}
