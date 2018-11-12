namespace QuanLyraoVat
{
    partial class frmdangnhap
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
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.lblquanlyraovat = new System.Windows.Forms.Label();
            this.lbltaikhoan = new System.Windows.Forms.Label();
            this.lblmatkhau = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.pnldangnhap = new System.Windows.Forms.Panel();
            this.pnldangnhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(222, 101);
            this.txttaikhoan.MaxLength = 30;
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(242, 20);
            this.txttaikhoan.TabIndex = 0;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(224, 156);
            this.txtmatkhau.MaxLength = 30;
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(239, 20);
            this.txtmatkhau.TabIndex = 1;
            this.txtmatkhau.UseSystemPasswordChar = true;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Location = new System.Drawing.Point(154, 227);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(173, 46);
            this.btndangnhap.TabIndex = 2;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // lblquanlyraovat
            // 
            this.lblquanlyraovat.AutoSize = true;
            this.lblquanlyraovat.Location = new System.Drawing.Point(260, 21);
            this.lblquanlyraovat.Name = "lblquanlyraovat";
            this.lblquanlyraovat.Size = new System.Drawing.Size(79, 13);
            this.lblquanlyraovat.TabIndex = 3;
            this.lblquanlyraovat.Text = "Quản lý rao vặt";
            // 
            // lbltaikhoan
            // 
            this.lbltaikhoan.AutoSize = true;
            this.lbltaikhoan.Location = new System.Drawing.Point(67, 101);
            this.lbltaikhoan.Name = "lbltaikhoan";
            this.lbltaikhoan.Size = new System.Drawing.Size(55, 13);
            this.lbltaikhoan.TabIndex = 4;
            this.lbltaikhoan.Text = "Tài khoản";
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.AutoSize = true;
            this.lblmatkhau.Location = new System.Drawing.Point(70, 156);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(52, 13);
            this.lblmatkhau.TabIndex = 5;
            this.lblmatkhau.Text = "Mật khẩu";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(385, 227);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(158, 46);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // pnldangnhap
            // 
            this.pnldangnhap.Controls.Add(this.btnthoat);
            this.pnldangnhap.Controls.Add(this.lblmatkhau);
            this.pnldangnhap.Controls.Add(this.lbltaikhoan);
            this.pnldangnhap.Controls.Add(this.lblquanlyraovat);
            this.pnldangnhap.Controls.Add(this.btndangnhap);
            this.pnldangnhap.Controls.Add(this.txtmatkhau);
            this.pnldangnhap.Controls.Add(this.txttaikhoan);
            this.pnldangnhap.Location = new System.Drawing.Point(12, 12);
            this.pnldangnhap.Name = "pnldangnhap";
            this.pnldangnhap.Size = new System.Drawing.Size(641, 284);
            this.pnldangnhap.TabIndex = 7;
            // 
            // frmdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 304);
            this.Controls.Add(this.pnldangnhap);
            this.Name = "frmdangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmdangnhap_FormClosing);
            this.pnldangnhap.ResumeLayout(false);
            this.pnldangnhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Label lblquanlyraovat;
        private System.Windows.Forms.Label lbltaikhoan;
        private System.Windows.Forms.Label lblmatkhau;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Panel pnldangnhap;
    }
}

