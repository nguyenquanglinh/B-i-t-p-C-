using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormConnecting
{
    public partial class UserForm : UserControl
    {
        public UserForm()
        {
            InitializeComponent();
            label.Visible = false;
        }
        public User GetUser()
        {
            if (!string.IsNullOrWhiteSpace(txtFirstName.Text) || !string.IsNullOrWhiteSpace(txtLastName.Text) || !string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                return new User(txtFirstName.Text, txtLastName.Text, txtEmail.Text);
            }
            else
            {
                MessageBox.Show("Dont whiteSpace first name, lastname");
                return null;
            }
        }
        
        public void SetUser(User user)
        {
            if (user == null)
                return;
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtEmail.Text = user.Email;
        }
        public void SetCheck(CheckService cs)
        {
            if (cs == null)
                return;
            checkBox.Text = cs.Name;
            checkBox.Checked = true;
            label.Visible = true;
            label.Text = cs.Lable;
            checkBox.Visible = true;
            
        }
    }
    public class CheckService
    {
        public CheckService(string name,string lable)
        {
            this.Name = name;
            this.Lable = lable;
        }

        public string Lable { get; private set; }
        public string Name { get; private set; }
    }

    public class User
    {
        public User(string firstName,string lastName,string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        public string Email { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Service { get;  set; }
    }
}
