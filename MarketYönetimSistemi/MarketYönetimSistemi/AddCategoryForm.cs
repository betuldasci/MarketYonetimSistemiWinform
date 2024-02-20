using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.Interface;
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
    public partial class AddCategoryForm : Form
    {
        CategoryCrud categoryCrud = new CategoryCrud(); 
        Functions functions = new Functions();

        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name= CategoryNameTxt.Text;
            category.Description=CategoryDescTxt.Text;
            category.IsStatus = CategoryStatusCb.Checked;


            string CategoryImg = "";
            string imagePath = @"C:\Users\Betül\Desktop\image";
            string defaultImage = "emptyUser.jpg";

            if (CategoryImagePb.Image != null)
            {
                string imageName = Guid.NewGuid() + ".jpg";
                CategoryImagePb.Image.Save(imagePath + imageName, ImageFormat.Jpeg);
                CategoryImg = imagePath + imageName;
            }
            else
            {
                CategoryImg = imagePath + defaultImage;
            }
            category.Image = CategoryImg;
            AddCatMessageLbl.Visible = true;
            AddCatMessageLbl.Text = categoryCrud.Add(category) ?
                                    "Category Ekleme Başarılı" :
                                    "Category Ekleme Başarısız";
        }

        private void CategorySelectImageBtn_Click(object sender, EventArgs e)
        {
            functions.UploadPictureBoxImage(CategoryImagePb);
        }
    }
}
