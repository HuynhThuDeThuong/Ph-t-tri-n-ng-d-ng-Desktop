using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTKForm
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        // 1. Khi mở Form thì nạp danh sách các mặt hàng vào listBox1 bên trái
        private void frmBai2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Chuột");
            listBox1.Items.Add("Bàn phím");
            listBox1.Items.Add("Máy in");
            listBox1.Items.Add("USB Kingmax");
        }

        // 2. Nút "Chọn hàng >": Thêm mặt hàng được chọn bên trái sang listBox2 bên phải
        private void ChonHang_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mặt hàng ở danh sách bên trái!");
            }
        }

        // 3. Nút "<Bỏ hàng": Xóa mặt hàng đang chọn ở listBox2 bên phải
        private void BoHang_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mặt hàng muốn bỏ ở danh sách bên phải!");
            }
        }

        // 4. Nút "Tính tiền" (Tương ứng với nút TinhTien đang nối hàm button3_Click)
        private void button3_Click(object sender, EventArgs e)
        {
            int tongTien = 0;

            // Duyệt từ đầu đến cuối các món trong listBox2
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                string tenHang = listBox2.Items[i].ToString();

                // Kiểm tra tên hàng bằng if - else if đơn giản
                if (tenHang == "Chuột")
                {
                    tongTien = tongTien + 100000;
                }
                else if (tenHang == "Bàn phím")
                {
                    tongTien = tongTien + 150000;
                }
                else if (tenHang == "Máy in")
                {
                    tongTien = tongTien + 2000000;
                }
                else if (tenHang == "USB Kingmax")
                {
                    tongTien = tongTien + 200000;
                }
            }

            // In tổng tiền ra nhãn Dong
            Dong.Text = tongTien.ToString("N0") + " đồng";
        }
    }
}
