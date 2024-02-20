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
    public partial class AddRoleForm : Form
    {
        Functions function = new Functions();
        RoleCrud roleCrud = new RoleCrud(); 
        public AddRoleForm()
        {
            InitializeComponent();
        }

        

        private void RoleSelectImageBtn_Click(object sender, EventArgs e)
        {
            function.UploadPictureBoxImage(RoleImg);
        }

        private void AddRoleBtn_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.Name = RoleNameTxt.Text;
            role.IsStatus = RoleStatusCb.Checked;
            role.Description = RoleDescTxt.Text;
            string RoleImage = "";
            string imagePath = @"C:\Users\Betül\Desktop\image\";

            string defaultImage = "emptyRole.jpg";

            if (RoleImg.Image != null)
            {
                string imageName = Guid.NewGuid() + ".jpg";
                RoleImg.Image.Save(imagePath + imageName, ImageFormat.Jpeg);
                RoleImage = imagePath + imageName;
            }
            else
            {
                RoleImage = imagePath + defaultImage;
            }
            role.Image = RoleImage;


            MessageBox.Show(roleCrud.Add(role) ? "Rol eklendi" : "Rol eklenmedi");
            RoleNameTxt.Clear();
            RoleDescTxt.Clear();
            RoleStatusCb.Checked = false;
            RoleImg.Image = null;
        }
    }
}
