using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_Quanly;

namespace DAO_Quanly
{
    public class DAO_SanPham:DBconnect
    {
        //lay toan bo bang
        public DataTable getSanPham()
        {
            string query = " select * from SANPHAM";
            
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            DataTable dtsanpham = new DataTable();
            da.Fill(dtsanpham);
            
            return dtsanpham;
        }
        //them san pham
        public bool themSanPham(DTO_Sanpham sp)
        {

            try
            {
                _conn.Open();
               string queryinsert = string.Format("insert into SANPHAM(SPID,tenSanPham,giaHienTai) values ('{0}',N'{1}','{2}')", sp.SPID, sp.tenSanPham, sp.giaHienTai);
                SqlCommand cmd = new SqlCommand(queryinsert, _conn);
                //query va kiem tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch(Exception exx)
            {

            }
            finally
            {
                //dong ket noi
                _conn.Close();
            }

            return false;
        }

        //xoa san pham
        public void xoaSanPham(string spid)
        {

            try
            {
                _conn.Open();
                string querydelete = "delete from SANPHAM where SPID ='" + spid + "'";
                SqlCommand cmd = new SqlCommand(querydelete, _conn);
                //query va kiem tra
                cmd.ExecuteNonQuery();
                    
            }
            catch (Exception exx)
            {

            }
            finally
            {
                //dong ket noi
                _conn.Close();
            }

            
        }
        //sua san pham
        public bool suaSanPham(DTO_Sanpham sp)
        {

            try
            {
                _conn.Open();
                string queryupdate = "update SANPHAM set tenSanPham=N'"+sp.tenSanPham+"',giaHienTai='"+sp.giaHienTai+"' where SPID ='"+sp.SPID+"' ";
                SqlCommand cmd = new SqlCommand(queryupdate, _conn);
                //query va kiem tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception exx)
            {

            }
            finally
            {
                //dong ket noi
                _conn.Close();
            }

            return false;
        }
        public DataTable search(string ten)
        {
            DataTable dtsanpham = new DataTable();
            try
            {
                string query = string.Format(" select * from SANPHAM where SPID like = '%{0}%'", ten);

                SqlDataAdapter da = new SqlDataAdapter(query, _conn);
                


                da.Fill(dtsanpham);
            }
            catch(Exception ex)
            {
                
            }
            return dtsanpham;
        }
    }
}
