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

using BUS_Quanly;
using DTO_Quanly;

namespace QuanLyraoVat
{
    public partial class fquanlyraovat : Form
    {
        public fquanlyraovat()
        {
            InitializeComponent();
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fdonhang = new fdonhang();
            this.Hide();
            fdonhang.ShowDialog();
            this.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fkhachhang = new fkhachhang();
            this.Hide();
            fkhachhang.ShowDialog();
            this.Show();
        }
        BUS_Sanpham BusSP = new BUS_Sanpham();
        private void fquanlyraovat_Load(object sender, EventArgs e)
        {


            dgvsanPham.DataSource = BusSP.getSanPham();



        }

        int vitri;
        string spid;
        private void dgvsanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            spid = dgvsanPham.Rows[vitri].Cells[0].Value.ToString();
            string tensp = dgvsanPham.Rows[vitri].Cells[1].Value.ToString();
            string giaht = dgvsanPham.Rows[vitri].Cells[2].Value.ToString();


            txttenSanPham.Text = tensp;
            txtgiaHienTai.Text = giaht;

          
            
        }
        public string TuSinhMa()
        {
            SqlConnection connec = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyRaoVat;Integrated Security=True");

            connec.Open();

            string query = "select * from SANPHAM";
            SqlDataAdapter da = new SqlDataAdapter(query, connec);
            DataTable dt = new DataTable();

            da.Fill(dt);
            connec.Close();

            int coso = 0;
            if (dt.Rows.Count == 0)
            {
                coso = 1;
            }
            else
            {
                if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) == 1)
                {
                    coso = 2;
                }
                else
                {
                    if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) != 1)
                    {
                        coso = 1;
                    }
                    for (int i = 0; i < dt.Rows.Count - 1; i++)
                    {
                        if (int.Parse(dt.Rows[i + 1][0].ToString().Substring(2, 3)) - int.Parse(dt.Rows[i][0].ToString().Substring(2, 3)) > 1)
                        {
                            coso = int.Parse(dt.Rows[i][0].ToString().Substring(2, 3)) + 1;
                            break;
                        }
                    }
                    coso = int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3)) + 1;
                }
            }
            string ma = "";
            if (coso < 10)
                ma = "SP00" + coso;
            else if (coso < 100)
                ma = "SP0" + coso;
            else
                ma = "SP" + coso;
            return ma;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txttenSanPham.Text != "" && txtgiaHienTai.Text.ToString() != "")
            {
                //tao  dto
                DTO_Sanpham sp = new DTO_Sanpham(TuSinhMa(), txttenSanPham.Text,Convert.ToSingle(txtgiaHienTai.Text) );
                //them
                if(BusSP.themSanPham(sp))
                {
                    MessageBox.Show("Thêm sản phẩm thành công!!!");
                    dgvsanPham.DataSource = BusSP.getSanPham();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!!!");
                }


            }
            else
            {
                MessageBox.Show(" Vui lòng nhập đủ thông tin.");
            }
        }
       
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (vitri>= 0)
            {

                // Xóa
                BusSP.xoaSanPham(spid);
                dgvsanPham.DataSource = BusSP.getSanPham();

            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            
            if(vitri >= 0)
            {
                if(txttenSanPham.Text!=""&& txtgiaHienTai.Text.ToString()!="")
                {
                    //lay row hien tia


                    //lay ma o dong hien tai
                    string spid = dgvsanPham.Rows[vitri].Cells[0].Value.ToString();

                    //tao dto
                    DTO_Sanpham sp = new DTO_Sanpham(spid, txttenSanPham.Text, Convert.ToSingle(txtgiaHienTai.Text));
                    // sua
                    if(BusSP.suaSanPham(sp))
                    {
                        MessageBox.Show(" Sửa thành công.");
                        dgvsanPham.DataSource = BusSP.getSanPham();


                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }

                }
                else
                {
                    MessageBox.Show("Hãy nhập đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("Chọn sản phẩm muốn sửa");
            }
        }

        private void txttimSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvsanPham.DataSource = BusSP.search(txttimSanPham.Text);
        }
    }
}
