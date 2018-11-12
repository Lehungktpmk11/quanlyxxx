using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Quanly;
using DAO_Quanly;
using System.Data;

namespace BUS_Quanly
{
    public class BUS_Sanpham
    {
        DAO_SanPham daosanpham = new DAO_SanPham();



        public DataTable getSanPham()
        {
            return daosanpham.getSanPham();
        }
        public bool themSanPham(DTO_Sanpham sp)
        {
            return daosanpham.themSanPham(sp);
        }
        public bool suaSanPham(DTO_Sanpham sp)
        {
            return daosanpham.suaSanPham(sp);
        }
        public void xoaSanPham(string spid)
        {
            daosanpham.xoaSanPham(spid);
        }
        public DataTable search(string ten)
        {
            return daosanpham.search(ten);
        }
    }
}
