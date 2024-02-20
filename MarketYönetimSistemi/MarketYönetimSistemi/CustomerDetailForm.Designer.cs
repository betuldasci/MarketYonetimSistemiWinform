namespace MarketYönetimSistemi
{
    partial class CustomerDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomerDetailedListDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerNameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerEditNameTxt = new System.Windows.Forms.TextBox();
            this.CustomerEditSurnameTxt = new System.Windows.Forms.TextBox();
            this.CustomerEditEmailTxt = new System.Windows.Forms.TextBox();
            this.CustomerEditDescTxt = new System.Windows.Forms.TextBox();
            this.UpdateCustomerBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CustomerEditStatusTxt = new System.Windows.Forms.TextBox();
            this.CustomerEditImagePb = new System.Windows.Forms.PictureBox();
            this.CustomerEditImageBtn = new System.Windows.Forms.Button();
            this.CustomerDeleteBtn = new System.Windows.Forms.Button();
            this.AddNewCustomerBtn = new System.Windows.Forms.Button();
            this.RoleCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDetailedListDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerEditImagePb)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerDetailedListDgv
            // 
            this.CustomerDetailedListDgv.AllowUserToAddRows = false;
            this.CustomerDetailedListDgv.AllowUserToDeleteRows = false;
            this.CustomerDetailedListDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDetailedListDgv.Location = new System.Drawing.Point(68, 52);
            this.CustomerDetailedListDgv.Name = "CustomerDetailedListDgv";
            this.CustomerDetailedListDgv.ReadOnly = true;
            this.CustomerDetailedListDgv.RowHeadersWidth = 51;
            this.CustomerDetailedListDgv.RowTemplate.Height = 24;
            this.CustomerDetailedListDgv.Size = new System.Drawing.Size(848, 193);
            this.CustomerDetailedListDgv.TabIndex = 0;
            this.CustomerDetailedListDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDetailedListDgv_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer List";
            // 
            // CustomerNameLbl
            // 
            this.CustomerNameLbl.AutoSize = true;
            this.CustomerNameLbl.Location = new System.Drawing.Point(70, 272);
            this.CustomerNameLbl.Name = "CustomerNameLbl";
            this.CustomerNameLbl.Size = new System.Drawing.Size(44, 16);
            this.CustomerNameLbl.TabIndex = 2;
            this.CustomerNameLbl.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Image";
            // 
            // CustomerEditNameTxt
            // 
            this.CustomerEditNameTxt.Location = new System.Drawing.Point(219, 272);
            this.CustomerEditNameTxt.Name = "CustomerEditNameTxt";
            this.CustomerEditNameTxt.Size = new System.Drawing.Size(286, 22);
            this.CustomerEditNameTxt.TabIndex = 8;
            // 
            // CustomerEditSurnameTxt
            // 
            this.CustomerEditSurnameTxt.Location = new System.Drawing.Point(219, 315);
            this.CustomerEditSurnameTxt.Name = "CustomerEditSurnameTxt";
            this.CustomerEditSurnameTxt.Size = new System.Drawing.Size(286, 22);
            this.CustomerEditSurnameTxt.TabIndex = 9;
            // 
            // CustomerEditEmailTxt
            // 
            this.CustomerEditEmailTxt.Location = new System.Drawing.Point(219, 355);
            this.CustomerEditEmailTxt.Name = "CustomerEditEmailTxt";
            this.CustomerEditEmailTxt.Size = new System.Drawing.Size(286, 22);
            this.CustomerEditEmailTxt.TabIndex = 10;
            // 
            // CustomerEditDescTxt
            // 
            this.CustomerEditDescTxt.Location = new System.Drawing.Point(606, 272);
            this.CustomerEditDescTxt.Name = "CustomerEditDescTxt";
            this.CustomerEditDescTxt.Size = new System.Drawing.Size(286, 22);
            this.CustomerEditDescTxt.TabIndex = 11;
            // 
            // UpdateCustomerBtn
            // 
            this.UpdateCustomerBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.UpdateCustomerBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateCustomerBtn.Location = new System.Drawing.Point(413, 475);
            this.UpdateCustomerBtn.Name = "UpdateCustomerBtn";
            this.UpdateCustomerBtn.Size = new System.Drawing.Size(150, 42);
            this.UpdateCustomerBtn.TabIndex = 14;
            this.UpdateCustomerBtn.Text = "Update";
            this.UpdateCustomerBtn.UseVisualStyleBackColor = false;
            this.UpdateCustomerBtn.Click += new System.EventHandler(this.UpdateCustomerBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Role";
            // 
            // CustomerEditStatusTxt
            // 
            this.CustomerEditStatusTxt.Location = new System.Drawing.Point(606, 326);
            this.CustomerEditStatusTxt.Name = "CustomerEditStatusTxt";
            this.CustomerEditStatusTxt.Size = new System.Drawing.Size(116, 22);
            this.CustomerEditStatusTxt.TabIndex = 17;
            // 
            // CustomerEditImagePb
            // 
            this.CustomerEditImagePb.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CustomerEditImagePb.Location = new System.Drawing.Point(606, 380);
            this.CustomerEditImagePb.Name = "CustomerEditImagePb";
            this.CustomerEditImagePb.Size = new System.Drawing.Size(274, 137);
            this.CustomerEditImagePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CustomerEditImagePb.TabIndex = 18;
            this.CustomerEditImagePb.TabStop = false;
            // 
            // CustomerEditImageBtn
            // 
            this.CustomerEditImageBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CustomerEditImageBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomerEditImageBtn.Location = new System.Drawing.Point(724, 537);
            this.CustomerEditImageBtn.Name = "CustomerEditImageBtn";
            this.CustomerEditImageBtn.Size = new System.Drawing.Size(156, 52);
            this.CustomerEditImageBtn.TabIndex = 19;
            this.CustomerEditImageBtn.Text = "Edit Image";
            this.CustomerEditImageBtn.UseVisualStyleBackColor = false;
            this.CustomerEditImageBtn.Click += new System.EventHandler(this.CustomerEditImageBtn_Click);
            // 
            // CustomerDeleteBtn
            // 
            this.CustomerDeleteBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CustomerDeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerDeleteBtn.Location = new System.Drawing.Point(268, 475);
            this.CustomerDeleteBtn.Name = "CustomerDeleteBtn";
            this.CustomerDeleteBtn.Size = new System.Drawing.Size(130, 42);
            this.CustomerDeleteBtn.TabIndex = 21;
            this.CustomerDeleteBtn.Text = "Delete";
            this.CustomerDeleteBtn.UseVisualStyleBackColor = false;
            this.CustomerDeleteBtn.Click += new System.EventHandler(this.CustomerDeleteBtn_Click);
            // 
            // AddNewCustomerBtn
            // 
            this.AddNewCustomerBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddNewCustomerBtn.Location = new System.Drawing.Point(112, 475);
            this.AddNewCustomerBtn.Name = "AddNewCustomerBtn";
            this.AddNewCustomerBtn.Size = new System.Drawing.Size(139, 42);
            this.AddNewCustomerBtn.TabIndex = 22;
            this.AddNewCustomerBtn.Text = "Add Customer";
            this.AddNewCustomerBtn.UseVisualStyleBackColor = false;
            this.AddNewCustomerBtn.Click += new System.EventHandler(this.AddNewCustomerBtn_Click);
            // 
            // RoleCb
            // 
            this.RoleCb.FormattingEnabled = true;
            this.RoleCb.Location = new System.Drawing.Point(219, 388);
            this.RoleCb.Name = "RoleCb";
            this.RoleCb.Size = new System.Drawing.Size(286, 24);
            this.RoleCb.TabIndex = 23;
            // 
            // CustomerDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 747);
            this.Controls.Add(this.RoleCb);
            this.Controls.Add(this.AddNewCustomerBtn);
            this.Controls.Add(this.CustomerDeleteBtn);
            this.Controls.Add(this.CustomerEditImageBtn);
            this.Controls.Add(this.CustomerEditImagePb);
            this.Controls.Add(this.CustomerEditStatusTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UpdateCustomerBtn);
            this.Controls.Add(this.CustomerEditDescTxt);
            this.Controls.Add(this.CustomerEditEmailTxt);
            this.Controls.Add(this.CustomerEditSurnameTxt);
            this.Controls.Add(this.CustomerEditNameTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerNameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerDetailedListDgv);
            this.Name = "CustomerDetailForm";
            this.Text = "CustomerDetailForm";
            this.Load += new System.EventHandler(this.CustomerDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDetailedListDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerEditImagePb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerDetailedListDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CustomerNameLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CustomerEditNameTxt;
        private System.Windows.Forms.TextBox CustomerEditSurnameTxt;
        private System.Windows.Forms.TextBox CustomerEditEmailTxt;
        private System.Windows.Forms.TextBox CustomerEditDescTxt;
        private System.Windows.Forms.Button UpdateCustomerBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CustomerEditStatusTxt;
        private System.Windows.Forms.PictureBox CustomerEditImagePb;
        private System.Windows.Forms.Button CustomerEditImageBtn;
        private System.Windows.Forms.Button CustomerDeleteBtn;
        private System.Windows.Forms.Button AddNewCustomerBtn;
        private System.Windows.Forms.ComboBox RoleCb;
    }
}