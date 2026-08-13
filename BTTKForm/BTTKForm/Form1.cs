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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
            textBox1.Text = "22000";
            textBox2.Text = "1";
        }

        private void xanh_CheckedChanged(object sender, EventArgs e)
        {
            if (xanh.Checked)
            {
                textBox1.Text = "22000";
            }
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {

        }

        private void Red_CheckedChanged(object sender, EventArgs e)
        {
            if (Red.Checked)
            {
                textBox1.Text = " 21000";
            } 
                

        }

        private void Trang_CheckedChanged(object sender, EventArgs e)
        {
            if (Trang.Checked)
            {
                textBox1.Text = "20000";
            } 
                
        }

        private void TinhTien_Click(object sender, EventArgs e)
        {
            Tien.Text = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)).ToString() + " $" ;
        }
    }
}
