namespace QuanLyraoVat
{
    partial class fquanlyraovat
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlnutSanPham = new System.Windows.Forms.Panel();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dgvsanPham = new System.Windows.Forms.DataGridView();
            this.pnlnhapSanPham = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtgiaHienTai = new System.Windows.Forms.TextBox();
            this.lblgiaHienTai = new System.Windows.Forms.Label();
            this.txttenSanPham = new System.Windows.Forms.TextBox();
            this.lbltenSanPham = new System.Windows.Forms.Label();
            this.txttimSanPham = new System.Windows.Forms.TextBox();
            this.lbltimSanPham = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlnutSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanPham)).BeginInit();
            this.pnlnhapSanPham.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.đơnHàngToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.trangChủToolStripMenuItem.Text = "Sản phẩm";
            // 
            // đơnHàngToolStripMenuItem
            // 
            this.đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            this.đơnHàngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.đơnHàngToolStripMenuItem.Text = "Đơn hàng";
            this.đơnHàngToolStripMenuItem.Click += new System.EventHandler(this.đơnHàngToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlnutSanPham, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvsanPham, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlnhapSanPham, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.40082F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.59918F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(473, 542);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pnlnutSanPham
            // 
            this.pnlnutSanPham.Controls.Add(this.btnxoa);
            this.pnlnutSanPham.Controls.Add(this.btnsua);
            this.pnlnutSanPham.Controls.Add(this.btnthem);
            this.pnlnutSanPham.Location = new System.Drawing.Point(3, 491);
            this.pnlnutSanPham.Name = "pnlnutSanPham";
            this.pnlnutSanPham.Size = new System.Drawing.Size(467, 43);
            this.pnlnutSanPham.TabIndex = 1;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(321, 7);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(123, 28);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(172, 7);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(123, 28);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(15, 7);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(123, 28);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgvsanPham
            // 
            this.dgvsanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsanPham.Location = new System.Drawing.Point(3, 181);
            this.dgvsanPham.Name = "dgvsanPham";
            this.dgvsanPham.Size = new System.Drawing.Size(467, 304);
            this.dgvsanPham.TabIndex = 2;
            this.dgvsanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsanPham_CellClick);
            // 
            // pnlnhapSanPham
            // 
            this.pnlnhapSanPham.Controls.Add(this.panel1);
            this.pnlnhapSanPham.Controls.Add(this.txttimSanPham);
            this.pnlnhapSanPham.Controls.Add(this.lbltimSanPham);
            this.pnlnhapSanPham.Location = new System.Drawing.Point(3, 3);
            this.pnlnhapSanPham.Name = "pnlnhapSanPham";
            this.pnlnhapSanPham.Size = new System.Drawing.Size(467, 172);
            this.pnlnhapSanPham.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtgiaHienTai);
            this.panel1.Controls.Add(this.lblgiaHienTai);
            this.panel1.Controls.Add(this.txttenSanPham);
            this.panel1.Controls.Add(this.lbltenSanPham);
            this.panel1.Location = new System.Drawing.Point(90, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 111);
            this.panel1.TabIndex = 5;
            // 
            // txtgiaHienTai
            // 
            this.txtgiaHienTai.Location = new System.Drawing.Point(12, 77);
            this.txtgiaHienTai.Name = "txtgiaHienTai";
            this.txtgiaHienTai.Size = new System.Drawing.Size(278, 20);
            this.txtgiaHienTai.TabIndex = 1;
            // 
            // lblgiaHienTai
            // 
            this.lblgiaHienTai.AutoSize = true;
            this.lblgiaHienTai.Location = new System.Drawing.Point(9, 61);
            this.lblgiaHienTai.Name = "lblgiaHienTai";
            this.lblgiaHienTai.Size = new System.Drawing.Size(60, 13);
            this.lblgiaHienTai.TabIndex = 1;
            this.lblgiaHienTai.Text = "Giá hiện tại";
            // 
            // txttenSanPham
            // 
            this.txttenSanPham.Location = new System.Drawing.Point(12, 20);
            this.txttenSanPham.Name = "txttenSanPham";
            this.txttenSanPham.Size = new System.Drawing.Size(278, 20);
            this.txttenSanPham.TabIndex = 0;
            // 
            // lbltenSanPham
            // 
            this.lbltenSanPham.AutoSize = true;
            this.lbltenSanPham.Location = new System.Drawing.Point(9, 4);
            this.lbltenSanPham.Name = "lbltenSanPham";
            this.lbltenSanPham.Size = new System.Drawing.Size(75, 13);
            this.lbltenSanPham.TabIndex = 0;
            this.lbltenSanPham.Text = "Tên sản phẩm";
            // 
            // txttimSanPham
            // 
            this.txttimSanPham.Location = new System.Drawing.Point(108, 7);
            this.txttimSanPham.Name = "txttimSanPham";
            this.txttimSanPham.Size = new System.Drawing.Size(336, 20);
            this.txttimSanPham.TabIndex = 1;
            this.txttimSanPham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttimSanPham_KeyPress);
            // 
            // lbltimSanPham
            // 
            this.lbltimSanPham.AutoSize = true;
            this.lbltimSanPham.Location = new System.Drawing.Point(22, 8);
            this.lbltimSanPham.Name = "lbltimSanPham";
            this.lbltimSanPham.Size = new System.Drawing.Size(73, 13);
            this.lbltimSanPham.TabIndex = 0;
            this.lbltimSanPham.Text = "Tìm sản phẩm";
            // 
            // fquanlyraovat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 591);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fquanlyraovat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý rao vặt";
            this.Load += new System.EventHandler(this.fquanlyraovat_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlnutSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanPham)).EndInit();
            this.pnlnhapSanPham.ResumeLayout(false);
            this.pnlnhapSanPham.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlnutSanPham;
        private System.Windows.Forms.Panel pnlnhapSanPham;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txttimSanPham;
        private System.Windows.Forms.Label lbltimSanPham;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvsanPham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtgiaHienTai;
        private System.Windows.Forms.Label lblgiaHienTai;
        private System.Windows.Forms.TextBox txttenSanPham;
        private System.Windows.Forms.Label lbltenSanPham;
    }
}