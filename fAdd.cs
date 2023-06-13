using DOANCNPM_1.DAO;
using DOANCNPM_1.DTO;
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
    public partial class frmAdd : Form
    {
        private MemberDAO memberDAO;
        public frmAdd()
        {
            InitializeComponent();
            memberDAO = new MemberDAO();
        }

        private void btnAddMem_Click(object sender, EventArgs e)
        {
            MemberDTO newMember = new MemberDTO();
            newMember.MAQH = comboRelationship.SelectedItem.ToString();
            newMember.NGPSINH = DateTime.Parse(dateTimePickerOccurred.Text);
            newMember.HOTEN = txtFullName.Text;
            newMember.GT = radMale.Checked;
            newMember.NGSINH = DateTime.Parse(dateTimePickerBirth.Text);
            newMember.MAQQ = txtHometown.Text;
            newMember.MANN = comboJob.SelectedItem.ToString();
            newMember.DIACHI = txtAddress.Text;

            memberDAO.SaveMember(newMember);
        }
    }
}
