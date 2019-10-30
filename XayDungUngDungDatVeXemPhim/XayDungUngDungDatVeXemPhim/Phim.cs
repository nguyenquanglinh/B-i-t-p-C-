using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDungUngDungDatVeXemPhim
{
   public class Phim
    {
        public Phim() { }
        public Phim(string tenPhim,List<string> thoiGian, List<int> soPhong)
        {
            this.TenPhim = tenPhim;
            this.ThoiGian = thoiGian;
            this.SoPhong = soPhong;
        }
        public override string ToString()
        {
            return TenPhim;
        }

        public List<int> SoPhong { get; private set; }
        public string TenPhim { get; private set; }
        public List<string> ThoiGian { get; private set; }
    }
}
