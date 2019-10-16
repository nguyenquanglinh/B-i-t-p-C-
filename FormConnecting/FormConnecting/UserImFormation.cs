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
    public partial class UserImFormation : Form
    {

        public UserImFormation()
        {
            InitializeComponent();
        }

        public UserImFormation(User user, CheckService x):this()
        {
            userForm1.SetUser(user);
            userForm1.SetCheck(x);
        }
    }
}
