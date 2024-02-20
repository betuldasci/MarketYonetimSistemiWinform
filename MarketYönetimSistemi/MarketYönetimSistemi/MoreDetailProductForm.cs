using MarketYönetimSistemi.Controller;
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
    public partial class MoreDetailProductForm : Form
    {
        ProductCrud productCrud = new ProductCrud(); 
        CategoryCrud categoryCrud = new CategoryCrud();
        public MoreDetailProductForm()
        {
            InitializeComponent();
        }

        private void MoreDetailProductForm_Load(object sender, EventArgs e)
        {

            int id = ProductDetailForm.id;
            var product = productCrud.GetById(id);
            ProductTitleLbl.Text += product.Name;
            pictureBox1.ImageLocation = product.Image;


            ProductNameLbl.Text = product.Name;
            ProductDescLbl.Text = product.Description;
            ProductPriceLbl.Text = Convert.ToString(product.Price);
            ProductStockLbl.Text = Convert.ToString(product.Stock);
            ProductCategoryLbl.Text = categoryCrud.GetById(product.CategoryId).Name;
            ProductStatusLbl.Text = product.IsStatus ? "Active" : "Passive";
            ProductStatusLbl.ForeColor = product.IsStatus ? Color.Green : Color.Red;
        }
    }
}
