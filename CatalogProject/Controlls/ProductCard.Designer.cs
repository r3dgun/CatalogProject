namespace CatalogProject.Controlls
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCard));
            this.GradientPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.Pic_Box = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ProductDesc = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_ProductPrice = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_ProductMainText = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_ProductName = new Bunifu.UI.WinForms.BunifuLabel();
            this.GradientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GradientPanel
            // 
            this.GradientPanel.BackColor = System.Drawing.Color.Transparent;
            this.GradientPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GradientPanel.BackgroundImage")));
            this.GradientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GradientPanel.BorderRadius = 1;
            this.GradientPanel.Controls.Add(this.tableLayoutPanel);
            this.GradientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GradientPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(92)))), ((int)(((byte)(188)))));
            this.GradientPanel.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.GradientPanel.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.GradientPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(60)))), ((int)(((byte)(212)))));
            this.GradientPanel.Location = new System.Drawing.Point(0, 0);
            this.GradientPanel.Name = "GradientPanel";
            this.GradientPanel.Quality = 10;
            this.GradientPanel.Size = new System.Drawing.Size(349, 627);
            this.GradientPanel.TabIndex = 2;
            // 
            // Pic_Box
            // 
            this.Pic_Box.AllowFocused = false;
            this.Pic_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pic_Box.AutoSizeHeight = true;
            this.Pic_Box.BorderRadius = 118;
            this.Pic_Box.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Box.Image")));
            this.Pic_Box.IsCircle = true;
            this.Pic_Box.Location = new System.Drawing.Point(56, 39);
            this.Pic_Box.Name = "Pic_Box";
            this.Pic_Box.Size = new System.Drawing.Size(237, 237);
            this.Pic_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Box.TabIndex = 9;
            this.Pic_Box.TabStop = false;
            this.Pic_Box.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.lbl_ProductName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lbl_ProductMainText, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.lbl_ProductPrice, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.lbl_ProductDesc, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.Pic_Box, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.tableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(349, 627);
            this.tableLayoutPanel.TabIndex = 21;
            // 
            // lbl_ProductDesc
            // 
            this.lbl_ProductDesc.AllowParentOverrides = false;
            this.lbl_ProductDesc.AutoEllipsis = false;
            this.lbl_ProductDesc.CursorType = null;
            this.lbl_ProductDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_ProductDesc.Location = new System.Drawing.Point(202, 547);
            this.lbl_ProductDesc.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_ProductDesc.Name = "lbl_ProductDesc";
            this.lbl_ProductDesc.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_ProductDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_ProductDesc.Size = new System.Drawing.Size(107, 26);
            this.lbl_ProductDesc.TabIndex = 7;
            this.lbl_ProductDesc.Text = "توضیحات :";
            this.lbl_ProductDesc.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ProductDesc.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.AllowParentOverrides = false;
            this.lbl_ProductPrice.AutoEllipsis = false;
            this.lbl_ProductPrice.CursorType = null;
            this.lbl_ProductPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_ProductPrice.Location = new System.Drawing.Point(226, 470);
            this.lbl_ProductPrice.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_ProductPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_ProductPrice.Size = new System.Drawing.Size(83, 26);
            this.lbl_ProductPrice.TabIndex = 6;
            this.lbl_ProductPrice.Text = "قیمت :";
            this.lbl_ProductPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ProductPrice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_ProductMainText
            // 
            this.lbl_ProductMainText.AllowParentOverrides = false;
            this.lbl_ProductMainText.AutoEllipsis = false;
            this.lbl_ProductMainText.CursorType = null;
            this.lbl_ProductMainText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_ProductMainText.Location = new System.Drawing.Point(168, 393);
            this.lbl_ProductMainText.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_ProductMainText.Name = "lbl_ProductMainText";
            this.lbl_ProductMainText.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_ProductMainText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_ProductMainText.Size = new System.Drawing.Size(141, 26);
            this.lbl_ProductMainText.TabIndex = 5;
            this.lbl_ProductMainText.Text = "توضیحات اصلی";
            this.lbl_ProductMainText.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ProductMainText.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AllowParentOverrides = false;
            this.lbl_ProductName.AutoEllipsis = false;
            this.lbl_ProductName.CursorType = null;
            this.lbl_ProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_ProductName.Location = new System.Drawing.Point(189, 316);
            this.lbl_ProductName.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_ProductName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_ProductName.Size = new System.Drawing.Size(120, 26);
            this.lbl_ProductName.TabIndex = 4;
            this.lbl_ProductName.Text = "نام محصول :";
            this.lbl_ProductName.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ProductName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GradientPanel);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(349, 627);
            this.GradientPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel GradientPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Bunifu.UI.WinForms.BunifuLabel lbl_ProductName;
        private Bunifu.UI.WinForms.BunifuLabel lbl_ProductMainText;
        private Bunifu.UI.WinForms.BunifuLabel lbl_ProductPrice;
        private Bunifu.UI.WinForms.BunifuLabel lbl_ProductDesc;
        private Bunifu.UI.WinForms.BunifuPictureBox Pic_Box;
    }
}
