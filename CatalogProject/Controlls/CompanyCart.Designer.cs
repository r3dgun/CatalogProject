namespace CatalogProject.Controlls
{
    partial class CompanyCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyCart));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.PicBoxLogo = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LbCompanyPhone = new Bunifu.UI.WinForms.BunifuLabel();
            this.LbCompanyAddress = new Bunifu.UI.WinForms.BunifuLabel();
            this.LbCompanyEmail = new Bunifu.UI.WinForms.BunifuLabel();
            this.LbCompanyDescription = new Bunifu.UI.WinForms.BunifuLabel();
            this.LbCompanyName = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuCards1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.bunifuPanel1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(151, 97);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(541, 412);
            this.bunifuCards1.TabIndex = 0;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.tableLayoutPanel1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Font = new System.Drawing.Font("A Ghasem", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(20);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(541, 412);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // PicBoxLogo
            // 
            this.PicBoxLogo.AllowFocused = false;
            this.PicBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicBoxLogo.AutoSizeHeight = true;
            this.PicBoxLogo.BorderRadius = 93;
            this.PicBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxLogo.Image")));
            this.PicBoxLogo.IsCircle = true;
            this.PicBoxLogo.Location = new System.Drawing.Point(177, 3);
            this.PicBoxLogo.Name = "PicBoxLogo";
            this.PicBoxLogo.Size = new System.Drawing.Size(187, 187);
            this.PicBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxLogo.TabIndex = 1;
            this.PicBoxLogo.TabStop = false;
            this.PicBoxLogo.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LbCompanyName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LbCompanyDescription, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.LbCompanyEmail, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LbCompanyAddress, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PicBoxLogo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LbCompanyPhone, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(541, 412);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LbCompanyPhone
            // 
            this.LbCompanyPhone.AllowParentOverrides = false;
            this.LbCompanyPhone.AutoEllipsis = false;
            this.LbCompanyPhone.AutoSize = false;
            this.LbCompanyPhone.AutoSizeHeightOnly = true;
            this.LbCompanyPhone.CursorType = null;
            this.LbCompanyPhone.Font = new System.Drawing.Font("A Ghasem", 10.2F);
            this.LbCompanyPhone.Location = new System.Drawing.Point(454, 207);
            this.LbCompanyPhone.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.LbCompanyPhone.Name = "LbCompanyPhone";
            this.LbCompanyPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbCompanyPhone.Size = new System.Drawing.Size(84, 26);
            this.LbCompanyPhone.TabIndex = 1;
            this.LbCompanyPhone.Text = "تلفن :";
            this.LbCompanyPhone.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LbCompanyPhone.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LbCompanyAddress
            // 
            this.LbCompanyAddress.AllowParentOverrides = false;
            this.LbCompanyAddress.AutoEllipsis = false;
            this.LbCompanyAddress.AutoSize = false;
            this.LbCompanyAddress.AutoSizeHeightOnly = true;
            this.LbCompanyAddress.CursorType = null;
            this.LbCompanyAddress.Font = new System.Drawing.Font("A Ghasem", 10.2F);
            this.LbCompanyAddress.Location = new System.Drawing.Point(454, 248);
            this.LbCompanyAddress.Name = "LbCompanyAddress";
            this.LbCompanyAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbCompanyAddress.Size = new System.Drawing.Size(84, 26);
            this.LbCompanyAddress.TabIndex = 1;
            this.LbCompanyAddress.Text = "آدرس :";
            this.LbCompanyAddress.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LbCompanyAddress.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LbCompanyEmail
            // 
            this.LbCompanyEmail.AllowParentOverrides = false;
            this.LbCompanyEmail.AutoEllipsis = false;
            this.LbCompanyEmail.AutoSize = false;
            this.LbCompanyEmail.AutoSizeHeightOnly = true;
            this.LbCompanyEmail.CursorType = null;
            this.LbCompanyEmail.Font = new System.Drawing.Font("A Ghasem", 10.2F);
            this.LbCompanyEmail.Location = new System.Drawing.Point(454, 289);
            this.LbCompanyEmail.Name = "LbCompanyEmail";
            this.LbCompanyEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbCompanyEmail.Size = new System.Drawing.Size(84, 26);
            this.LbCompanyEmail.TabIndex = 1;
            this.LbCompanyEmail.Text = "ایمیل :";
            this.LbCompanyEmail.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LbCompanyEmail.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LbCompanyDescription
            // 
            this.LbCompanyDescription.AllowParentOverrides = false;
            this.LbCompanyDescription.AutoEllipsis = false;
            this.LbCompanyDescription.AutoSize = false;
            this.LbCompanyDescription.AutoSizeHeightOnly = true;
            this.LbCompanyDescription.CursorType = null;
            this.LbCompanyDescription.Font = new System.Drawing.Font("A Ghasem", 10.2F);
            this.LbCompanyDescription.Location = new System.Drawing.Point(454, 330);
            this.LbCompanyDescription.Name = "LbCompanyDescription";
            this.LbCompanyDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbCompanyDescription.Size = new System.Drawing.Size(84, 26);
            this.LbCompanyDescription.TabIndex = 1;
            this.LbCompanyDescription.Text = "معرفی :";
            this.LbCompanyDescription.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LbCompanyDescription.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LbCompanyName
            // 
            this.LbCompanyName.AllowParentOverrides = false;
            this.LbCompanyName.AutoEllipsis = true;
            this.LbCompanyName.AutoSize = false;
            this.LbCompanyName.AutoSizeHeightOnly = true;
            this.LbCompanyName.CursorType = null;
            this.LbCompanyName.Font = new System.Drawing.Font("A Ghasem", 10.2F);
            this.LbCompanyName.Location = new System.Drawing.Point(454, 166);
            this.LbCompanyName.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.LbCompanyName.Name = "LbCompanyName";
            this.LbCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbCompanyName.Size = new System.Drawing.Size(84, 26);
            this.LbCompanyName.TabIndex = 2;
            this.LbCompanyName.Text = "نام شرکت :";
            this.LbCompanyName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbCompanyName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // CompanyCart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "CompanyCart";
            this.Size = new System.Drawing.Size(692, 509);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuLabel LbCompanyName;
        private Bunifu.UI.WinForms.BunifuLabel LbCompanyDescription;
        private Bunifu.UI.WinForms.BunifuLabel LbCompanyEmail;
        private Bunifu.UI.WinForms.BunifuLabel LbCompanyAddress;
        private Bunifu.UI.WinForms.BunifuPictureBox PicBoxLogo;
        private Bunifu.UI.WinForms.BunifuLabel LbCompanyPhone;
    }
}
