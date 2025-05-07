namespace CatalogProject.Forms.ShowingForms
{
    partial class CategoriesFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesFrm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PicBoxLogo = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.LbCompanyDescription = new Bunifu.UI.WinForms.BunifuLabel();
            this.LbCompanyEmail = new Bunifu.UI.WinForms.BunifuLabel();
            this.LbCompanyAddress = new Bunifu.UI.WinForms.BunifuLabel();
            this.LbCompanyPhone = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuCards1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.tableLayoutPanel1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(856, 569);
            this.bunifuCards1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LbCompanyDescription, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.LbCompanyEmail, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LbCompanyAddress, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PicBoxLogo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LbCompanyPhone, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.68566F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01965F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(853, 559);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PicBoxLogo
            // 
            this.PicBoxLogo.AllowFocused = false;
            this.PicBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicBoxLogo.AutoSizeHeight = true;
            this.PicBoxLogo.BorderRadius = 93;
            this.PicBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxLogo.Image")));
            this.PicBoxLogo.IsCircle = true;
            this.PicBoxLogo.Location = new System.Drawing.Point(333, 17);
            this.PicBoxLogo.Name = "PicBoxLogo";
            this.PicBoxLogo.Size = new System.Drawing.Size(187, 187);
            this.PicBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxLogo.TabIndex = 1;
            this.PicBoxLogo.TabStop = false;
            this.PicBoxLogo.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // LbCompanyDescription
            // 
            this.LbCompanyDescription.AllowParentOverrides = false;
            this.LbCompanyDescription.AutoEllipsis = false;
            this.LbCompanyDescription.AutoSize = false;
            this.LbCompanyDescription.AutoSizeHeightOnly = true;
            this.LbCompanyDescription.CursorType = null;
            this.LbCompanyDescription.Font = new System.Drawing.Font("A Ghasem", 10.2F);
            this.LbCompanyDescription.Location = new System.Drawing.Point(766, 449);
            this.LbCompanyDescription.Name = "LbCompanyDescription";
            this.LbCompanyDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbCompanyDescription.Size = new System.Drawing.Size(84, 26);
            this.LbCompanyDescription.TabIndex = 1;
            this.LbCompanyDescription.Text = "معرفی :";
            this.LbCompanyDescription.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LbCompanyDescription.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LbCompanyEmail
            // 
            this.LbCompanyEmail.AllowParentOverrides = false;
            this.LbCompanyEmail.AutoEllipsis = false;
            this.LbCompanyEmail.AutoSize = false;
            this.LbCompanyEmail.AutoSizeHeightOnly = true;
            this.LbCompanyEmail.CursorType = null;
            this.LbCompanyEmail.Font = new System.Drawing.Font("A Ghasem", 10.2F);
            this.LbCompanyEmail.Location = new System.Drawing.Point(766, 393);
            this.LbCompanyEmail.Name = "LbCompanyEmail";
            this.LbCompanyEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbCompanyEmail.Size = new System.Drawing.Size(84, 26);
            this.LbCompanyEmail.TabIndex = 1;
            this.LbCompanyEmail.Text = "ایمیل :";
            this.LbCompanyEmail.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LbCompanyEmail.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LbCompanyAddress
            // 
            this.LbCompanyAddress.AllowParentOverrides = false;
            this.LbCompanyAddress.AutoEllipsis = false;
            this.LbCompanyAddress.AutoSize = false;
            this.LbCompanyAddress.AutoSizeHeightOnly = true;
            this.LbCompanyAddress.CursorType = null;
            this.LbCompanyAddress.Font = new System.Drawing.Font("A Ghasem", 10.2F);
            this.LbCompanyAddress.Location = new System.Drawing.Point(766, 337);
            this.LbCompanyAddress.Name = "LbCompanyAddress";
            this.LbCompanyAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbCompanyAddress.Size = new System.Drawing.Size(84, 0);
            this.LbCompanyAddress.TabIndex = 1;
            this.LbCompanyAddress.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LbCompanyAddress.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LbCompanyPhone
            // 
            this.LbCompanyPhone.AllowParentOverrides = false;
            this.LbCompanyPhone.AutoEllipsis = false;
            this.LbCompanyPhone.AutoSize = false;
            this.LbCompanyPhone.AutoSizeHeightOnly = true;
            this.LbCompanyPhone.CursorType = null;
            this.LbCompanyPhone.Font = new System.Drawing.Font("A Ghasem", 10.2F);
            this.LbCompanyPhone.Location = new System.Drawing.Point(766, 281);
            this.LbCompanyPhone.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.LbCompanyPhone.Name = "LbCompanyPhone";
            this.LbCompanyPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbCompanyPhone.Size = new System.Drawing.Size(84, 26);
            this.LbCompanyPhone.TabIndex = 1;
            this.LbCompanyPhone.Text = "تلفن :";
            this.LbCompanyPhone.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LbCompanyPhone.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // CategoriesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 569);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CategoriesFrm";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.CategoriesFrm_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuPictureBox PicBoxLogo;
        private Bunifu.UI.WinForms.BunifuLabel LbCompanyDescription;
        private Bunifu.UI.WinForms.BunifuLabel LbCompanyEmail;
        private Bunifu.UI.WinForms.BunifuLabel LbCompanyAddress;
        private Bunifu.UI.WinForms.BunifuLabel LbCompanyPhone;
    }
}