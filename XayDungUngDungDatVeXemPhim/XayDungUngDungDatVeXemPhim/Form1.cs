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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            TaoPhim();
            foreach (var item in ListPhim)
            {
                comboBoxChonPhim.Items.Add(item);
            }
            TaoHangGhe();

        }

        private void TaoHangGhe()
        {
            int x = 35;
            int y = 15;
            for (int i = 1; i < 17; i++)
            {
                var lb = new Label()
                {
                    Text = i.ToString(),
                    Location = new Point(x, y),
                    Width=20,
                    Height =20,

                };
                groupBoxHangGhe.Controls.Add(lb);
                x += 20;
            }
            x = 15;
            y = 35;
            var listHang = new List<string>() { "A", "B", "C", "D", "E", "F" };
            foreach (var item in listHang)
            {
                var lb = new Label()
                {
                    Text = item,
                    Width=20,Height=20,
                    Location = new Point(x, y),
                };
                groupBoxHangGhe.Controls.Add(lb);
                y += 20;
            }

            x = 35;
            y = 35;
            this.ArrCheck = new CheckBox[6, 16];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    var c = new CheckBox()
                    {
                        Width = 20,
                        Height = 20,
                        Location = new Point(x, y),
                    };

                    ArrCheck[i, j] = c;
                    groupBoxHangGhe.Controls.Add(c);
                    x += 20;
                }
                x = 35;
                y += 20;
            }
        }

        public List<Phim> ListPhim { get; private set; }
        public CheckBox[,] ArrCheck { get; private set; }

        private void TaoPhim()
        {
            this.ListPhim = new List<Phim>();
            ListPhim.Add(new Phim("Iron man", new List<string> { "15h30", "17h30", "19h30" }, new List<int> { 1, 2, 6 }));
            ListPhim.Add(new Phim("Anh thầy ngôi sao", new List<string> { "16h00", "18h00" }, new List<int> { 3, 4 }));
            ListPhim.Add(new Phim("Gone with the wind", new List<string> { "17h00", "19h00" }, new List<int> { 5 }));
        }

     

        private void groupBoxHangGhe_Enter(object sender, EventArgs e)
        {

        }
        private string LayTenPhim()
        {
            var tenPhim = (Phim)comboBoxChonPhim.SelectedItem;
            if (tenPhim != null)
            {
                return tenPhim.TenPhim;
            }
            else
            {
                MessageBox.Show("chưa chọn tên phim");
                return null;
            }
        }
        private string LayThoiGian()
        {
            var thoiGian = comboBoxThoiGian.SelectedItem.ToString();
            if (thoiGian != null)
                return thoiGian;
            MessageBox.Show("chua chọn thời gian xem");
            return null;
        }
        private string LayPhong()
        {
            var thoiGian = comboBoxPhong.SelectedItem.ToString();
            if (thoiGian != null)
                return thoiGian;
            MessageBox.Show("chua chọn thời gian xem");
            return null;

        }
        void Main()
        {
            var ghe = LayGhe();
            var tenPhim = LayTenPhim();
            var thoiGian = LayThoiGian();
            var phong = LayPhong();
            if (tenPhim != null && thoiGian != null && phong != null && !string.IsNullOrWhiteSpace(txtTenKhachHang.Text) && !string.IsNullOrWhiteSpace(txtSDT.Text) && ghe.Count > 0)
            {
                var x = new VeXemPhim(tenPhim, thoiGian, phong, txtTenKhachHang.Text, txtSDT.Text, ghe);
                var xd = new XacNhan(x);
                xd.ShowDialog();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Main();
            }
            catch
            {

            }
        }

        private List<Ghe> LayGhe()
        {
            var l = new List<Ghe>();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (ArrCheck[i, j].Checked)
                    {
                        l.Add(new Ghe(j, i.ToString()));
                    }
                }
            }
            return l;
        }

        private void comboBoxChonPhim_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var x = comboBoxChonPhim.SelectedItem as Phim;
            if (x == null)
            {
                MessageBox.Show("vui long thu lại");
                return;
            }
            foreach (var item in x.ThoiGian)
            {
                comboBoxThoiGian.Items.Add(item);
            }
            foreach (var item in x.SoPhong)
            {
                comboBoxPhong.Items.Add(item);
            }
        }
    }
}
