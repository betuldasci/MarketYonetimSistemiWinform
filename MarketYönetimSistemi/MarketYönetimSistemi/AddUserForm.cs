using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi
{
    public partial class AddUserForm : Form
    {
        Functions functions = new Functions();
        UserCrud userCrud = new UserCrud();
        RoleCrud roleCrud = new RoleCrud();
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void UserSelectImageBtn_Click(object sender, EventArgs e)
        {
            functions.UploadPictureBoxImage(UserImg);
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = UserNameTxt.Text;
            user.Surname = UserSurnameTxt.Text;
            user.Email = UserEmailTxt.Text;
            user.Password = UserPasswordTxt.Text;
            user.Description = UserDescTxt.Text;
            user.IsStatus=UserStatusCb.Checked;
            user.RoleId = Convert.ToInt32(UserRolesCb.SelectedValue);
         

            string UserImage = "";
            string imagePath = @"C:\Users\Betül\Desktop\image";
            string defaultImage = "emptyUser.jpg";

            if (UserImg.Image != null)
            {
                string imageName = Guid.NewGuid() + ".jpg";
                UserImg.Image.Save(imagePath + imageName, ImageFormat.Jpeg);
                UserImage = imagePath + imageName;
            }
            else
            {
                UserImage = imagePath + defaultImage;
            }
            user.Image = UserImage;
            AddUserMessageLbl.Visible = true;
            AddUserMessageLbl.Text = userCrud.Add(user) ?
                                    "User Ekleme Başarılı" :
                                    "User Ekleme Başarısız";

           

            UserNameTxt.Clear();
            UserSurnameTxt.Clear();
            UserEmailTxt.Clear();
            UserPasswordTxt.Clear();
            UserDescTxt.Clear();
            UserStatusCb.Checked = false;
            UserImg.Image = null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddUserMessageLbl.Visible = false;
            functions.GetRoleListToCb(UserRolesCb);
        }

     
    }
}
