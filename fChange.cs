using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_DOAN
{
    public partial class frmChange : Form
    {
        private int key = 0;
        public frmChange()
        {
            InitializeComponent();
        }

        private void LoadForm(Form form)
        {
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;

            this.pnl1.Controls.Clear();
            this.pnl1.Controls.Add(form);
            form.Show();
        }

        private void btnTown_Click(object sender, EventArgs e)
        {
            key = 1;
            LoadForm(new frmTown());
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            key = 2;
            LoadForm(new frmJob());
        }

        private void btnCause_Click(object sender, EventArgs e)
        {
            key = 3;
            LoadForm(new frmCause());
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            key = 4;
            LoadForm(new frmPlace());
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            key = 5;
            LoadForm(new frmType());
        }

        private void frmChange_Load(object sender, EventArgs e)
        {
            frmTown frm = new frmTown() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnl1.Controls.Add(frm);
            frm.Show();
        }

        private void lblAchive_Click(object sender, EventArgs e)
        {

        }
    }
}
