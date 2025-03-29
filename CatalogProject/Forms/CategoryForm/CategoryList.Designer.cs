namespace CatalogProject.Forms.CategoryForm
{
    partial class CategoryList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryList));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnAddCategory = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDeleteCategory = new System.Windows.Forms.ToolStripSplitButton();
            this.btnProductList = new System.Windows.Forms.ToolStripSplitButton();
            this.btnUpdateCategory = new System.Windows.Forms.ToolStripSplitButton();
            this.DgvCategories = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCategory,
            this.toolStripStatusLabel2,
            this.btnDeleteCategory,
            this.btnProductList,
            this.btnUpdateCategory});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(875, 35);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Image")));
            this.btnAddCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddCategory.Size = new System.Drawing.Size(84, 33);
            this.btnAddCategory.Text = "اضافه";
            this.btnAddCategory.ButtonClick += new System.EventHandler(this.btnAddCategory_ButtonClick);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 29);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCategory.Image")));
            this.btnDeleteCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteCategory.Size = new System.Drawing.Size(84, 33);
            this.btnDeleteCategory.Text = "حذف";
            this.btnDeleteCategory.ButtonClick += new System.EventHandler(this.btnDeleteCategory_ButtonClick);
            // 
            // btnProductList
            // 
            this.btnProductList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.btnProductList.Image = ((System.Drawing.Image)(resources.GetObject("btnProductList.Image")));
            this.btnProductList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnProductList.Size = new System.Drawing.Size(159, 33);
            this.btnProductList.Text = "لیست محصول ها";
            this.btnProductList.ButtonClick += new System.EventHandler(this.btnProductList_ButtonClick);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.btnUpdateCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCategory.Image")));
            this.btnUpdateCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdateCategory.Size = new System.Drawing.Size(122, 33);
            this.btnUpdateCategory.Text = "به روزرسانی";
            this.btnUpdateCategory.ButtonClick += new System.EventHandler(this.btnUpdateCategory_ButtonClick);
            // 
            // DgvCategories
            // 
            this.DgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvCategories.Location = new System.Drawing.Point(0, 38);
            this.DgvCategories.Name = "DgvCategories";
            this.DgvCategories.RowHeadersWidth = 51;
            this.DgvCategories.RowTemplate.Height = 24;
            this.DgvCategories.Size = new System.Drawing.Size(875, 426);
            this.DgvCategories.TabIndex = 5;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // CategoryList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(875, 464);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DgvCategories);
            this.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.Name = "CategoryList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "CategoryList";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton btnAddCategory;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.DataGridView DgvCategories;
        private System.Windows.Forms.ToolStripSplitButton btnProductList;
        private System.Windows.Forms.ToolStripSplitButton btnDeleteCategory;
        private System.Windows.Forms.ToolStripSplitButton btnUpdateCategory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}