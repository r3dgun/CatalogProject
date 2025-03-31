namespace CatalogProject.Forms.CategoryForm
{
    partial class CompanyListFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyListFrm));
            this.dgvComanies = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddCompany = new System.Windows.Forms.ToolStripButton();
            this.BtnDeleteCompany = new System.Windows.Forms.ToolStripButton();
            this.BtnCategories = new System.Windows.Forms.ToolStripButton();
            this.BtnUpdateCompany = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanies)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComanies
            // 
            this.dgvComanies.AllowUserToAddRows = false;
            this.dgvComanies.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 10F);
            this.dgvComanies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComanies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvComanies.Location = new System.Drawing.Point(0, 39);
            this.dgvComanies.MultiSelect = false;
            this.dgvComanies.Name = "dgvComanies";
            this.dgvComanies.ReadOnly = true;
            this.dgvComanies.RowHeadersWidth = 51;
            this.dgvComanies.RowTemplate.Height = 24;
            this.dgvComanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComanies.Size = new System.Drawing.Size(1191, 798);
            this.dgvComanies.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCompany,
            this.BtnDeleteCompany,
            this.BtnCategories,
            this.BtnUpdateCompany});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1191, 36);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCompany.Image")));
            this.btnAddCompany.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(69, 33);
            this.btnAddCompany.Text = "اضافه";
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_ButtonClick);
            // 
            // BtnDeleteCompany
            // 
            this.BtnDeleteCompany.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteCompany.Image")));
            this.BtnDeleteCompany.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDeleteCompany.Name = "BtnDeleteCompany";
            this.BtnDeleteCompany.Size = new System.Drawing.Size(69, 33);
            this.BtnDeleteCompany.Text = "حذف";
            this.BtnDeleteCompany.Click += new System.EventHandler(this.BtnDeleteCompany_ButtonClick);
            // 
            // BtnCategories
            // 
            this.BtnCategories.Image = ((System.Drawing.Image)(resources.GetObject("BtnCategories.Image")));
            this.BtnCategories.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCategories.Name = "BtnCategories";
            this.BtnCategories.Size = new System.Drawing.Size(144, 33);
            this.BtnCategories.Text = "لیست کتگوری ها";
            this.BtnCategories.Click += new System.EventHandler(this.BtnCategories_ButtonClick);
            // 
            // BtnUpdateCompany
            // 
            this.BtnUpdateCompany.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdateCompany.Image")));
            this.BtnUpdateCompany.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnUpdateCompany.Name = "BtnUpdateCompany";
            this.BtnUpdateCompany.Size = new System.Drawing.Size(107, 33);
            this.BtnUpdateCompany.Text = "به روزرسانی";
            this.BtnUpdateCompany.ToolTipText = "به روزرسانی";
            this.BtnUpdateCompany.Click += new System.EventHandler(this.BtnUpdateCompany_ButtonClick);
            // 
            // CompanyList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1191, 837);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvComanies);
            this.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CompanyList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "CategoryList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanies)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvComanies;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddCompany;
        private System.Windows.Forms.ToolStripButton BtnDeleteCompany;
        private System.Windows.Forms.ToolStripButton BtnCategories;
        private System.Windows.Forms.ToolStripButton BtnUpdateCompany;
    }
}