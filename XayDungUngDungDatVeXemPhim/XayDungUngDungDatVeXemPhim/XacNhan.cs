using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XayDungUngDungDatVeXemPhim
{
    public partial class XacNhan : Form
    {

        public XacNhan()
        {
            InitializeComponent();
        }

        void CapNhat(VeXemPhim x)
        {
            txtTenPhim.Text = x.TenPhim;
            txtThoiGian.Text = x.ThoiGian;
            txtPhong.Text = x.Phong;
            txtTenKhachHang.Text = x.TenKh;
            foreach (var item in x.Ghe)
            {
                txtSoGhe.Text += item + ",";
            }
            txtTien.Text = (x.Ghe.Count * 70000).ToString();
        }
        public XacNhan(VeXemPhim x):this()
        {
            CapNhat(x);
        }
    }
}
