namespace Bai2
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nu = new System.Windows.Forms.RadioButton();
            this.nam = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.đo = new System.Windows.Forms.RadioButton();
            this.xanh = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nu);
            this.groupBox1.Controls.Add(this.nam);
            this.groupBox1.Location = new System.Drawing.Point(372, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn giới tính";
            // 
            // nu
            // 
            this.nu.AutoSize = true;
            this.nu.Location = new System.Drawing.Point(7, 43);
            this.nu.Name = "nu";
            this.nu.Size = new System.Drawing.Size(37, 17);
            this.nu.TabIndex = 0;
            this.nu.Text = "nữ";
            this.nu.UseVisualStyleBackColor = true;
            this.nu.CheckedChanged += new System.EventHandler(this.nu_CheckedChanged);
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Checked = true;
            this.nam.Location = new System.Drawing.Point(7, 20);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(45, 17);
            this.nam.TabIndex = 0;
            this.nam.TabStop = true;
            this.nam.Text = "nam";
            this.nam.UseVisualStyleBackColor = true;
            this.nam.CheckedChanged += new System.EventHandler(this.nam_check);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.đo);
            this.groupBox2.Controls.Add(this.xanh);
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn màu";
            // 
            // đo
            // 
            this.đo.AutoSize = true;
            this.đo.Location = new System.Drawing.Point(7, 43);
            this.đo.Name = "đo";
            this.đo.Size = new System.Drawing.Size(38, 17);
            this.đo.TabIndex = 0;
            this.đo.Text = "đỏ";
            this.đo.UseVisualStyleBackColor = true;
            // 
            // xanh
            // 
            this.xanh.AutoSize = true;
            this.xanh.Checked = true;
            this.xanh.Location = new System.Drawing.Point(7, 20);
            this.xanh.Name = "xanh";
            this.xanh.Size = new System.Drawing.Size(48, 17);
            this.xanh.TabIndex = 0;
            this.xanh.TabStop = true;
            this.xanh.Text = "xanh";
            this.xanh.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Đổi màu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(267, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Bài tập 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton nu;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton đo;
        private System.Windows.Forms.RadioButton xanh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

