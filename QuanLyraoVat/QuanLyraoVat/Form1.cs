using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyraoVat
{
   
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }
        
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                
                string tk = "admin";
                string mk = "123456";
                if (tk == "" || mk == "")
                    MessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
                SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyRaoVat;Integrated Security=True");
                conn.Open();
                string query = "select * from TKDANGNHAP where taiKhoan='" + tk + "' and matkhau='" + mk + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dtr = cmd.ExecuteReader();
                if(dtr.HasRows)
                {
                    Form fquanlyraovat = new fquanlyraovat();
                    this.Hide();
                    fquanlyraovat.ShowDialog();
                    this.Show();
                }else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!!","Thông báo");
                }
                
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa nhập đủ thông tin!","Thông báo");
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmdangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;

        }
    }
   
}
