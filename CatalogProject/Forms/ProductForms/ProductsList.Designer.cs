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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddProduct = new System.Windows.Forms.ToolStripButton();
            this.BtnDeleteProduct = new System.Windows.Forms.ToolStripButton();
            this.BtnUpdateProduct = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProducts.Location = new System.Drawing.Point(0, 39);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(1045, 549);
            this.dgvProducts.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddProduct,
            this.BtnDeleteProduct,
            this.BtnUpdateProduct});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1045, 36);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(69, 33);
            this.btnAddProduct.Text = "اضافه";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_ButtonClick);
            // 
            // BtnDeleteProduct
            // 
            this.BtnDeleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteProduct.Image")));
            this.BtnDeleteProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDeleteProduct.Name = "BtnDeleteProduct";
            this.BtnDeleteProduct.Size = new System.Drawing.Size(69, 33);
            this.BtnDeleteProduct.Text = "حذف";
            this.BtnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_ButtonClick);
            // 
            // BtnUpdateProduct
            // 
            this.BtnUpdateProduct.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdateProduct.Image")));
            this.BtnUpdateProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnUpdateProduct.Name = "BtnUpdateProduct";
            this.BtnUpdateProduct.Size = new System.Drawing.Size(107, 33);
            this.BtnUpdateProduct.Text = "به روزرسانی";
            this.BtnUpdateProduct.ToolTipText = "به روزرسانی";
            this.BtnUpdateProduct.Click += new System.EventHandler(this.BtnUpdateProduct_ButtonClick);
            // 
            // ProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 588);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvProducts);
            this.Name = "ProductsList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddProduct;
        private System.Windows.Forms.ToolStripButton BtnDeleteProduct;
        private System.Windows.Forms.ToolStripButton BtnUpdateProduct;
    }
}