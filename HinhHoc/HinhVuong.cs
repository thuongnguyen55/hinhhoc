using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc
{
    class hinhvuong : HinhCN
    {
        public new double chuvi;
        public new double dientich;

        public double Canh
        {
            get { return ChieuDai; }
            set { ChieuDai = value; }
        }

        public hinhvuong() { }

        public hinhvuong(double canh)
        {
            ChieuDai = canh;
        }

        public new void ChuVi()
        {
            chuvi = Dai * 4;
        }
        public new void DienTich()
        {
            dientich = Dai * Dai;
        }
    }
}
