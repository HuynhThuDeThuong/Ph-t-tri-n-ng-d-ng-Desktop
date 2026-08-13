namespace BTTKForm
{
    partial class frmBai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai1));
            this.chonmauxe = new System.Windows.Forms.GroupBox();
            this.Trang = new System.Windows.Forms.RadioButton();
            this.Red = new System.Windows.Forms.RadioButton();
            this.xanh = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DonGia = new System.Windows.Forms.Label();
            this.SoLuong = new System.Windows.Forms.Label();
            this.TinhTien = new System.Windows.Forms.Button();
            this.Do = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TongTien = new System.Windows.Forms.Label();
            this.Tien = new System.Windows.Forms.Label();
            this.chonmauxe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chonmauxe
            // 
            this.chonmauxe.Controls.Add(this.Trang);
            this.chonmauxe.Controls.Add(this.Red);
            this.chonmauxe.Controls.Add(this.xanh);
            this.chonmauxe.Location = new System.Drawing.Point(473, 108);
            this.chonmauxe.Name = "chonmauxe";
            this.chonmauxe.Size = new System.Drawing.Size(208, 148);
            this.chonmauxe.TabIndex = 0;
            this.chonmauxe.TabStop = false;
            this.chonmauxe.Text = "Chọn màu xe";
            // 
            // Trang
            // 
            this.Trang.AutoSize = true;
            this.Trang.Location = new System.Drawing.Point(16, 105);
            this.Trang.Name = "Trang";
            this.Trang.Size = new System.Drawing.Size(75, 24);
            this.Trang.TabIndex = 0;
            this.Trang.Text = "Trắng";
            this.Trang.UseVisualStyleBackColor = true;
            this.Trang.CheckedChanged += new System.EventHandler(this.Trang_CheckedChanged);
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Location = new System.Drawing.Point(16, 65);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(55, 24);
            this.Red.TabIndex = 0;
            this.Red.Text = "Đỏ";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.CheckedChanged += new System.EventHandler(this.Red_CheckedChanged);
            // 
            // xanh
            // 
            this.xanh.AutoSize = true;
            this.xanh.Checked = true;
            this.xanh.Location = new System.Drawing.Point(16, 26);
            this.xanh.Name = "xanh";
            this.xanh.Size = new System.Drawing.Size(76, 24);
            this.xanh.TabIndex = 0;
            this.xanh.TabStop = true;
            this.xanh.Text = " Xanh";
            this.xanh.UseVisualStyleBackColor = true;
            this.xanh.CheckedChanged += new System.EventHandler(this.xanh_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // DonGia
            // 
            this.DonGia.AutoSize = true;
            this.DonGia.Location = new System.Drawing.Point(473, 278);
            this.DonGia.Name = "DonGia";
            this.DonGia.Size = new System.Drawing.Size(68, 20);
            this.DonGia.TabIndex = 2;
            this.DonGia.Text = "Đơn giá:";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSize = true;
            this.SoLuong.Location = new System.Drawing.Point(473, 309);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(76, 20);
            this.SoLuong.TabIndex = 2;
            this.SoLuong.Text = "Số lượng:";
            // 
            // TinhTien
            // 
            this.TinhTien.AutoSize = true;
            this.TinhTien.Location = new System.Drawing.Point(557, 352);
            this.TinhTien.Name = "TinhTien";
            this.TinhTien.Size = new System.Drawing.Size(87, 33);
            this.TinhTien.TabIndex = 3;
            this.TinhTien.Text = "Tính Tiền ";
            this.TinhTien.UseVisualStyleBackColor = true;
            this.TinhTien.Click += new System.EventHandler(this.TinhTien_Click);
            // 
            // Do
            // 
            this.Do.AutoSize = true;
            this.Do.Location = new System.Drawing.Point(663, 284);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(18, 20);
            this.Do.TabIndex = 2;
            this.Do.Text = "$";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(548, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(548, 310);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 4;
            // 
            // TongTien
            // 
            this.TongTien.AutoSize = true;
            this.TongTien.Location = new System.Drawing.Point(473, 394);
            this.TongTien.Name = "TongTien";
            this.TongTien.Size = new System.Drawing.Size(164, 20);
            this.TongTien.TabIndex = 5;
            this.TongTien.Text = "Tổng tiền thanh toán: ";
            // 
            // Tien
            // 
            this.Tien.AutoSize = true;
            this.Tien.Location = new System.Drawing.Point(643, 394);
            this.Tien.Name = "Tien";
            this.Tien.Size = new System.Drawing.Size(27, 20);
            this.Tien.TabIndex = 6;
            this.Tien.Text = "0$";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tien);
            this.Controls.Add(this.TongTien);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TinhTien);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.Do);
            this.Controls.Add(this.DonGia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chonmauxe);
            this.Name = "frmBai1";
            this.Text = "Mua bán xe";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            this.chonmauxe.ResumeLayout(false);
            this.chonmauxe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox chonmauxe;
        private System.Windows.Forms.RadioButton Trang;
        private System.Windows.Forms.RadioButton Red;
        private System.Windows.Forms.RadioButton xanh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DonGia;
        private System.Windows.Forms.Label SoLuong;
        private System.Windows.Forms.Button TinhTien;
        private System.Windows.Forms.Label Do;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label TongTien;
        private System.Windows.Forms.Label Tien;
    }
}

