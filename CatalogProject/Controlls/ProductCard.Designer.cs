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
            this.bunifuCard = new Bunifu.Framework.UI.BunifuCards();
            this.GradientPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_CompanyName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_CompanyPhone = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_CompanyAddress = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_CompanyEmail = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_CompanyDesc = new Bunifu.UI.WinForms.BunifuLabel();
            this.Pic_Box = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuCard.SuspendLayout();
            this.GradientPanel.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCard
            // 
            this.bunifuCard.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCard.BorderRadius = 5;
            this.bunifuCard.BottomSahddow = true;
            this.bunifuCard.color = System.Drawing.Color.Tomato;
            this.bunifuCard.Controls.Add(this.GradientPanel);
            this.bunifuCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCard.LeftSahddow = false;
            this.bunifuCard.Location = new System.Drawing.Point(0, 0);
            this.bunifuCard.Name = "bunifuCard";
            this.bunifuCard.RightSahddow = true;
            this.bunifuCard.ShadowDepth = 20;
            this.bunifuCard.Size = new System.Drawing.Size(349, 627);
            this.bunifuCard.TabIndex = 0;
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
            this.GradientPanel.Location = new System.Drawing.Point(0, 5);
            this.GradientPanel.Name = "GradientPanel";
            this.GradientPanel.Quality = 10;
            this.GradientPanel.Size = new System.Drawing.Size(347, 619);
            this.GradientPanel.TabIndex = 1;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.lbl_CompanyName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lbl_CompanyPhone, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.lbl_CompanyAddress, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.lbl_CompanyEmail, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.lbl_CompanyDesc, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.Pic_Box, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.tableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(347, 619);
            this.tableLayoutPanel.TabIndex = 19;
            // 
            // lbl_CompanyName
            // 
            this.lbl_CompanyName.AllowParentOverrides = false;
            this.lbl_CompanyName.AutoEllipsis = false;
            this.lbl_CompanyName.CursorType = null;
            this.lbl_CompanyName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_CompanyName.Location = new System.Drawing.Point(200, 278);
            this.lbl_CompanyName.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_CompanyName.Name = "lbl_CompanyName";
            this.lbl_CompanyName.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_CompanyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CompanyName.Size = new System.Drawing.Size(107, 26);
            this.lbl_CompanyName.TabIndex = 4;
            this.lbl_CompanyName.Text = "نام شرکت :";
            this.lbl_CompanyName.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_CompanyName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_CompanyPhone
            // 
            this.lbl_CompanyPhone.AllowParentOverrides = false;
            this.lbl_CompanyPhone.AutoEllipsis = false;
            this.lbl_CompanyPhone.CursorType = null;
            this.lbl_CompanyPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_CompanyPhone.Location = new System.Drawing.Point(232, 346);
            this.lbl_CompanyPhone.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_CompanyPhone.Name = "lbl_CompanyPhone";
            this.lbl_CompanyPhone.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_CompanyPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CompanyPhone.Size = new System.Drawing.Size(75, 26);
            this.lbl_CompanyPhone.TabIndex = 5;
            this.lbl_CompanyPhone.Text = "تلفن :";
            this.lbl_CompanyPhone.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_CompanyPhone.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_CompanyAddress
            // 
            this.lbl_CompanyAddress.AllowParentOverrides = false;
            this.lbl_CompanyAddress.AutoEllipsis = false;
            this.lbl_CompanyAddress.CursorType = null;
            this.lbl_CompanyAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_CompanyAddress.Location = new System.Drawing.Point(225, 414);
            this.lbl_CompanyAddress.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_CompanyAddress.Name = "lbl_CompanyAddress";
            this.lbl_CompanyAddress.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_CompanyAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CompanyAddress.Size = new System.Drawing.Size(82, 26);
            this.lbl_CompanyAddress.TabIndex = 6;
            this.lbl_CompanyAddress.Text = "آدرس :";
            this.lbl_CompanyAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_CompanyAddress.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_CompanyEmail
            // 
            this.lbl_CompanyEmail.AllowParentOverrides = false;
            this.lbl_CompanyEmail.AutoEllipsis = false;
            this.lbl_CompanyEmail.CursorType = null;
            this.lbl_CompanyEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_CompanyEmail.Location = new System.Drawing.Point(227, 482);
            this.lbl_CompanyEmail.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_CompanyEmail.Name = "lbl_CompanyEmail";
            this.lbl_CompanyEmail.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_CompanyEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CompanyEmail.Size = new System.Drawing.Size(80, 26);
            this.lbl_CompanyEmail.TabIndex = 7;
            this.lbl_CompanyEmail.Text = "ایمیل :";
            this.lbl_CompanyEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_CompanyEmail.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_CompanyDesc
            // 
            this.lbl_CompanyDesc.AllowParentOverrides = false;
            this.lbl_CompanyDesc.AutoEllipsis = false;
            this.lbl_CompanyDesc.CursorType = null;
            this.lbl_CompanyDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_CompanyDesc.Location = new System.Drawing.Point(216, 550);
            this.lbl_CompanyDesc.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_CompanyDesc.Name = "lbl_CompanyDesc";
            this.lbl_CompanyDesc.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_CompanyDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CompanyDesc.Size = new System.Drawing.Size(91, 26);
            this.lbl_CompanyDesc.TabIndex = 8;
            this.lbl_CompanyDesc.Text = "معرفی :";
            this.lbl_CompanyDesc.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_CompanyDesc.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Pic_Box
            // 
            this.Pic_Box.AllowFocused = false;
            this.Pic_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pic_Box.AutoSizeHeight = true;
            this.Pic_Box.BorderRadius = 118;
            this.Pic_Box.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Box.Image")));
            this.Pic_Box.IsCircle = true;
            this.Pic_Box.Location = new System.Drawing.Point(55, 20);
            this.Pic_Box.Name = "Pic_Box";
            this.Pic_Box.Size = new System.Drawing.Size(237, 237);
            this.Pic_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Box.TabIndex = 9;
            this.Pic_Box.TabStop = false;
            this.Pic_Box.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCard);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(349, 627);
            this.bunifuCard.ResumeLayout(false);
            this.GradientPanel.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCard;
        private Bunifu.UI.WinForms.BunifuGradientPanel GradientPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Bunifu.UI.WinForms.BunifuLabel lbl_CompanyName;
        private Bunifu.UI.WinForms.BunifuLabel lbl_CompanyPhone;
        private Bunifu.UI.WinForms.BunifuLabel lbl_CompanyAddress;
        private Bunifu.UI.WinForms.BunifuLabel lbl_CompanyEmail;
        private Bunifu.UI.WinForms.BunifuLabel lbl_CompanyDesc;
        private Bunifu.UI.WinForms.BunifuPictureBox Pic_Box;
    }
}
