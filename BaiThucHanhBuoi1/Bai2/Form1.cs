using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void nam_check(object sender, EventArgs e)
        {
            if(nam.Checked)
            {
                MessageBox.Show("Bạn đã chọn giới tính nam", "Thông báo");
            }
        }

        private void nu_CheckedChanged(object sender, EventArgs e)
        {
            if (nu.Checked)
            {
                MessageBox.Show("Bạn đã chọn giới tính nữ", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(xanh.Checked)
            {
                panel1.BackColor = Color.Cyan;
            }else
            {
                panel1.BackColor = Color.Red;
            }
        }
    }
}
