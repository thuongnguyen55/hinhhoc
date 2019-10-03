using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc
{
    class hinhtron : Hinhhoc
    {
        const double pi = 3.14;
        private double r;

        public double chuvi;
        public double dientich;

        public double BanKinh
        {
            get { return r; }
            set { r = value; }
        }

        public hinhtron() { }
        public hinhtron(double r)
        {
            this.r = r;
        }
        public new void ChuVi()
        {
            chuvi = r * 2 * pi;
        }

        public new void DienTich()
        {
            dientich = 2 * pi * (r * r);
        }
    }
}
