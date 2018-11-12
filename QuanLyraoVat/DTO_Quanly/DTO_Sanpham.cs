using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Quanly
{
    public class DTO_Sanpham
    {
        // get set
        private string _SPID;
        private string _tenSanPham;
        private Single _giaHienTai;

        public Single giaHienTai
        {
            get { return _giaHienTai; }
            set { _giaHienTai = value; }
        }

        public string tenSanPham
        {
            get { return _tenSanPham; }
            set { _tenSanPham = value; }
        }

        public string SPID
        {
            get { return _SPID; }
            set { _SPID = value; }
        }

        //contructor
        public DTO_Sanpham()
        {

        }
        public DTO_Sanpham(string spid,string tensp, Single giaht)
        {
            this.SPID = spid;
            this.tenSanPham = tensp;
            this.giaHienTai = giaht;
        }
    }
}
