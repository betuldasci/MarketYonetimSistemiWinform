using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi.Entity
{
    public class Functions
    {
        RoleCrud roleCrud = new RoleCrud();
        UserCrud userCrud = new UserCrud();
        ProductCrud productCrud = new ProductCrud();
        CategoryCrud categoryCrud= new CategoryCrud();
        public void UploadPictureBoxImage(PictureBox picture)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Files|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picture.ImageLocation = ofd.FileName;
            }
        }
        public void GetRoleListToCb(ComboBox UserRolesCb)
        {
            UserRolesCb.DataSource = roleCrud.GetAll();
            UserRolesCb.DisplayMember = "Name";
            UserRolesCb.ValueMember = "Id";
        }

        public void GetCategoryListToCb(ComboBox ProductCategoryCb)
        {
            ProductCategoryCb.DataSource = categoryCrud.GetAll();
            ProductCategoryCb.DisplayMember = "Name";
            ProductCategoryCb.ValueMember = "Id";
        }
        //public void GetStatusListToCb(ComboBox StatusCb)
        //{
        //    StatusCb.DataSource = productCrud.GetAll();
        //    StatusCb.DisplayMember = "Name";
        //    StatusCb.ValueMember = "Id";
        //}

    }
}
