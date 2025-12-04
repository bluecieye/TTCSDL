using System;
using System.Windows.Forms;
using RapApp.DataAccessLayer;
using RapApp.Models;

namespace RapApp.Forms
{
    public class FoodForm : Form
    {
        private DataGridView dgv;
        private Button btnReload, btnAdd, btnEdit, btnDelete;

        public FoodForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void InitializeComponent()
        {
            this.Text = "Quản lý món ăn";
            this.Width = 800;
            this.Height = 600;
            this.StartPosition = FormStartPosition.CenterParent;

            dgv = new DataGridView() { Dock = DockStyle.Fill, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
            btnReload = new Button() { Text = "Tải lại", Dock = DockStyle.Top, Height = 40 };
            btnAdd = new Button() { Text = "Thêm", Dock = DockStyle.Top, Height = 40 };
            btnEdit = new Button() { Text = "Sửa", Dock = DockStyle.Top, Height = 40 };
            btnDelete = new Button() { Text = "Xoá", Dock = DockStyle.Top, Height = 40 };

            btnReload.Click += (s, e) => LoadData();
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;

            this.Controls.Add(dgv);
            this.Controls.Add(btnReload);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnEdit);
            this.Controls.Add(btnDelete);
        }

        private void LoadData()
        {
            try
            {
                dgv.DataSource = FoodDAO.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load món ăn: " + ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (var f = new Form())
            {
                f.Text = "Thêm món ăn";
                f.Width = 420;
                f.Height = 300;
                f.StartPosition = FormStartPosition.CenterParent;

                var txtId = new TextBox() { Left = 140, Top = 20, Width = 230 };
                var txtTen = new TextBox() { Left = 140, Top = 60, Width = 230 };
                var txtMoTa = new TextBox() { Left = 140, Top = 100, Width = 230 };
                var txtGia = new TextBox() { Left = 140, Top = 140, Width = 230 };

                f.Controls.Add(new Label() { Text = "ID", Left = 20, Top = 22 });
                f.Controls.Add(new Label() { Text = "Tên", Left = 20, Top = 62 });
                f.Controls.Add(new Label() { Text = "Mô tả", Left = 20, Top = 102 });
                f.Controls.Add(new Label() { Text = "Giá", Left = 20, Top = 142 });

                f.Controls.AddRange(new Control[] { txtId, txtTen, txtMoTa, txtGia });

                var btn = new Button() { Text = "Lưu", Left = 140, Top = 190, Width = 120 };
                btn.Click += (ss, ee) =>
                {
                    var fnew = new MonAn
                    {
                        IDMonAn = txtId.Text,
                        TenMonAn = txtTen.Text,
                        MoTa = txtMoTa.Text,
                        DonGia = decimal.TryParse(txtGia.Text, out var g) ? g : 0
                    };
                    try
                    {
                        FoodDAO.Insert(fnew);
                        MessageBox.Show("Thêm thành công");
                        f.Close();
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                };
                f.Controls.Add(btn);
                f.ShowDialog();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0) { MessageBox.Show("Chọn món để sửa."); return; }
            var row = dgv.SelectedRows[0];
            using (var f = new Form())
            {
                f.Text = "Sửa món ăn";
                f.Width = 420;
                f.Height = 300;
                f.StartPosition = FormStartPosition.CenterParent;

                var txtId = new TextBox() { Left = 140, Top = 20, Width = 230, ReadOnly = true, Text = row.Cells["IDMonAn"].Value?.ToString() };
                var txtTen = new TextBox() { Left = 140, Top = 60, Width = 230, Text = row.Cells["TenMonAn"].Value?.ToString() };
                var txtMoTa = new TextBox() { Left = 140, Top = 100, Width = 230, Text = row.Cells["MoTa"].Value?.ToString() };
                var txtGia = new TextBox() { Left = 140, Top = 140, Width = 230, Text = row.Cells["DonGia"].Value?.ToString() };

                f.Controls.Add(new Label() { Text = "ID", Left = 20, Top = 22 });
                f.Controls.Add(new Label() { Text = "Tên", Left = 20, Top = 62 });
                f.Controls.Add(new Label() { Text = "Mô tả", Left = 20, Top = 102 });
                f.Controls.Add(new Label() { Text = "Giá", Left = 20, Top = 142 });

                f.Controls.AddRange(new Control[] { txtId, txtTen, txtMoTa, txtGia });

                var btn = new Button() { Text = "Lưu", Left = 140, Top = 190, Width = 120 };
                btn.Click += (ss, ee) =>
                {
                    var fnew = new MonAn
                    {
                        IDMonAn = txtId.Text,
                        TenMonAn = txtTen.Text,
                        MoTa = txtMoTa.Text,
                        DonGia = decimal.TryParse(txtGia.Text, out var g) ? g : 0
                    };
                    try
                    {
                        FoodDAO.Update(fnew);
                        MessageBox.Show("Cập nhật thành công");
                        f.Close();
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                };
                f.Controls.Add(btn);
                f.ShowDialog();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0) { MessageBox.Show("Chọn món để xoá."); return; }
            var id = dgv.SelectedRows[0].Cells["IDMonAn"].Value.ToString();
            if (MessageBox.Show("Xác nhận xoá món?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    FoodDAO.Delete(id);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
