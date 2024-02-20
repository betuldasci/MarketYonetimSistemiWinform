using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.Interface;
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
    public partial class ProductDetailForm : Form
    {
        Functions functions = new Functions();
        ProductCrud productCrud = new ProductCrud();
        CategoryCrud categoryCrud = new CategoryCrud();
        public static int id = 0;

        public ProductDetailForm()
        {
            InitializeComponent();
        }

        private void ProductDetailForm_Load(object sender, EventArgs e)
        {
            functions.GetCategoryListToCb(CategoryCb);
            //functions.GetStatusListToCb(StatusCb);
            ProductDetailDgv.DataSource = productCrud.GetAll();
            ProductDetailDgv.Columns["Category"].Visible = false;
        }

        private void AddNewProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            this.Close();
        }

        private void ProductDetailDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(ProductDetailDgv.CurrentRow.Cells["Id"].Value);

            var product = productCrud.GetById(id);
            ProductDetailNameTxt.Text = product.Name;


            ProductDetailDescTxt.Text = product.Description;
            ProductDetailPriceNud.Value = Convert.ToInt32(product.Price);
            ProductDetailStockNud.Value = Convert.ToInt32(product.Stock);
            CategoryCb.Text = categoryCrud.GetById(product.CategoryId).Name;
            ProductDetailStatusTxt.Text = product.IsStatus ? "Active" : "Passive";
            ProductDetailImagePb.ImageLocation = product.Image;
        }

        private void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(ProductDetailDgv.CurrentRow.Cells["Id"].Value);

            string updatedName = ProductDetailNameTxt.Text;
            string updatedDesc = ProductDetailDescTxt.Text;
            int updatedPrice = Convert.ToInt32(ProductDetailPriceNud.Value);
            int updatedStock = Convert.ToInt32(ProductDetailStockNud.Value);
            string updatedCategory = CategoryCb.SelectedValue.ToString();
            string updatedImage = ProductDetailImagePb.ImageLocation;

            bool updatedStatus = ProductDetailStatusTxt.Text.Equals("Active", StringComparison.OrdinalIgnoreCase);


            {
                Product updatedProduct = new Product
                {
                    Name = updatedName,
                    Description = updatedDesc,
                    Price = updatedPrice,
                    Stock = updatedStock,
                    CategoryId = Convert.ToInt32(updatedCategory),
                    Image = updatedImage,
                    IsStatus = updatedStatus,
                };
                productCrud.Update(updatedProduct, id);
                ProductDetailDgv.DataSource = productCrud.GetAll();


            }
            ProductDetailNameTxt.Clear();
            ProductDetailDescTxt.Clear();
            ProductDetailPriceNud.ResetText();
            ProductDetailStockNud.ResetText();
            CategoryCb.ResetText();
            ProductDetailImagePb.ResetText();
            ProductDetailImagePb.Image = null;
        }

        private void ProductDeleteBtn_Click(object sender, EventArgs e)
        {
            productCrud.Delete(id);
            ProductDetailDgv.DataSource = productCrud.GetAll();
            ProductDetailDgv.Columns["Category"].Visible = false;
        }

        private void ProductEditImageBtn_Click(object sender, EventArgs e)
        {
            functions.UploadPictureBoxImage(ProductDetailImagePb);
        }
    }
}
