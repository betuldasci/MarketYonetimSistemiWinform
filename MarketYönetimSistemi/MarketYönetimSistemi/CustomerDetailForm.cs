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
    public partial class CustomerDetailForm : Form
    {
        RoleCrud roleCrud = new RoleCrud();
        UserCrud userCrud = new UserCrud();
        Functions functions = new Functions();
        public static int id = 0;

        public CustomerDetailForm()
        {
            InitializeComponent();
        }

        private void CustomerDetailForm_Load(object sender, EventArgs e)
        {
            CustomerDetailedListDgv.DataSource = userCrud.GetAll();
            CustomerDetailedListDgv.Columns["Role"].Visible = false;
            CustomerDetailedListDgv.Columns["Id"].Visible = false;

            CustomerDetailedListDgv.Columns["Password"].Visible = false;
            functions.GetRoleListToCb(RoleCb);
           
        }

        private void CustomerDetailedListDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(CustomerDetailedListDgv.CurrentRow.Cells["Id"].Value);

            var user = userCrud.GetById(id);
            CustomerEditNameTxt.Text = user.Name;


            CustomerEditSurnameTxt.Text = user.Surname;
            CustomerEditEmailTxt.Text = user.Email;
            CustomerEditDescTxt.Text = user.Description;
            CustomerEditStatusTxt.Text = user.IsStatus ? "Active" : "Passive";
            CustomerEditImagePb.ImageLocation = user.Image;
            RoleCb.SelectedValue = roleCrud.GetById(user.RoleId).Name; ;
            
        }

        private void UpdateCustomerBtn_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(CustomerDetailedListDgv.CurrentRow.Cells["Id"].Value);
          
            string updatedName = CustomerEditNameTxt.Text;
            string updatedSurname = CustomerEditSurnameTxt.Text;
            string updatedEmail = CustomerEditEmailTxt.Text;
            string updatedDescription = CustomerEditDescTxt.Text;
           
            string updatedImage = CustomerEditImagePb.ImageLocation;
            string updatedRole = RoleCb.SelectedValue.ToString();

            bool updatedStatus = CustomerEditStatusTxt.Text.Equals("Active", StringComparison.OrdinalIgnoreCase);
          
                User updatedUser = new User
                {
                    Name = updatedName,
                    Surname = updatedSurname,
                    Email = updatedEmail,
                    Description = updatedDescription,
                    RoleId = Convert.ToInt32(updatedRole),
                    IsStatus = updatedStatus,
                    Image = updatedImage
                };
                userCrud.Update(updatedUser, id);
                CustomerDetailedListDgv.DataSource = userCrud.GetAll();
                CustomerDetailedListDgv.Columns["Role"].Visible = false;
                CustomerDetailedListDgv.Columns["Password"].Visible = false;
                CustomerDetailedListDgv.Columns["Id"].Visible = false;

            
            CustomerEditNameTxt.Clear();
            CustomerEditSurnameTxt.Clear();
            CustomerEditEmailTxt.Clear();
            CustomerEditDescTxt.Clear();
            RoleCb.ResetText();
            CustomerEditImagePb.Image = null;
            CustomerEditStatusTxt.Clear();




        }

        private void CustomerEditImageBtn_Click(object sender, EventArgs e)
        {
            functions.UploadPictureBoxImage(CustomerEditImagePb);
           
        }
        private void CustomerDeleteBtn_Click(object sender, EventArgs e)
        {
            userCrud.Delete(id);
            CustomerDetailedListDgv.DataSource = userCrud.GetAll();
            CustomerDetailedListDgv.Columns["Role"].Visible = false;
            CustomerDetailedListDgv.Columns["Password"].Visible = false;
            CustomerDetailedListDgv.Columns["Id"].Visible = false;
        }

        private void AddNewCustomerBtn_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            this.Close();
            addUserForm.ShowDialog();
        }

     
    }
    
}
