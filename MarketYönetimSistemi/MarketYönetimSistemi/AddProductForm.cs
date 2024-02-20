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
    public partial class AddProductForm : Form
    {
        Functions functions = new Functions();
    
        ProductCrud productCrud = new ProductCrud();
        public AddProductForm()
        {
            InitializeComponent();
        }

        

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            functions.GetCategoryListToCb(ProductCategoryCb);
        }

        private void ProductSelectImageBtn_Click_1(object sender, EventArgs e)
        {
            functions.UploadPictureBoxImage(ProductImage);
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = ProductNameTxt.Text;
            product.Price = Convert.ToInt32(PriceNud.Value);
            product.Stock = Convert.ToInt32(StockNud.Value);
            product.CategoryId = Convert.ToInt32(ProductCategoryCb.SelectedValue);
            product.IsStatus = ProductStatusCb.Checked;
            product.Description = ProductDescTxt.Text;

            string ProductImg = "";
            string imagePath = @"C:\Users\Betül\Desktop\image";
            string defaultImage = "emptyUser.jpg";

            if (ProductImage.Image != null)
            {
                string imageName = Guid.NewGuid() + ".jpg";
                ProductImage.Image.Save(imagePath + imageName, ImageFormat.Jpeg);
                ProductImg = imagePath + imageName;
            }
            else
            {
                ProductImg = imagePath + defaultImage;
            }
            product.Image = ProductImg;
            AddProductMessageLbl.Visible = true;
            AddProductMessageLbl.Text = productCrud.Add(product) ?
                                    "Product Ekleme Başarılı" :
                                    "Product Ekleme Başarısız";
            ProductNameTxt.Clear();
            PriceNud.Value.Equals(0);
            StockNud.Value.Equals(0);
            ProductStatusCb.Checked = false;
            ProductImage.Image = null;
            ProductDescTxt.Clear();
        }
    }
}
