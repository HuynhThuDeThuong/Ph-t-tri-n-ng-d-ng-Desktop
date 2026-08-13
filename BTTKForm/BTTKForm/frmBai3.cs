using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BTTKForm
{
    public partial class frmBai3 : Form
    {
        private Dictionary<string, string> tuDien = new Dictionary<string, string>();

        public frmBai3()
        {
            InitializeComponent();
        }

        private void frmBai3_Load(object sender, EventArgs e)
        {
            tuDien.Add("Go", "Đi, di chuyển");
            tuDien.Add("House", "Ngôi nhà");
            tuDien.Add("School", "Trường học");
            tuDien.Add("Teacher", "Giáo viên, thầy cô");
            tuDien.Add("Student", "Học sinh, sinh viên");

            NapDanhSachTu();

            if (lstTuMoi.Items.Count > 0)
            {
                lstTuMoi.SelectedIndex = lstTuMoi.Items.Count - 1;
            }
        }

        private void NapDanhSachTu()
        {
            lstTuMoi.Items.Clear();
            foreach (var tu in tuDien.Keys)
            {
                lstTuMoi.Items.Add(tu);
            }
        }

        private void lstTuMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTuMoi.SelectedItem != null)
            {
                string tuChon = lstTuMoi.SelectedItem.ToString();
                if (tuDien.ContainsKey(tuChon))
                {
                    txtNghiaHienThi.Text = tuDien[tuChon];
                }
            }
        }

        private void btnThemTuMoi_Click(object sender, EventArgs e)
        {
            string tuMoi = txtTuMoi.Text.Trim();
            string nghia = txtNghia.Text.Trim();

            if (string.IsNullOrEmpty(tuMoi) || string.IsNullOrEmpty(nghia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Từ mới và Nghĩa của từ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tuDien.ContainsKey(tuMoi))
            {
                tuDien[tuMoi] = nghia;
            }
            else
            {
                tuDien.Add(tuMoi, nghia);
                lstTuMoi.Items.Add(tuMoi);
            }

            lstTuMoi.SelectedItem = tuMoi;

            txtTuMoi.Clear();
            txtNghia.Clear();
            txtTuMoi.Focus();
        }
    }
}
