namespace MarketYönetimSistemi
{
    partial class AddRoleForm
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
            this.AddRoleGb = new System.Windows.Forms.GroupBox();
            this.RoleStatusCb = new System.Windows.Forms.CheckBox();
            this.AddRoleMessageLbl = new System.Windows.Forms.Label();
            this.RoleImg = new System.Windows.Forms.PictureBox();
            this.AddRoleBtn = new System.Windows.Forms.Button();
            this.RoleSelectImageBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RoleNameTxt = new System.Windows.Forms.TextBox();
            this.RoleDescriptionLbl = new System.Windows.Forms.Label();
            this.RoleDescTxt = new System.Windows.Forms.TextBox();
            this.AddRoleGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoleImg)).BeginInit();
            this.SuspendLayout();
            // 
            // AddRoleGb
            // 
            this.AddRoleGb.Controls.Add(this.RoleDescriptionLbl);
            this.AddRoleGb.Controls.Add(this.RoleDescTxt);
            this.AddRoleGb.Controls.Add(this.RoleStatusCb);
            this.AddRoleGb.Controls.Add(this.AddRoleMessageLbl);
            this.AddRoleGb.Controls.Add(this.RoleImg);
            this.AddRoleGb.Controls.Add(this.AddRoleBtn);
            this.AddRoleGb.Controls.Add(this.RoleSelectImageBtn);
            this.AddRoleGb.Controls.Add(this.label1);
            this.AddRoleGb.Controls.Add(this.RoleNameTxt);
            this.AddRoleGb.Location = new System.Drawing.Point(46, 33);
            this.AddRoleGb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRoleGb.Name = "AddRoleGb";
            this.AddRoleGb.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRoleGb.Size = new System.Drawing.Size(233, 519);
            this.AddRoleGb.TabIndex = 2;
            this.AddRoleGb.TabStop = false;
            this.AddRoleGb.Text = "Add Role";
            // 
            // RoleStatusCb
            // 
            this.RoleStatusCb.AutoSize = true;
            this.RoleStatusCb.Location = new System.Drawing.Point(27, 356);
            this.RoleStatusCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoleStatusCb.Name = "RoleStatusCb";
            this.RoleStatusCb.Size = new System.Drawing.Size(66, 20);
            this.RoleStatusCb.TabIndex = 6;
            this.RoleStatusCb.Text = "Status";
            this.RoleStatusCb.UseVisualStyleBackColor = true;
            // 
            // AddRoleMessageLbl
            // 
            this.AddRoleMessageLbl.AutoSize = true;
            this.AddRoleMessageLbl.Location = new System.Drawing.Point(27, 442);
            this.AddRoleMessageLbl.Name = "AddRoleMessageLbl";
            this.AddRoleMessageLbl.Size = new System.Drawing.Size(64, 16);
            this.AddRoleMessageLbl.TabIndex = 5;
            this.AddRoleMessageLbl.Text = "Message";
            // 
            // RoleImg
            // 
            this.RoleImg.BackColor = System.Drawing.Color.Gray;
            this.RoleImg.Location = new System.Drawing.Point(27, 222);
            this.RoleImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoleImg.Name = "RoleImg";
            this.RoleImg.Size = new System.Drawing.Size(169, 122);
            this.RoleImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoleImg.TabIndex = 4;
            this.RoleImg.TabStop = false;
            // 
            // AddRoleBtn
            // 
            this.AddRoleBtn.BackColor = System.Drawing.Color.Green;
            this.AddRoleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddRoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddRoleBtn.ForeColor = System.Drawing.Color.White;
            this.AddRoleBtn.Location = new System.Drawing.Point(27, 389);
            this.AddRoleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRoleBtn.Name = "AddRoleBtn";
            this.AddRoleBtn.Size = new System.Drawing.Size(127, 48);
            this.AddRoleBtn.TabIndex = 3;
            this.AddRoleBtn.Text = "Add Role";
            this.AddRoleBtn.UseVisualStyleBackColor = false;
            this.AddRoleBtn.Click += new System.EventHandler(this.AddRoleBtn_Click);
            // 
            // RoleSelectImageBtn
            // 
            this.RoleSelectImageBtn.Location = new System.Drawing.Point(27, 190);
            this.RoleSelectImageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoleSelectImageBtn.Name = "RoleSelectImageBtn";
            this.RoleSelectImageBtn.Size = new System.Drawing.Size(169, 27);
            this.RoleSelectImageBtn.TabIndex = 2;
            this.RoleSelectImageBtn.Text = "Select Image";
            this.RoleSelectImageBtn.UseVisualStyleBackColor = true;
            this.RoleSelectImageBtn.Click += new System.EventHandler(this.RoleSelectImageBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Role Name";
            // 
            // RoleNameTxt
            // 
            this.RoleNameTxt.Location = new System.Drawing.Point(27, 54);
            this.RoleNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoleNameTxt.Name = "RoleNameTxt";
            this.RoleNameTxt.Size = new System.Drawing.Size(169, 22);
            this.RoleNameTxt.TabIndex = 0;
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
            // RoleDescTxt
            // 
            this.RoleDescTxt.Location = new System.Drawing.Point(27, 119);
            this.RoleDescTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoleDescTxt.Name = "RoleDescTxt";
            this.RoleDescTxt.Size = new System.Drawing.Size(169, 22);
            this.RoleDescTxt.TabIndex = 7;
            // 
            // AddRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 610);
            this.Controls.Add(this.AddRoleGb);
            this.Name = "AddRoleForm";
            this.Text = "AddRoleForm";
            this.AddRoleGb.ResumeLayout(false);
            this.AddRoleGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoleImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddRoleGb;
        private System.Windows.Forms.CheckBox RoleStatusCb;
        private System.Windows.Forms.Label AddRoleMessageLbl;
        private System.Windows.Forms.PictureBox RoleImg;
        private System.Windows.Forms.Button AddRoleBtn;
        private System.Windows.Forms.Button RoleSelectImageBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RoleNameTxt;
        private System.Windows.Forms.Label RoleDescriptionLbl;
        private System.Windows.Forms.TextBox RoleDescTxt;
    }
}