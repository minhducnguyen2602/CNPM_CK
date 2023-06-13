using DOANCNPM_1.DAO;
using DOANCNPM_1.DTO;
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

namespace DOANCNPM_1
{
    public partial class fmADD : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-099VP89G;Initial Catalog=DOAN2;Integrated Security=True");
        private MemberDAO memberDAO;

        public fmADD()
        {
            InitializeComponent();
            memberDAO = new MemberDAO();
            conn.Open();
        }

        void loadNghe()
        {
            var cmd = new SqlCommand("Select TenNN from NGHENGHIEP", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            comboJob.DataSource = dt;
            comboJob.DisplayMember = "TenNN"; // Thiết lập cột hiển thị
            comboJob.ValueMember = "TenNN"; // Thiết lập cột giá trị
        }

        void loadQue()
        {
            var cmdq = new SqlCommand("Select TenQueQuan from QUEQUAN", conn);
            var drq = cmdq.ExecuteReader();
            var dtq = new DataTable();
            dtq.Load(drq);
            drq.Dispose();
            comboBoxQue.DataSource = dtq;
            comboBoxQue.DisplayMember = "TenQueQuan"; // Thiết lập cột hiển thị
            comboBoxQue.ValueMember = "TenQueQuan"; // Thiết lập cột giá trị
        }

        void loadTVcu()
        {
            var cmdq = new SqlCommand("Select HoTen from THANHVIEN", conn);
            var drq = cmdq.ExecuteReader();
            var dtq = new DataTable();
            dtq.Load(drq);
            drq.Dispose();
            comboExistingMember.DataSource = dtq;
            comboExistingMember.DisplayMember = "HoTen"; // Thiết lập cột hiển thị
            comboExistingMember.ValueMember = "HoTen"; // Thiết lập cột giá trị
        }

        private void btnAddMem_Click(object sender, EventArgs e)
        {
            MemberDTO newMember = new MemberDTO();
            if (comboExistingMember.SelectedItem != null)
            {
                newMember.TVCU = comboExistingMember.SelectedValue.ToString(); // Lấy giá trị từ cột giá trị
            }
            newMember.MAQH = comboRelationship.SelectedItem.ToString();
            newMember.NGPSINH = DateTime.Parse(dateTimePickerOccurred.Text);
            newMember.HOTEN = txtFullName.Text;
            newMember.GT = radMale.Checked;
            newMember.NGSINH = DateTime.Parse(dateTimePickerBirth.Text);
            newMember.MAQQ = comboBoxQue.SelectedValue.ToString(); // Lấy giá trị từ cột giá trị
            newMember.MANN = comboJob.SelectedValue.ToString(); // Lấy giá trị từ cột giá trị
            newMember.DIACHI = textBoxDiachi.Text;
            newMember.MATV = newMember.HOTEN;
            memberDAO.SaveMember(newMember);
        }

        private void fmADD_Load(object sender, EventArgs e)
        {
            loadNghe();
            loadQue();
            loadTVcu();
        }
        private void comboJob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radFemale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
