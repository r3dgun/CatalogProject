namespace CatalogProject.ProductFroms
{
    partial class ProductsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsList));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnAddProduct = new System.Windows.Forms.ToolStripSplitButton();
            this.BtnUpdateProduct = new System.Windows.Forms.ToolStripSplitButton();
            this.BtnDeleteProduct = new System.Windows.Forms.ToolStripSplitButton();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddProduct,
            this.BtnUpdateProduct,
            this.BtnDeleteProduct});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1045, 35);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddProduct.Size = new System.Drawing.Size(84, 33);
            this.btnAddProduct.Text = "اضافه";
            this.btnAddProduct.ButtonClick += new System.EventHandler(this.btnAddProduct_ButtonClick);
            // 
            // BtnUpdateProduct
            // 
            this.BtnUpdateProduct.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.BtnUpdateProduct.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdateProduct.Image")));
            this.BtnUpdateProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnUpdateProduct.Name = "BtnUpdateProduct";
            this.BtnUpdateProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnUpdateProduct.Size = new System.Drawing.Size(122, 33);
            this.BtnUpdateProduct.Text = "به روزرسانی";
            this.BtnUpdateProduct.ButtonClick += new System.EventHandler(this.BtnUpdateProduct_ButtonClick);
            // 
            // BtnDeleteProduct
            // 
            this.BtnDeleteProduct.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.BtnDeleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteProduct.Image")));
            this.BtnDeleteProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDeleteProduct.Name = "BtnDeleteProduct";
            this.BtnDeleteProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnDeleteProduct.Size = new System.Drawing.Size(84, 33);
            this.BtnDeleteProduct.Text = "حذف";
            this.BtnDeleteProduct.ButtonClick += new System.EventHandler(this.BtnDeleteProduct_ButtonClick);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProducts.Location = new System.Drawing.Point(0, 38);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(1045, 550);
            this.dgvProducts.TabIndex = 5;
            // 
            // ProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 588);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvProducts);
            this.Name = "ProductsList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ProductForm";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ToolStripSplitButton btnAddProduct;
        private System.Windows.Forms.ToolStripSplitButton BtnUpdateProduct;
        private System.Windows.Forms.ToolStripSplitButton BtnDeleteProduct;
    }
}