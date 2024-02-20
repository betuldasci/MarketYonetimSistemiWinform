namespace MarketYönetimSistemi
{
    partial class AddUserForm
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
            this.UserDescriptionLbl = new System.Windows.Forms.Label();
            this.UserDescTxt = new System.Windows.Forms.TextBox();
            this.AddUserMessageLbl = new System.Windows.Forms.Label();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.UserRolesCb = new System.Windows.Forms.ComboBox();
            this.RolesLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.UserPasswordTxt = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.UserEmailTxt = new System.Windows.Forms.TextBox();
            this.UserSurnamelbl = new System.Windows.Forms.Label();
            this.UserSurnameTxt = new System.Windows.Forms.TextBox();
            this.UserStatusCb = new System.Windows.Forms.CheckBox();
            this.UserImg = new System.Windows.Forms.PictureBox();
            this.UserSelectImageBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.AddUserGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImg)).BeginInit();
            this.SuspendLayout();
            // 
            // AddUserGb
            // 
            this.AddUserGb.Controls.Add(this.UserDescriptionLbl);
            this.AddUserGb.Controls.Add(this.UserDescTxt);
            this.AddUserGb.Controls.Add(this.AddUserMessageLbl);
            this.AddUserGb.Controls.Add(this.AddUserBtn);
            this.AddUserGb.Controls.Add(this.UserRolesCb);
            this.AddUserGb.Controls.Add(this.RolesLbl);
            this.AddUserGb.Controls.Add(this.PasswordLbl);
            this.AddUserGb.Controls.Add(this.UserPasswordTxt);
            this.AddUserGb.Controls.Add(this.EmailLbl);
            this.AddUserGb.Controls.Add(this.UserEmailTxt);
            this.AddUserGb.Controls.Add(this.UserSurnamelbl);
            this.AddUserGb.Controls.Add(this.UserSurnameTxt);
            this.AddUserGb.Controls.Add(this.UserStatusCb);
            this.AddUserGb.Controls.Add(this.UserImg);
            this.AddUserGb.Controls.Add(this.UserSelectImageBtn);
            this.AddUserGb.Controls.Add(this.label2);
            this.AddUserGb.Controls.Add(this.UserNameTxt);
            this.AddUserGb.Location = new System.Drawing.Point(61, 27);
            this.AddUserGb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddUserGb.Name = "AddUserGb";
            this.AddUserGb.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddUserGb.Size = new System.Drawing.Size(567, 399);
            this.AddUserGb.TabIndex = 3;
            this.AddUserGb.TabStop = false;
            this.AddUserGb.Text = "Add User";
            // 
            // UserDescriptionLbl
            // 
            this.UserDescriptionLbl.AutoSize = true;
            this.UserDescriptionLbl.Location = new System.Drawing.Point(91, 330);
            this.UserDescriptionLbl.Name = "UserDescriptionLbl";
            this.UserDescriptionLbl.Size = new System.Drawing.Size(75, 16);
            this.UserDescriptionLbl.TabIndex = 23;
            this.UserDescriptionLbl.Text = "Description";
            // 
            // UserDescTxt
            // 
            this.UserDescTxt.Location = new System.Drawing.Point(91, 351);
            this.UserDescTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserDescTxt.Name = "UserDescTxt";
            this.UserDescTxt.Size = new System.Drawing.Size(169, 22);
            this.UserDescTxt.TabIndex = 22;
            // 
            // AddUserMessageLbl
            // 
            this.AddUserMessageLbl.AutoSize = true;
            this.AddUserMessageLbl.Location = new System.Drawing.Point(315, 340);
            this.AddUserMessageLbl.Name = "AddUserMessageLbl";
            this.AddUserMessageLbl.Size = new System.Drawing.Size(64, 16);
            this.AddUserMessageLbl.TabIndex = 21;
            this.AddUserMessageLbl.Text = "Message";
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddUserBtn.ForeColor = System.Drawing.Color.White;
            this.AddUserBtn.Location = new System.Drawing.Point(315, 287);
            this.AddUserBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(169, 48);
            this.AddUserBtn.TabIndex = 20;
            this.AddUserBtn.Text = "Add Customer";
            this.AddUserBtn.UseVisualStyleBackColor = false;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // UserRolesCb
            // 
            this.UserRolesCb.FormattingEnabled = true;
            this.UserRolesCb.Location = new System.Drawing.Point(91, 292);
            this.UserRolesCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserRolesCb.Name = "UserRolesCb";
            this.UserRolesCb.Size = new System.Drawing.Size(169, 24);
            this.UserRolesCb.TabIndex = 19;
            // 
            // RolesLbl
            // 
            this.RolesLbl.AutoSize = true;
            this.RolesLbl.Location = new System.Drawing.Point(91, 273);
            this.RolesLbl.Name = "RolesLbl";
            this.RolesLbl.Size = new System.Drawing.Size(43, 16);
            this.RolesLbl.TabIndex = 18;
            this.RolesLbl.Text = "Roles";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(91, 211);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(67, 16);
            this.PasswordLbl.TabIndex = 17;
            this.PasswordLbl.Text = "Password";
            // 
            // UserPasswordTxt
            // 
            this.UserPasswordTxt.Location = new System.Drawing.Point(91, 232);
            this.UserPasswordTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserPasswordTxt.Name = "UserPasswordTxt";
            this.UserPasswordTxt.PasswordChar = '*';
            this.UserPasswordTxt.Size = new System.Drawing.Size(169, 22);
            this.UserPasswordTxt.TabIndex = 16;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(91, 148);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(41, 16);
            this.EmailLbl.TabIndex = 15;
            this.EmailLbl.Text = "Email";
            // 
            // UserEmailTxt
            // 
            this.UserEmailTxt.Location = new System.Drawing.Point(91, 168);
            this.UserEmailTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserEmailTxt.Name = "UserEmailTxt";
            this.UserEmailTxt.Size = new System.Drawing.Size(169, 22);
            this.UserEmailTxt.TabIndex = 14;
            // 
            // UserSurnamelbl
            // 
            this.UserSurnamelbl.AutoSize = true;
            this.UserSurnamelbl.Location = new System.Drawing.Point(91, 88);
            this.UserSurnamelbl.Name = "UserSurnamelbl";
            this.UserSurnamelbl.Size = new System.Drawing.Size(61, 16);
            this.UserSurnamelbl.TabIndex = 13;
            this.UserSurnamelbl.Text = "Surname";
            // 
            // UserSurnameTxt
            // 
            this.UserSurnameTxt.Location = new System.Drawing.Point(91, 108);
            this.UserSurnameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserSurnameTxt.Name = "UserSurnameTxt";
            this.UserSurnameTxt.Size = new System.Drawing.Size(169, 22);
            this.UserSurnameTxt.TabIndex = 12;
            // 
            // UserStatusCb
            // 
            this.UserStatusCb.AutoSize = true;
            this.UserStatusCb.Location = new System.Drawing.Point(315, 254);
            this.UserStatusCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserStatusCb.Name = "UserStatusCb";
            this.UserStatusCb.Size = new System.Drawing.Size(66, 20);
            this.UserStatusCb.TabIndex = 11;
            this.UserStatusCb.Text = "Status";
            this.UserStatusCb.UseVisualStyleBackColor = true;
            // 
            // UserImg
            // 
            this.UserImg.BackColor = System.Drawing.Color.Gray;
            this.UserImg.Location = new System.Drawing.Point(315, 80);
            this.UserImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserImg.Name = "UserImg";
            this.UserImg.Size = new System.Drawing.Size(169, 152);
            this.UserImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserImg.TabIndex = 10;
            this.UserImg.TabStop = false;
            // 
            // UserSelectImageBtn
            // 
            this.UserSelectImageBtn.Location = new System.Drawing.Point(315, 48);
            this.UserSelectImageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserSelectImageBtn.Name = "UserSelectImageBtn";
            this.UserSelectImageBtn.Size = new System.Drawing.Size(169, 27);
            this.UserSelectImageBtn.TabIndex = 9;
            this.UserSelectImageBtn.Text = "Select Image";
            this.UserSelectImageBtn.UseVisualStyleBackColor = true;
            this.UserSelectImageBtn.Click += new System.EventHandler(this.UserSelectImageBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Location = new System.Drawing.Point(91, 52);
            this.UserNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(169, 22);
            this.UserNameTxt.TabIndex = 7;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 456);
            this.Controls.Add(this.AddUserGb);
            this.Name = "AddUserForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AddUserGb.ResumeLayout(false);
            this.AddUserGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox AddUserGb;
        private System.Windows.Forms.Label AddUserMessageLbl;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.ComboBox UserRolesCb;
        private System.Windows.Forms.Label RolesLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox UserPasswordTxt;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox UserEmailTxt;
        private System.Windows.Forms.Label UserSurnamelbl;
        private System.Windows.Forms.TextBox UserSurnameTxt;
        private System.Windows.Forms.CheckBox UserStatusCb;
        private System.Windows.Forms.PictureBox UserImg;
        private System.Windows.Forms.Button UserSelectImageBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.Label UserDescriptionLbl;
        private System.Windows.Forms.TextBox UserDescTxt;
    }
}

