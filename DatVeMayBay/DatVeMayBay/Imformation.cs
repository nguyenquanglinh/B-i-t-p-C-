using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatVeMayBay
{
    public partial class Imformation : Form
    {
        private VeMayBay x;

        public Imformation()
        {
            InitializeComponent();
        }
        private void UpdateImformation(VeMayBay v)
        {
            txtFullName.Text = v.FullName;
            txtTo.Text = v.To;
            txtFrom.Text = v.From;
            txtIssue.Text = v.DateTo;
            txtExpiry.Text = v.DateEnd;
            txtBaggage.Text = v.Bagge;
            txtNo.Text = v.DocumentNo.No;
            label5.Text = v.DocumentNo.Name;
           
        }

        public Imformation(VeMayBay veMayBay):this()
        {
            this.VeMayBay = veMayBay;
            UpdateImformation(veMayBay);
        }

        public VeMayBay VeMayBay { get; private set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Imformation_Load(object sender, EventArgs e)
        {

        }
    }
}
