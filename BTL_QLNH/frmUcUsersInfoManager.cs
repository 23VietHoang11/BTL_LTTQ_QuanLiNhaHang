using BTL_QLNH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLNH
{
    public partial class frmUcUsersInfoManager : UserControl
    {
        private DataAccess Da { get; set; }
        public frmUcUsersInfoManager()
        {
            InitializeComponent();

            this.Da = new DataAccess();

            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from UserInfo;")
        {
            this.Da.ExecuteQueryTable(sql);
            this.dgvUpdate.DataSource = Da.Ds.Tables[0];
        }


        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string sql = "select * from UserInfo where FullName like '%" + this.txtSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void dgvUpdate_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUpdate.SelectedRows != null && dgvUpdate.SelectedRows.Count > 0)
            {
                string userName = dgvUpdate.CurrentRow.Cells[0].Value.ToString();
                string FullName = dgvUpdate.CurrentRow.Cells[1].Value.ToString();
                string DOB = dgvUpdate.CurrentRow.Cells[2].Value.ToString();
                string Gender = dgvUpdate.CurrentRow.Cells[3].Value.ToString();
                string role = dgvUpdate.CurrentRow.Cells[4].Value.ToString();
                string Email = dgvUpdate.CurrentRow.Cells[5].Value.ToString();


                txtUserName.Text = userName;
                txtFullName.Text = FullName;
                dtpDOB.Text = DOB;
                cmbGender.Text = Gender;
                cmbRole.Text = role;
                txtEmail.Text = Email;
            }
        }
    }
}
