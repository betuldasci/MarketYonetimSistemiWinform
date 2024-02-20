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
    public partial class AdminForm : Form
    {
        UserCrud userCrud= new UserCrud();
        ProductCrud productCrud= new ProductCrud();
        public AdminForm()
        {
            InitializeComponent();
        }
        public void SetWelcomeLabel(string userName)
        {
            WellcomeLbl.Text = $"Welcome, {userName}";
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            ProductDgv.DataSource = productCrud.GetAll();
            CustomerDgv.DataSource = userCrud.GetAll();
        }

        private void CustomerDetailBtn_Click(object sender, EventArgs e)
        {
            CustomerDetailForm customerDetailForm = new CustomerDetailForm();   
            customerDetailForm.ShowDialog();
        }

        private void ProductDetailBtn_Click(object sender, EventArgs e)
        {
            ProductDetailForm productDetailForm = new ProductDetailForm();
            productDetailForm.ShowDialog();
        }
    }
}
