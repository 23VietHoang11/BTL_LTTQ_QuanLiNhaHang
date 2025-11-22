using System;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using BTL_QLNH.BUS; // Gọi BUS

namespace BTL_QLNH
{
    public partial class frmUcUsersInfoManager : UserControl
    {
        private UserBUS bus;

        public frmUcUsersInfoManager()
        {
            // Cài đặt ngôn ngữ tiếng Việt
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");

            InitializeComponent();
            bus = new UserBUS(); // Khởi tạo BUS

            // Cài đặt giao diện
            cmbGender.Items.Clear();
            cmbGender.Items.AddRange(new string[] { "Nam", "Nữ" });

            cmbRole.Items.Clear();
            cmbRole.Items.AddRange(new string[] { "Quản Trị Viên", "Nhân Viên", "Quản Lý" });

            this.dtpDOB.Format = DateTimePickerFormat.Custom;
            this.dtpDOB.CustomFormat = "dddd, dd/MM/yyyy";

            LoadData();
        }

        private void LoadData()
        {
            // SỬA LỖI TẠI ĐÂY: Gọi BUS thay vì DataAccess cũ
            this.dgvUpdate.DataSource = bus.GetList();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string keyword = this.txtSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadData();
            }
            else
            {
                // SỬA LỖI TẠI ĐÂY: Gọi BUS tìm kiếm
                this.dgvUpdate.DataSource = bus.Search(keyword);
            }
        }

        private void dgvUpdate_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUpdate.SelectedRows != null && dgvUpdate.SelectedRows.Count > 0 && dgvUpdate.CurrentRow != null)
            {
                txtUserName.Text = dgvUpdate.CurrentRow.Cells[0].Value.ToString();
                txtFullName.Text = dgvUpdate.CurrentRow.Cells[1].Value.ToString();
                try { dtpDOB.Value = Convert.ToDateTime(dgvUpdate.CurrentRow.Cells[2].Value); } catch { }
                cmbGender.Text = dgvUpdate.CurrentRow.Cells[3].Value.ToString();
                cmbRole.Text = dgvUpdate.CurrentRow.Cells[4].Value.ToString();
                txtEmail.Text = dgvUpdate.CurrentRow.Cells[5].Value.ToString();
            }
        }
    }
}