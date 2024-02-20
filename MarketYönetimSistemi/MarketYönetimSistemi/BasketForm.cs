using MarketYönetimSistemi.Data;
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi
{
    public partial class BasketForm : Form
    {
        UserForm userForm = new UserForm();
        ProductCrud productCrud = new ProductCrud();
        DataContext db = new DataContext();


        List<Product> _products;
        public BasketForm(List<Product> products)
        {
            _products = products;
            InitializeComponent();


        }

        private void BasketForm_Load(object sender, EventArgs e)
        {

            basketDgv.DataSource = _products;
            basketDgv.Columns["Stock"].Visible = false;
            basketDgv.Columns["Image"].Visible = false;


            basketDgv.Columns["CategoryId"].Visible = false;
            basketDgv.Columns["Description"].Visible = false;
            basketDgv.Columns["IsDelete"].Visible = false;
            int result = 0;
            foreach (Product product in _products)
            {
                result += Convert.ToInt32(product.Price);
                TotalPriceLbl.Text = result.ToString() + "₺";
            };




        }
        
        private async void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yönlendiriliyorsunuz lütfen bekleyin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            await Task.Delay(5000);

            PaymentForm payment = new PaymentForm();
            payment.ShowDialog();
        }
    }
}