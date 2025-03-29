namespace CatalogProject.Forms.CategoryForm
{
    partial class CompanyList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnAddCompany = new System.Windows.Forms.ToolStripSplitButton();
            this.BtnDeleteCompany = new System.Windows.Forms.ToolStripSplitButton();
            this.BtnCategories = new System.Windows.Forms.ToolStripSplitButton();
            this.BtnUpdate = new System.Windows.Forms.ToolStripSplitButton();
            this.dgvComanies = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanies)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCompany,
            this.BtnDeleteCompany,
            this.BtnCategories,
            this.BtnUpdate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(16, 0, 2, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1426, 35);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.btnAddCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCompany.Image")));
            this.btnAddCompany.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddCompany.Size = new System.Drawing.Size(84, 33);
            this.btnAddCompany.Text = "اضافه";
            this.btnAddCompany.ButtonClick += new System.EventHandler(this.btnAddCompany_ButtonClick);
            // 
            // BtnDeleteCompany
            // 
            this.BtnDeleteCompany.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.BtnDeleteCompany.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteCompany.Image")));
            this.BtnDeleteCompany.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDeleteCompany.Name = "BtnDeleteCompany";
            this.BtnDeleteCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnDeleteCompany.Size = new System.Drawing.Size(84, 33);
            this.BtnDeleteCompany.Text = "حذف";
            this.BtnDeleteCompany.ButtonClick += new System.EventHandler(this.BtnDeleteCompany_ButtonClick);
            // 
            // BtnCategories
            // 
            this.BtnCategories.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.BtnCategories.Image = ((System.Drawing.Image)(resources.GetObject("BtnCategories.Image")));
            this.BtnCategories.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCategories.Name = "BtnCategories";
            this.BtnCategories.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCategories.Size = new System.Drawing.Size(159, 33);
            this.BtnCategories.Text = "لیست کتگوری ها";
            this.BtnCategories.ButtonClick += new System.EventHandler(this.BtnCategories_ButtonClick);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.BtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.Image")));
            this.BtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnUpdate.Size = new System.Drawing.Size(122, 33);
            this.BtnUpdate.Text = "به روزرسانی";
            this.BtnUpdate.ButtonClick += new System.EventHandler(this.BtnUpdate_ButtonClick);
            // 
            // dgvComanies
            // 
            this.dgvComanies.AllowUserToAddRows = false;
            this.dgvComanies.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 10F);
            this.dgvComanies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComanies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvComanies.Location = new System.Drawing.Point(0, 52);
            this.dgvComanies.MultiSelect = false;
            this.dgvComanies.Name = "dgvComanies";
            this.dgvComanies.ReadOnly = true;
            this.dgvComanies.RowHeadersWidth = 51;
            this.dgvComanies.RowTemplate.Height = 24;
            this.dgvComanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComanies.Size = new System.Drawing.Size(1426, 785);
            this.dgvComanies.TabIndex = 7;
            // 
            // CompanyList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1426, 837);
            this.Controls.Add(this.dgvComanies);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CompanyList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "CategoryList";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton btnAddCompany;
        private System.Windows.Forms.ToolStripSplitButton BtnDeleteCompany;
        private System.Windows.Forms.ToolStripSplitButton BtnCategories;
        private System.Windows.Forms.ToolStripSplitButton BtnUpdate;
        private System.Windows.Forms.DataGridView dgvComanies;
    }
}