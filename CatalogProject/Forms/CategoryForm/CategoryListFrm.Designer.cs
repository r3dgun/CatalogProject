namespace CatalogProject.Forms.CategoryForm
{
    partial class CategoryListFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryListFrm));
            this.DgvCategories = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddCategory = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateCategory = new System.Windows.Forms.ToolStripButton();
            this.btnProductList = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCategory = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvCategories
            // 
            this.DgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvCategories.Location = new System.Drawing.Point(0, 39);
            this.DgvCategories.Name = "DgvCategories";
            this.DgvCategories.RowHeadersWidth = 51;
            this.DgvCategories.RowTemplate.Height = 24;
            this.DgvCategories.Size = new System.Drawing.Size(875, 425);
            this.DgvCategories.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCategory,
            this.btnDeleteCategory,
            this.btnProductList,
            this.btnUpdateCategory});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(875, 36);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Image")));
            this.btnAddCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(69, 33);
            this.btnAddCategory.Text = "اضافه";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_ButtonClick);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCategory.Image")));
            this.btnUpdateCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(107, 33);
            this.btnUpdateCategory.Text = "به روزرسانی";
            this.btnUpdateCategory.ToolTipText = "به روزرسانی";
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_ButtonClick);
            // 
            // btnProductList
            // 
            this.btnProductList.Image = ((System.Drawing.Image)(resources.GetObject("btnProductList.Image")));
            this.btnProductList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(144, 33);
            this.btnProductList.Text = "لیست محصول ها";
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_ButtonClick);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCategory.Image")));
            this.btnDeleteCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(69, 33);
            this.btnDeleteCategory.Text = "حذف";
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_ButtonClick);
            // 
            // CategoryList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(875, 464);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DgvCategories);
            this.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.Name = "CategoryList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "CategoryList";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvCategories;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddCategory;
        private System.Windows.Forms.ToolStripButton btnDeleteCategory;
        private System.Windows.Forms.ToolStripButton btnProductList;
        private System.Windows.Forms.ToolStripButton btnUpdateCategory;
    }
}