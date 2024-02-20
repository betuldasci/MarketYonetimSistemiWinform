using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Data;
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi
{
    public partial class UserForm : Form
    {
        PictureBox ProductImgPb;
        Button ProductDetailBtn;
        Button ProductBuyBtn;
        Label ProductNameLbl;
        GroupBox ProductGb;

        ProductCrud productCrud = new ProductCrud();
        CategoryCrud categoryCrud = new CategoryCrud();
        DataContext db = new DataContext();
        public List<Product> products = new List<Product>();

        public UserForm()
        {
            InitializeComponent();

        }

        private void BasketForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        public void SetWelcomeLabel(string userName)
        {
            WellcomeLbl.Text = $"Welcome, {userName}";
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            int formWidth = (panel1.Width / 2) - (WellcomeLbl.Width / 2);
            int formHeight = (panel1.Height / 2) - (WellcomeLbl.Height / 2);
            WellcomeLbl.Location = new Point(formWidth, formHeight);
            BasketLbl.Visible = false;
        }

        private void UserForm_SizeChanged(object sender, EventArgs e)
        {
            int formWidth = (panel1.Width / 2) - (WellcomeLbl.Width / 2);
            int formHeight = (panel1.Height / 2) - (WellcomeLbl.Height / 2);
            WellcomeLbl.Location = new Point(formWidth, formHeight);
            panel2.Controls.Clear();
            ProductListingIntoPanel();
        }

        public void ProductListingIntoPanel()
        {
            int xStart = 20;
            int yStart = 20;
            int i = 0;
            int step = 170;
            int PanelWidth = panel2.Width - xStart;
            int UserGbCount = (PanelWidth - ((PanelWidth) % step)) / step;
            foreach (var product in productCrud.GetAll())
            {
                if (i == UserGbCount)
                {
                    yStart += step + 90;
                    i = 0;
                }
                ProductGb = new GroupBox()
                {
                    Name = "ProductGb_" + product.Id,
                    Text = categoryCrud.GetById(product.CategoryId).Name,
                    Size = new Size(150, 300),
                    BackColor = Color.White,
                    Location = new Point(xStart + (step * i), yStart),

                };
                ProductImgPb = new PictureBox()
                {
                    Name = "ProductImgPb_" + product.Id,
                    ImageLocation = product.Image,
                    Size = new Size(120, 120),
                    Location = new Point(15, 25),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                ProductNameLbl = new Label()
                {
                    Name = "ProductNameLbl_" + product.Id,
                    Text = product.Name.ToString(),
                    Location = new Point(15, 155),
                };
                ProductDetailBtn = new Button()
                {
                    Name = "ProductDetailBtn_" + product.Id,
                    Text = "Detail",
                    Location = new Point(15, 185),
                    Size = new Size(120, 40),
                    FlatStyle = FlatStyle.Standard,
                    BackColor = Color.CadetBlue,
                    ForeColor = Color.White,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)))
                };
                ProductDetailBtn.Click += ProductDetailBtn_Click;

                ProductBuyBtn = new Button()
                {
                    Name = "ProductBuyBtn_" + product.Id,
                    Text = "Add to Basket",
                    Location = new Point(15, 240),
                    Size = new Size(110, 50),
                    FlatStyle = FlatStyle.Standard,
                    BackColor = Color.Coral,
                    ForeColor = Color.Bisque,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(150)))
                };
                ProductBuyBtn.Click += ProductBuyBtn_Click;

                ProductGb.Controls.Add(ProductDetailBtn);
                ProductGb.Controls.Add(ProductBuyBtn);
                ProductGb.Controls.Add(ProductNameLbl);
                ProductGb.Controls.Add(ProductImgPb);

                panel2.Controls.Add(ProductGb);
                i++;
            }


        }

        private void ProductDetailBtn_Click(object sender, EventArgs e)
        {
            Button btn = ((Button)sender);
            string btnName = btn.Name;
            string[] btnId = btnName.Split('_');

            ProductDetailForm.id = Convert.ToInt32(btnId[btnId.Length - 1]);
            MoreDetailProductForm moreDetailProductForm = new MoreDetailProductForm();
            moreDetailProductForm.ShowDialog();
        }

        public static int count = 0;
        public Product basketProduct;


        public void ProductBuyBtn_Click(object sender, EventArgs e)
        {

            Button btn = ((Button)sender);
            string btnName = btn.Name;
            string[] btnId = btnName.Split('_');

            ProductDetailForm.id = Convert.ToInt32(btnId[btnId.Length - 1]);

            count++;
            BasketLbl.Text = count.ToString();
            BasketLbl.Visible = true;
            basketProduct = productCrud.GetById(ProductDetailForm.id);
            products.Add(basketProduct);
        }

        private void ConfirmBasketBtn_Click(object sender, EventArgs e)
        {
            BasketForm basketForm = new BasketForm(products);
            basketForm.ShowDialog();

        }
    }
}