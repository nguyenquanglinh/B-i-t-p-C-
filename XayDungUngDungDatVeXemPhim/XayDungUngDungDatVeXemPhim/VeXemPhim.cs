using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDungUngDungDatVeXemPhim
{
  public  class VeXemPhim
    {
   

        public VeXemPhim() { }

        public VeXemPhim(string tenPhim, string thoiGian, string phong, string tenKhachHang, string sdt, List<Ghe> ghe):this()
        {
            this.TenPhim = tenPhim;
            this.ThoiGian = thoiGian;
            this.Phong = phong;
            this.TenKh = tenKhachHang;
            this.SDT = sdt;
            this.Ghe = ghe;
        }

        public List<Ghe> Ghe { get; private set; }
        public string Phong { get; private set; }
        public string SDT { get; private set; }
        public string TenKh { get; private set; }
        public string TenPhim { get; private set; }
        public string ThoiGian { get; private set; }
    }
}
