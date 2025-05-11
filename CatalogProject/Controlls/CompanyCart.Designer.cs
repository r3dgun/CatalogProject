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
            this.BunifuCard = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuGradientPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_CompanyName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_CompanyPhone = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_CompanyAddress = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_CompanyEmail = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_CompanyDesc = new Bunifu.UI.WinForms.BunifuLabel();
            this.Pic_Box = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.BunifuCard.SuspendLayout();
            this.bunifuGradientPanel.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // BunifuCard
            // 
            this.BunifuCard.BackColor = System.Drawing.Color.Transparent;
            this.BunifuCard.BorderRadius = 25;
            this.BunifuCard.BottomSahddow = true;
            this.BunifuCard.color = System.Drawing.Color.Tomato;
            this.BunifuCard.Controls.Add(this.bunifuGradientPanel);
            this.BunifuCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BunifuCard.LeftSahddow = false;
            this.BunifuCard.Location = new System.Drawing.Point(0, 0);
            this.BunifuCard.Name = "BunifuCard";
            this.BunifuCard.RightSahddow = true;
            this.BunifuCard.ShadowDepth = 20;
            this.BunifuCard.Size = new System.Drawing.Size(533, 472);
            this.BunifuCard.TabIndex = 0;
            // 
            // bunifuGradientPanel
            // 
            this.bunifuGradientPanel.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel.BackgroundImage")));
            this.bunifuGradientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel.BorderRadius = 0;
            this.bunifuGradientPanel.Controls.Add(this.tableLayoutPanel);
            this.bunifuGradientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(92)))), ((int)(((byte)(188)))));
            this.bunifuGradientPanel.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(60)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel.Name = "bunifuGradientPanel";
            this.bunifuGradientPanel.Quality = 10;
            this.bunifuGradientPanel.Size = new System.Drawing.Size(533, 472);
            this.bunifuGradientPanel.TabIndex = 10;
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
            this.tableLayoutPanel.Size = new System.Drawing.Size(533, 472);
            this.tableLayoutPanel.TabIndex = 18;
            this.tableLayoutPanel.Click += new System.EventHandler(this.tableLayoutPanel_Click);
            // 
            // lbl_CompanyName
            // 
            this.lbl_CompanyName.AllowParentOverrides = false;
            this.lbl_CompanyName.AutoEllipsis = false;
            this.lbl_CompanyName.CursorType = null;
            this.lbl_CompanyName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_CompanyName.Location = new System.Drawing.Point(386, 213);
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
            this.lbl_CompanyPhone.Location = new System.Drawing.Point(418, 264);
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
            this.lbl_CompanyAddress.Location = new System.Drawing.Point(411, 315);
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
            this.lbl_CompanyEmail.Location = new System.Drawing.Point(413, 366);
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
            this.lbl_CompanyDesc.Location = new System.Drawing.Point(402, 417);
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
            this.Pic_Box.BorderRadius = 100;
            this.Pic_Box.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Box.Image")));
            this.Pic_Box.IsCircle = true;
            this.Pic_Box.Location = new System.Drawing.Point(166, 6);
            this.Pic_Box.Name = "Pic_Box";
            this.Pic_Box.Size = new System.Drawing.Size(201, 201);
            this.Pic_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Box.TabIndex = 9;
            this.Pic_Box.TabStop = false;
            this.Pic_Box.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // CompanyCart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.BunifuCard);
            this.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "CompanyCart";
            this.Size = new System.Drawing.Size(533, 472);
            this.BunifuCard.ResumeLayout(false);
            this.bunifuGradientPanel.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards BunifuCard;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Bunifu.UI.WinForms.BunifuLabel lbl_CompanyName;
        private Bunifu.UI.WinForms.BunifuLabel lbl_CompanyPhone;
        private Bunifu.UI.WinForms.BunifuLabel lbl_CompanyAddress;
        private Bunifu.UI.WinForms.BunifuLabel lbl_CompanyEmail;
        private Bunifu.UI.WinForms.BunifuLabel lbl_CompanyDesc;
        private Bunifu.UI.WinForms.BunifuPictureBox Pic_Box;
    }
}
