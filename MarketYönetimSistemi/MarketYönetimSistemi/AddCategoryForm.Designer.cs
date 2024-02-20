namespace MarketYönetimSistemi
{
    partial class AddCategoryForm
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
            this.AddProductGb = new System.Windows.Forms.GroupBox();
            this.RoleDescriptionLbl = new System.Windows.Forms.Label();
            this.CategoryDescTxt = new System.Windows.Forms.TextBox();
            this.CategoryStatusCb = new System.Windows.Forms.CheckBox();
            this.AddCatMessageLbl = new System.Windows.Forms.Label();
            this.CategoryImagePb = new System.Windows.Forms.PictureBox();
            this.AddCategoryBtn = new System.Windows.Forms.Button();
            this.CategorySelectImageBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryNameTxt = new System.Windows.Forms.TextBox();
            this.AddProductGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryImagePb)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductGb
            // 
            this.AddProductGb.Controls.Add(this.RoleDescriptionLbl);
            this.AddProductGb.Controls.Add(this.CategoryDescTxt);
            this.AddProductGb.Controls.Add(this.CategoryStatusCb);
            this.AddProductGb.Controls.Add(this.AddCatMessageLbl);
            this.AddProductGb.Controls.Add(this.CategoryImagePb);
            this.AddProductGb.Controls.Add(this.AddCategoryBtn);
            this.AddProductGb.Controls.Add(this.CategorySelectImageBtn);
            this.AddProductGb.Controls.Add(this.label1);
            this.AddProductGb.Controls.Add(this.CategoryNameTxt);
            this.AddProductGb.Location = new System.Drawing.Point(47, 11);
            this.AddProductGb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddProductGb.Name = "AddProductGb";
            this.AddProductGb.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddProductGb.Size = new System.Drawing.Size(233, 519);
            this.AddProductGb.TabIndex = 3;
            this.AddProductGb.TabStop = false;
            this.AddProductGb.Text = "Add Category";
            // 
            // RoleDescriptionLbl
            // 
            this.RoleDescriptionLbl.AutoSize = true;
            this.RoleDescriptionLbl.Location = new System.Drawing.Point(27, 98);
            this.RoleDescriptionLbl.Name = "RoleDescriptionLbl";
            this.RoleDescriptionLbl.Size = new System.Drawing.Size(75, 16);
            this.RoleDescriptionLbl.TabIndex = 8;
            this.RoleDescriptionLbl.Text = "Description";
            // 
            // CategoryDescTxt
            // 
            this.CategoryDescTxt.Location = new System.Drawing.Point(27, 119);
            this.CategoryDescTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryDescTxt.Name = "CategoryDescTxt";
            this.CategoryDescTxt.Size = new System.Drawing.Size(169, 22);
            this.CategoryDescTxt.TabIndex = 7;
            // 
            // CategoryStatusCb
            // 
            this.CategoryStatusCb.AutoSize = true;
            this.CategoryStatusCb.Location = new System.Drawing.Point(27, 356);
            this.CategoryStatusCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryStatusCb.Name = "CategoryStatusCb";
            this.CategoryStatusCb.Size = new System.Drawing.Size(66, 20);
            this.CategoryStatusCb.TabIndex = 6;
            this.CategoryStatusCb.Text = "Status";
            this.CategoryStatusCb.UseVisualStyleBackColor = true;
            // 
            // AddCatMessageLbl
            // 
            this.AddCatMessageLbl.AutoSize = true;
            this.AddCatMessageLbl.Location = new System.Drawing.Point(27, 442);
            this.AddCatMessageLbl.Name = "AddCatMessageLbl";
            this.AddCatMessageLbl.Size = new System.Drawing.Size(64, 16);
            this.AddCatMessageLbl.TabIndex = 5;
            this.AddCatMessageLbl.Text = "Message";
            // 
            // CategoryImagePb
            // 
            this.CategoryImagePb.BackColor = System.Drawing.Color.Gray;
            this.CategoryImagePb.Location = new System.Drawing.Point(27, 222);
            this.CategoryImagePb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryImagePb.Name = "CategoryImagePb";
            this.CategoryImagePb.Size = new System.Drawing.Size(169, 122);
            this.CategoryImagePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CategoryImagePb.TabIndex = 4;
            this.CategoryImagePb.TabStop = false;
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.BackColor = System.Drawing.SystemColors.InfoText;
            this.AddCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddCategoryBtn.ForeColor = System.Drawing.Color.White;
            this.AddCategoryBtn.Location = new System.Drawing.Point(27, 389);
            this.AddCategoryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(127, 48);
            this.AddCategoryBtn.TabIndex = 3;
            this.AddCategoryBtn.Text = "Add Category";
            this.AddCategoryBtn.UseVisualStyleBackColor = false;
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // CategorySelectImageBtn
            // 
            this.CategorySelectImageBtn.Location = new System.Drawing.Point(27, 190);
            this.CategorySelectImageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategorySelectImageBtn.Name = "CategorySelectImageBtn";
            this.CategorySelectImageBtn.Size = new System.Drawing.Size(169, 27);
            this.CategorySelectImageBtn.TabIndex = 2;
            this.CategorySelectImageBtn.Text = "Select Image";
            this.CategorySelectImageBtn.UseVisualStyleBackColor = true;
            this.CategorySelectImageBtn.Click += new System.EventHandler(this.CategorySelectImageBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category Name";
            // 
            // CategoryNameTxt
            // 
            this.CategoryNameTxt.Location = new System.Drawing.Point(27, 54);
            this.CategoryNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryNameTxt.Name = "CategoryNameTxt";
            this.CategoryNameTxt.Size = new System.Drawing.Size(169, 22);
            this.CategoryNameTxt.TabIndex = 0;
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(325, 542);
            this.Controls.Add(this.AddProductGb);
            this.Name = "AddCategoryForm";
            this.Text = "AddCategoryForm";
            this.AddProductGb.ResumeLayout(false);
            this.AddProductGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryImagePb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddProductGb;
        private System.Windows.Forms.Label RoleDescriptionLbl;
        private System.Windows.Forms.TextBox CategoryDescTxt;
        private System.Windows.Forms.CheckBox CategoryStatusCb;
        private System.Windows.Forms.Label AddCatMessageLbl;
        private System.Windows.Forms.PictureBox CategoryImagePb;
        private System.Windows.Forms.Button AddCategoryBtn;
        private System.Windows.Forms.Button CategorySelectImageBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CategoryNameTxt;
    }
}