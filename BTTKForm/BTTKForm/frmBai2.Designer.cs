namespace BTTKForm
{
    partial class frmBai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DSHH = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChonHang = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TinhTien = new System.Windows.Forms.Button();
            this.BoHang = new System.Windows.Forms.Button();
            this.Dong = new System.Windows.Forms.Label();
            this.TongTienTT = new System.Windows.Forms.Label();
            this.MatHang = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DSHH
            // 
            this.DSHH.AutoSize = true;
            this.DSHH.Location = new System.Drawing.Point(70, 49);
            this.DSHH.Name = "DSHH";
            this.DSHH.Size = new System.Drawing.Size(165, 20);
            this.DSHH.TabIndex = 0;
            this.DSHH.Text = "Danh sách hàng hóa: ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ChonHang);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.DSHH);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 487);
            this.panel1.TabIndex = 1;
            // 
            // ChonHang
            // 
            this.ChonHang.AutoSize = true;
            this.ChonHang.Location = new System.Drawing.Point(373, 127);
            this.ChonHang.Name = "ChonHang";
            this.ChonHang.Size = new System.Drawing.Size(110, 30);
            this.ChonHang.TabIndex = 2;
            this.ChonHang.Text = "Chọn hàng >";
            this.ChonHang.UseVisualStyleBackColor = true;
            this.ChonHang.Click += new System.EventHandler(this.ChonHang_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(74, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 204);
            this.listBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TinhTien);
            this.panel2.Controls.Add(this.BoHang);
            this.panel2.Controls.Add(this.Dong);
            this.panel2.Controls.Add(this.TongTienTT);
            this.panel2.Controls.Add(this.MatHang);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Location = new System.Drawing.Point(543, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 487);
            this.panel2.TabIndex = 1;
            // 
            // TinhTien
            // 
            this.TinhTien.AutoSize = true;
            this.TinhTien.Location = new System.Drawing.Point(262, 315);
            this.TinhTien.Name = "TinhTien";
            this.TinhTien.Size = new System.Drawing.Size(79, 30);
            this.TinhTien.TabIndex = 2;
            this.TinhTien.Text = "Tính tiền";
            this.TinhTien.UseVisualStyleBackColor = true;
            this.TinhTien.Click += new System.EventHandler(this.button3_Click);
            // 
            // BoHang
            // 
            this.BoHang.AutoSize = true;
            this.BoHang.Location = new System.Drawing.Point(23, 127);
            this.BoHang.Name = "BoHang";
            this.BoHang.Size = new System.Drawing.Size(92, 30);
            this.BoHang.TabIndex = 2;
            this.BoHang.Text = "<Bỏ hàng ";
            this.BoHang.UseVisualStyleBackColor = true;
            this.BoHang.Click += new System.EventHandler(this.BoHang_Click);
            // 
            // Dong
            // 
            this.Dong.AutoSize = true;
            this.Dong.Location = new System.Drawing.Point(258, 387);
            this.Dong.Name = "Dong";
            this.Dong.Size = new System.Drawing.Size(45, 20);
            this.Dong.TabIndex = 0;
            this.Dong.Text = "đồng";
            // 
            // TongTienTT
            // 
            this.TongTienTT.AutoSize = true;
            this.TongTienTT.Location = new System.Drawing.Point(61, 387);
            this.TongTienTT.Name = "TongTienTT";
            this.TongTienTT.Size = new System.Drawing.Size(164, 20);
            this.TongTienTT.TabIndex = 0;
            this.TongTienTT.Text = "Tổng tiền thanh toán: ";
            // 
            // MatHang
            // 
            this.MatHang.AutoSize = true;
            this.MatHang.Location = new System.Drawing.Point(193, 49);
            this.MatHang.Name = "MatHang";
            this.MatHang.Size = new System.Drawing.Size(194, 20);
            this.MatHang.TabIndex = 0;
            this.MatHang.Text = "Các mặt hàng khách mua:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(162, 93);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(261, 204);
            this.listBox2.TabIndex = 1;
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.Load += new System.EventHandler(this.frmBai2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DSHH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ChonHang;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button TinhTien;
        private System.Windows.Forms.Button BoHang;
        private System.Windows.Forms.Label MatHang;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label Dong;
        private System.Windows.Forms.Label TongTienTT;
    }
}