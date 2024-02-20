using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Data;
using MarketYönetimSistemi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi
{
    public partial class LoginForm : Form
    {
        DataContext db = new DataContext();
     
        public LoginForm()
        {
            InitializeComponent();
           
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            var user = db.User.Where(x => x.Email == EmailTxt.Text && x.Password == PasswordTxt.Text).FirstOrDefault();
            if (user != null && user.RoleId == 1)
            {
                
                AdminForm adminForm = new AdminForm();
                adminForm.SetWelcomeLabel(user.Name);
            
                adminForm.ShowDialog();
               
            }
            else if (user.RoleId == 2)
            {
                UserForm userForm = new UserForm();
               
                userForm.ShowDialog();
                userForm.SetWelcomeLabel(user.Name);
            

            }
        }

       
    }
}
