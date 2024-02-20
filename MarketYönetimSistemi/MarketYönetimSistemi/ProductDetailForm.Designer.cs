namespace MarketYönetimSistemi
{
    partial class ProductDetailForm
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
            this.ProductDetailDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddNewProductBtn = new System.Windows.Forms.Button();
            this.ProductDeleteBtn = new System.Windows.Forms.Button();
            this.ProductEditImageBtn = new System.Windows.Forms.Button();
            this.UpdateProductBtn = new System.Windows.Forms.Button();
            this.ProductDetailNameTxt = new System.Windows.Forms.TextBox();
            this.ProductDetailDescTxt = new System.Windows.Forms.TextBox();
            this.ProductDetailStatusTxt = new System.Windows.Forms.TextBox();
            this.ProductDetailPriceNud = new System.Windows.Forms.NumericUpDown();
            this.ProductDetailStockNud = new System.Windows.Forms.NumericUpDown();
            this.ProductDetailImagePb = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CategoryCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDetailDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDetailPriceNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDetailStockNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDetailImagePb)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductDetailDgv
            // 
            this.ProductDetailDgv.AllowUserToAddRows = false;
            this.ProductDetailDgv.AllowUserToDeleteRows = false;
            this.ProductDetailDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDetailDgv.Location = new System.Drawing.Point(45, 56);
            this.ProductDetailDgv.Name = "ProductDetailDgv";
            this.ProductDetailDgv.ReadOnly = true;
            this.ProductDetailDgv.RowHeadersWidth = 51;
            this.ProductDetailDgv.RowTemplate.Height = 24;
            this.ProductDetailDgv.Size = new System.Drawing.Size(775, 163);
            this.ProductDetailDgv.TabIndex = 0;
            this.ProductDetailDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDetailDgv_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Image";
            // 
            // AddNewProductBtn
            // 
            this.AddNewProductBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddNewProductBtn.Location = new System.Drawing.Point(204, 502);
            this.AddNewProductBtn.Name = "AddNewProductBtn";
            this.AddNewProductBtn.Size = new System.Drawing.Size(156, 59);
            this.AddNewProductBtn.TabIndex = 26;
            this.AddNewProductBtn.Text = "Add Product";
            this.AddNewProductBtn.UseVisualStyleBackColor = false;
            this.AddNewProductBtn.Click += new System.EventHandler(this.AddNewProductBtn_Click);
            // 
            // ProductDeleteBtn
            // 
            this.ProductDeleteBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.ProductDeleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductDeleteBtn.Location = new System.Drawing.Point(538, 502);
            this.ProductDeleteBtn.Name = "ProductDeleteBtn";
            this.ProductDeleteBtn.Size = new System.Drawing.Size(156, 59);
            this.ProductDeleteBtn.TabIndex = 25;
            this.ProductDeleteBtn.Text = "Delete";
            this.ProductDeleteBtn.UseVisualStyleBackColor = false;
            this.ProductDeleteBtn.Click += new System.EventHandler(this.ProductDeleteBtn_Click);
            // 
            // ProductEditImageBtn
            // 
            this.ProductEditImageBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.ProductEditImageBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductEditImageBtn.Location = new System.Drawing.Point(726, 445);
            this.ProductEditImageBtn.Name = "ProductEditImageBtn";
            this.ProductEditImageBtn.Size = new System.Drawing.Size(94, 41);
            this.ProductEditImageBtn.TabIndex = 24;
            this.ProductEditImageBtn.Text = "Edit Image";
            this.ProductEditImageBtn.UseVisualStyleBackColor = false;
            this.ProductEditImageBtn.Click += new System.EventHandler(this.ProductEditImageBtn_Click);
            // 
            // UpdateProductBtn
            // 
            this.UpdateProductBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.UpdateProductBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateProductBtn.Location = new System.Drawing.Point(376, 502);
            this.UpdateProductBtn.Name = "UpdateProductBtn";
            this.UpdateProductBtn.Size = new System.Drawing.Size(156, 59);
            this.UpdateProductBtn.TabIndex = 23;
            this.UpdateProductBtn.Text = "Update";
            this.UpdateProductBtn.UseVisualStyleBackColor = false;
            this.UpdateProductBtn.Click += new System.EventHandler(this.UpdateProductBtn_Click);
            // 
            // ProductDetailNameTxt
            // 
            this.ProductDetailNameTxt.Location = new System.Drawing.Point(161, 265);
            this.ProductDetailNameTxt.Name = "ProductDetailNameTxt";
            this.ProductDetailNameTxt.Size = new System.Drawing.Size(199, 22);
            this.ProductDetailNameTxt.TabIndex = 27;
            // 
            // ProductDetailDescTxt
            // 
            this.ProductDetailDescTxt.Location = new System.Drawing.Point(161, 315);
            this.ProductDetailDescTxt.Name = "ProductDetailDescTxt";
            this.ProductDetailDescTxt.Size = new System.Drawing.Size(199, 22);
            this.ProductDetailDescTxt.TabIndex = 27;
            // 
            // ProductDetailStatusTxt
            // 
            this.ProductDetailStatusTxt.Location = new System.Drawing.Point(161, 401);
            this.ProductDetailStatusTxt.Name = "ProductDetailStatusTxt";
            this.ProductDetailStatusTxt.Size = new System.Drawing.Size(103, 22);
            this.ProductDetailStatusTxt.TabIndex = 27;
            // 
            // ProductDetailPriceNud
            // 
            this.ProductDetailPriceNud.Location = new System.Drawing.Point(700, 265);
            this.ProductDetailPriceNud.Name = "ProductDetailPriceNud";
            this.ProductDetailPriceNud.Size = new System.Drawing.Size(120, 22);
            this.ProductDetailPriceNud.TabIndex = 28;
            // 
            // ProductDetailStockNud
            // 
            this.ProductDetailStockNud.Location = new System.Drawing.Point(700, 311);
            this.ProductDetailStockNud.Name = "ProductDetailStockNud";
            this.ProductDetailStockNud.Size = new System.Drawing.Size(120, 22);
            this.ProductDetailStockNud.TabIndex = 28;
            // 
            // ProductDetailImagePb
            // 
            this.ProductDetailImagePb.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ProductDetailImagePb.Location = new System.Drawing.Point(621, 360);
            this.ProductDetailImagePb.Name = "ProductDetailImagePb";
            this.ProductDetailImagePb.Size = new System.Drawing.Size(199, 69);
            this.ProductDetailImagePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductDetailImagePb.TabIndex = 29;
            this.ProductDetailImagePb.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(45, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 29);
            this.label8.TabIndex = 30;
            this.label8.Text = "Product List";
            // 
            // CategoryCb
            // 
            this.CategoryCb.FormattingEnabled = true;
            this.CategoryCb.Location = new System.Drawing.Point(161, 360);
            this.CategoryCb.Name = "CategoryCb";
            this.CategoryCb.Size = new System.Drawing.Size(199, 24);
            this.CategoryCb.TabIndex = 31;
            // 
            // ProductDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(859, 764);
            this.Controls.Add(this.CategoryCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProductDetailImagePb);
            this.Controls.Add(this.ProductDetailStockNud);
            this.Controls.Add(this.ProductDetailPriceNud);
            this.Controls.Add(this.ProductDetailStatusTxt);
            this.Controls.Add(this.ProductDetailDescTxt);
            this.Controls.Add(this.ProductDetailNameTxt);
            this.Controls.Add(this.AddNewProductBtn);
            this.Controls.Add(this.ProductDeleteBtn);
            this.Controls.Add(this.ProductEditImageBtn);
            this.Controls.Add(this.UpdateProductBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductDetailDgv);
            this.Name = "ProductDetailForm";
            this.Text = "ProductDetailForm";
            this.Load += new System.EventHandler(this.ProductDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDetailDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDetailPriceNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDetailStockNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDetailImagePb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductDetailDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddNewProductBtn;
        private System.Windows.Forms.Button ProductDeleteBtn;
        private System.Windows.Forms.Button ProductEditImageBtn;
        private System.Windows.Forms.Button UpdateProductBtn;
        private System.Windows.Forms.TextBox ProductDetailNameTxt;
        private System.Windows.Forms.TextBox ProductDetailDescTxt;
        private System.Windows.Forms.TextBox ProductDetailStatusTxt;
        private System.Windows.Forms.NumericUpDown ProductDetailPriceNud;
        private System.Windows.Forms.NumericUpDown ProductDetailStockNud;
        private System.Windows.Forms.PictureBox ProductDetailImagePb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CategoryCb;
    }
}