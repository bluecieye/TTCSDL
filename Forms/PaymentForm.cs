using System;
using System.Windows.Forms;
using RapApp.DataAccessLayer;

namespace RapApp.Forms
{
    public class PaymentForm : Form
    {
        private DataGridView dgvHoaDon;
        private DataGridView dgvCT;
        private Button btnReload, btnMarkPaid, btnMarkCancel;

        public PaymentForm()
        {
            InitializeComponent();
            LoadHoaDon();
        }

        private void InitializeComponent()
        {
            this.Text = "Quản lý thanh toán";
            this.Width = 1000;
            this.Height = 700;
            this.StartPosition = FormStartPosition.CenterParent;

            dgvHoaDon = new DataGridView() { Dock = DockStyle.Top, Height = 300, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, SelectionMode = DataGridViewSelectionMode.FullRowSelect };
            dgvCT = new DataGridView() { Dock = DockStyle.Fill, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };

            btnReload = new Button() { Text = "Tải lại", Left = 10, Top = 310, Width = 120 };
            btnMarkPaid = new Button() { Text = "Đánh dấu Paid", Left = 150, Top = 310, Width = 140 };
            btnMarkCancel = new Button() { Text = "Đánh dấu Cancel", Left = 310, Top = 310, Width = 140 };

            this.Controls.Add(dgvCT);
            this.Controls.Add(dgvHoaDon);
            this.Controls.Add(btnReload);
            this.Controls.Add(btnMarkPaid);
            this.Controls.Add(btnMarkCancel);

            btnReload.Click += (s, e) => LoadHoaDon();
            dgvHoaDon.SelectionChanged += DgvHoaDon_SelectionChanged;
            btnMarkPaid.Click += BtnMarkPaid_Click;
            btnMarkCancel.Click += BtnMarkCancel_Click;
        }

        private void LoadHoaDon()
        {
            try
            {
                dgvHoaDon.DataSource = PaymentDAO.GetAllHoaDon();
                dgvCT.DataSource = null;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void DgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 0) return;
            var id = dgvHoaDon.SelectedRows[0].Cells["IDHoaDon"].Value.ToString();
            try
            {
                dgvCT.DataSource = PaymentDAO.GetCTMonAnByHoaDon(id);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load CT: " + ex.Message); }
        }

        private void BtnMarkPaid_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 0) { MessageBox.Show("Chọn hóa đơn."); return; }
            var id = dgvHoaDon.SelectedRows[0].Cells["IDHoaDon"].Value.ToString();
            PaymentDAO.UpdateTrangThai(id, "Paid");
            LoadHoaDon();
        }

        private void BtnMarkCancel_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 0) { MessageBox.Show("Chọn hóa đơn."); return; }
            var id = dgvHoaDon.SelectedRows[0].Cells["IDHoaDon"].Value.ToString();
            PaymentDAO.UpdateTrangThai(id, "Cancelled");
            LoadHoaDon();
        }
    }
}
