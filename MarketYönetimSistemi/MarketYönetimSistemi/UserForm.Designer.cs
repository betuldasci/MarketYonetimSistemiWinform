namespace MarketYönetimSistemi
{
    partial class UserForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConfirmBasketBtn = new System.Windows.Forms.Button();
            this.BasketLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WellcomeLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.ConfirmBasketBtn);
            this.panel1.Controls.Add(this.BasketLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.WellcomeLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 80);
            this.panel1.TabIndex = 1;
            // 
            // ConfirmBasketBtn
            // 
            this.ConfirmBasketBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ConfirmBasketBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConfirmBasketBtn.Location = new System.Drawing.Point(12, 44);
            this.ConfirmBasketBtn.Name = "ConfirmBasketBtn";
            this.ConfirmBasketBtn.Size = new System.Drawing.Size(131, 36);
            this.ConfirmBasketBtn.TabIndex = 4;
            this.ConfirmBasketBtn.Text = "Go To Basket";
            this.ConfirmBasketBtn.UseVisualStyleBackColor = false;
            this.ConfirmBasketBtn.Click += new System.EventHandler(this.ConfirmBasketBtn_Click);
            // 
            // BasketLbl
            // 
            this.BasketLbl.AutoSize = true;
            this.BasketLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BasketLbl.Location = new System.Drawing.Point(102, 14);
            this.BasketLbl.Name = "BasketLbl";
            this.BasketLbl.Size = new System.Drawing.Size(80, 23);
            this.BasketLbl.TabIndex = 3;
            this.BasketLbl.Text = "BASKET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "BASKET:";
            // 
            // WellcomeLbl
            // 
            this.WellcomeLbl.AutoSize = true;
            this.WellcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WellcomeLbl.ForeColor = System.Drawing.Color.White;
            this.WellcomeLbl.Location = new System.Drawing.Point(317, 14);
            this.WellcomeLbl.Name = "WellcomeLbl";
            this.WellcomeLbl.Size = new System.Drawing.Size(130, 31);
            this.WellcomeLbl.TabIndex = 0;
            this.WellcomeLbl.Text = "Products";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 377);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 457);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.SizeChanged += new System.EventHandler(this.UserForm_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label WellcomeLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BasketLbl;
        private System.Windows.Forms.Button ConfirmBasketBtn;
    }
}