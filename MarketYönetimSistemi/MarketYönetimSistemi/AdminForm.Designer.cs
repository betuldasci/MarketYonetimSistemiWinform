namespace MarketYönetimSistemi
{
    partial class AdminForm
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
            this.CustomerDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductDgv = new System.Windows.Forms.DataGridView();
            this.CustomerDetailBtn = new System.Windows.Forms.Button();
            this.ProductDetailBtn = new System.Windows.Forms.Button();
            this.WellcomeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerDgv
            // 
            this.CustomerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDgv.Location = new System.Drawing.Point(20, 127);
            this.CustomerDgv.Name = "CustomerDgv";
            this.CustomerDgv.RowHeadersWidth = 51;
            this.CustomerDgv.RowTemplate.Height = 24;
            this.CustomerDgv.Size = new System.Drawing.Size(494, 142);
            this.CustomerDgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(588, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product List";
            // 
            // ProductDgv
            // 
            this.ProductDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDgv.Location = new System.Drawing.Point(591, 127);
            this.ProductDgv.Name = "ProductDgv";
            this.ProductDgv.RowHeadersWidth = 51;
            this.ProductDgv.RowTemplate.Height = 24;
            this.ProductDgv.Size = new System.Drawing.Size(465, 142);
            this.ProductDgv.TabIndex = 2;
            // 
            // CustomerDetailBtn
            // 
            this.CustomerDetailBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.CustomerDetailBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomerDetailBtn.Location = new System.Drawing.Point(373, 83);
            this.CustomerDetailBtn.Name = "CustomerDetailBtn";
            this.CustomerDetailBtn.Size = new System.Drawing.Size(141, 38);
            this.CustomerDetailBtn.TabIndex = 4;
            this.CustomerDetailBtn.Text = "Customer Detail";
            this.CustomerDetailBtn.UseVisualStyleBackColor = false;
            this.CustomerDetailBtn.Click += new System.EventHandler(this.CustomerDetailBtn_Click);
            // 
            // ProductDetailBtn
            // 
            this.ProductDetailBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.ProductDetailBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductDetailBtn.Location = new System.Drawing.Point(931, 83);
            this.ProductDetailBtn.Name = "ProductDetailBtn";
            this.ProductDetailBtn.Size = new System.Drawing.Size(125, 37);
            this.ProductDetailBtn.TabIndex = 5;
            this.ProductDetailBtn.Text = "Product Detail";
            this.ProductDetailBtn.UseVisualStyleBackColor = false;
            this.ProductDetailBtn.Click += new System.EventHandler(this.ProductDetailBtn_Click);
            // 
            // WellcomeLbl
            // 
            this.WellcomeLbl.AutoSize = true;
            this.WellcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WellcomeLbl.Location = new System.Drawing.Point(17, 9);
            this.WellcomeLbl.Name = "WellcomeLbl";
            this.WellcomeLbl.Size = new System.Drawing.Size(79, 29);
            this.WellcomeLbl.TabIndex = 6;
            this.WellcomeLbl.Text = "label3";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1081, 377);
            this.Controls.Add(this.WellcomeLbl);
            this.Controls.Add(this.ProductDetailBtn);
            this.Controls.Add(this.CustomerDetailBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductDgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerDgv);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ProductDgv;
        private System.Windows.Forms.Button CustomerDetailBtn;
        private System.Windows.Forms.Button ProductDetailBtn;
        private System.Windows.Forms.Label WellcomeLbl;
    }
}