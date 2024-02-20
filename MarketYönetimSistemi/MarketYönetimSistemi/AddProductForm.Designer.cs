namespace MarketYönetimSistemi
{
    partial class AddProductForm
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
            this.AddUserGb = new System.Windows.Forms.GroupBox();
            this.StockNud = new System.Windows.Forms.NumericUpDown();
            this.PriceNud = new System.Windows.Forms.NumericUpDown();
            this.UserDescriptionLbl = new System.Windows.Forms.Label();
            this.ProductDescTxt = new System.Windows.Forms.TextBox();
            this.AddProductMessageLbl = new System.Windows.Forms.Label();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.ProductCategoryCb = new System.Windows.Forms.ComboBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.UserSurnamelbl = new System.Windows.Forms.Label();
            this.ProductStatusCb = new System.Windows.Forms.CheckBox();
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.ProductSelectImageBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddUserGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // AddUserGb
            // 
            this.AddUserGb.Controls.Add(this.StockNud);
            this.AddUserGb.Controls.Add(this.PriceNud);
            this.AddUserGb.Controls.Add(this.UserDescriptionLbl);
            this.AddUserGb.Controls.Add(this.ProductDescTxt);
            this.AddUserGb.Controls.Add(this.AddProductMessageLbl);
            this.AddUserGb.Controls.Add(this.AddProductBtn);
            this.AddUserGb.Controls.Add(this.ProductCategoryCb);
            this.AddUserGb.Controls.Add(this.PasswordLbl);
            this.AddUserGb.Controls.Add(this.ProductNameTxt);
            this.AddUserGb.Controls.Add(this.EmailLbl);
            this.AddUserGb.Controls.Add(this.UserSurnamelbl);
            this.AddUserGb.Controls.Add(this.ProductStatusCb);
            this.AddUserGb.Controls.Add(this.ProductImage);
            this.AddUserGb.Controls.Add(this.ProductSelectImageBtn);
            this.AddUserGb.Controls.Add(this.label2);
            this.AddUserGb.Location = new System.Drawing.Point(117, 26);
            this.AddUserGb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddUserGb.Name = "AddUserGb";
            this.AddUserGb.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddUserGb.Size = new System.Drawing.Size(567, 399);
            this.AddUserGb.TabIndex = 4;
            this.AddUserGb.TabStop = false;
            this.AddUserGb.Text = "Add Product";
            // 
            // StockNud
            // 
            this.StockNud.Location = new System.Drawing.Point(94, 107);
            this.StockNud.Name = "StockNud";
            this.StockNud.Size = new System.Drawing.Size(171, 22);
            this.StockNud.TabIndex = 25;
            // 
            // PriceNud
            // 
            this.PriceNud.Location = new System.Drawing.Point(94, 52);
            this.PriceNud.Name = "PriceNud";
            this.PriceNud.Size = new System.Drawing.Size(171, 22);
            this.PriceNud.TabIndex = 24;
            // 
            // UserDescriptionLbl
            // 
            this.UserDescriptionLbl.AutoSize = true;
            this.UserDescriptionLbl.Location = new System.Drawing.Point(91, 279);
            this.UserDescriptionLbl.Name = "UserDescriptionLbl";
            this.UserDescriptionLbl.Size = new System.Drawing.Size(75, 16);
            this.UserDescriptionLbl.TabIndex = 23;
            this.UserDescriptionLbl.Text = "Description";
            // 
            // ProductDescTxt
            // 
            this.ProductDescTxt.Location = new System.Drawing.Point(91, 300);
            this.ProductDescTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductDescTxt.Name = "ProductDescTxt";
            this.ProductDescTxt.Size = new System.Drawing.Size(169, 22);
            this.ProductDescTxt.TabIndex = 22;
            // 
            // AddProductMessageLbl
            // 
            this.AddProductMessageLbl.AutoSize = true;
            this.AddProductMessageLbl.Location = new System.Drawing.Point(315, 340);
            this.AddProductMessageLbl.Name = "AddProductMessageLbl";
            this.AddProductMessageLbl.Size = new System.Drawing.Size(64, 16);
            this.AddProductMessageLbl.TabIndex = 21;
            this.AddProductMessageLbl.Text = "Message";
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddProductBtn.ForeColor = System.Drawing.Color.White;
            this.AddProductBtn.Location = new System.Drawing.Point(315, 287);
            this.AddProductBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(169, 48);
            this.AddProductBtn.TabIndex = 20;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = false;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // ProductCategoryCb
            // 
            this.ProductCategoryCb.FormattingEnabled = true;
            this.ProductCategoryCb.Location = new System.Drawing.Point(91, 166);
            this.ProductCategoryCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductCategoryCb.Name = "ProductCategoryCb";
            this.ProductCategoryCb.Size = new System.Drawing.Size(169, 24);
            this.ProductCategoryCb.TabIndex = 19;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(91, 211);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(44, 16);
            this.PasswordLbl.TabIndex = 17;
            this.PasswordLbl.Text = "Name";
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.Location = new System.Drawing.Point(91, 232);
            this.ProductNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(169, 22);
            this.ProductNameTxt.TabIndex = 16;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(91, 148);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(62, 16);
            this.EmailLbl.TabIndex = 15;
            this.EmailLbl.Text = "Category";
            // 
            // UserSurnamelbl
            // 
            this.UserSurnamelbl.AutoSize = true;
            this.UserSurnamelbl.Location = new System.Drawing.Point(91, 88);
            this.UserSurnamelbl.Name = "UserSurnamelbl";
            this.UserSurnamelbl.Size = new System.Drawing.Size(41, 16);
            this.UserSurnamelbl.TabIndex = 13;
            this.UserSurnamelbl.Text = "Stock";
            // 
            // ProductStatusCb
            // 
            this.ProductStatusCb.AutoSize = true;
            this.ProductStatusCb.Location = new System.Drawing.Point(315, 254);
            this.ProductStatusCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductStatusCb.Name = "ProductStatusCb";
            this.ProductStatusCb.Size = new System.Drawing.Size(66, 20);
            this.ProductStatusCb.TabIndex = 11;
            this.ProductStatusCb.Text = "Status";
            this.ProductStatusCb.UseVisualStyleBackColor = true;
            // 
            // ProductImage
            // 
            this.ProductImage.BackColor = System.Drawing.Color.Gray;
            this.ProductImage.Location = new System.Drawing.Point(315, 80);
            this.ProductImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(169, 152);
            this.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImage.TabIndex = 10;
            this.ProductImage.TabStop = false;
            // 
            // ProductSelectImageBtn
            // 
            this.ProductSelectImageBtn.Location = new System.Drawing.Point(315, 48);
            this.ProductSelectImageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductSelectImageBtn.Name = "ProductSelectImageBtn";
            this.ProductSelectImageBtn.Size = new System.Drawing.Size(169, 27);
            this.ProductSelectImageBtn.TabIndex = 9;
            this.ProductSelectImageBtn.Text = "Select Image";
            this.ProductSelectImageBtn.UseVisualStyleBackColor = true;
            this.ProductSelectImageBtn.Click += new System.EventHandler(this.ProductSelectImageBtn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddUserGb);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.AddUserGb.ResumeLayout(false);
            this.AddUserGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddUserGb;
        private System.Windows.Forms.Label UserDescriptionLbl;
        private System.Windows.Forms.TextBox ProductDescTxt;
        private System.Windows.Forms.Label AddProductMessageLbl;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.ComboBox ProductCategoryCb;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label UserSurnamelbl;
        private System.Windows.Forms.CheckBox ProductStatusCb;
        private System.Windows.Forms.PictureBox ProductImage;
        private System.Windows.Forms.Button ProductSelectImageBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown StockNud;
        private System.Windows.Forms.NumericUpDown PriceNud;
    }
}