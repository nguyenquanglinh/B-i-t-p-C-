using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormConnecting
{
    public partial class SingUp : Form
    {
        public SingUp()
        {
            InitializeComponent();
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            new UserImFormation(userForm1.GetUser(), GetCheckBox()).ShowDialog();
        }

        private CheckService GetCheckBox()
        {
            if (checkBoxSms.Checked)
                return new CheckService(checkBoxSms.Text, "Service change may apply");
            else if (checkBoxReport.Checked)
                return new CheckService(checkBoxReport.Text, "Free service");
            else if(checkboxGmailTrport.Checked)
                return new CheckService(checkboxGmailTrport.Text, "Gmail service");
            return null;
        }
    }
}
