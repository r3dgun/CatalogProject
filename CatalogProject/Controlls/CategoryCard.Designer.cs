namespace CatalogProject.Controlls
{
    partial class CategoryCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryCard));
            this.bunifuCard = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuGradientPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_CategoryName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_CategoryDisc = new Bunifu.UI.WinForms.BunifuLabel();
            this.Pic_Box = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuCard.SuspendLayout();
            this.bunifuGradientPanel.SuspendLayout();
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
            this.bunifuCard.Controls.Add(this.bunifuGradientPanel);
            this.bunifuCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCard.LeftSahddow = false;
            this.bunifuCard.Location = new System.Drawing.Point(0, 0);
            this.bunifuCard.Name = "bunifuCard";
            this.bunifuCard.RightSahddow = true;
            this.bunifuCard.ShadowDepth = 20;
            this.bunifuCard.Size = new System.Drawing.Size(667, 496);
            this.bunifuCard.TabIndex = 0;
            // 
            // bunifuGradientPanel
            // 
            this.bunifuGradientPanel.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel.BackgroundImage")));
            this.bunifuGradientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel.BorderRadius = 1;
            this.bunifuGradientPanel.Controls.Add(this.tableLayoutPanel);
            this.bunifuGradientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(92)))), ((int)(((byte)(188)))));
            this.bunifuGradientPanel.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(60)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel.Name = "bunifuGradientPanel";
            this.bunifuGradientPanel.Quality = 10;
            this.bunifuGradientPanel.Size = new System.Drawing.Size(667, 496);
            this.bunifuGradientPanel.TabIndex = 1;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.lbl_CategoryName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lbl_CategoryDisc, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.Pic_Box, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.tableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(667, 496);
            this.tableLayoutPanel.TabIndex = 19;
            // 
            // lbl_CategoryName
            // 
            this.lbl_CategoryName.AllowParentOverrides = false;
            this.lbl_CategoryName.AutoEllipsis = false;
            this.lbl_CategoryName.CursorType = null;
            this.lbl_CategoryName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_CategoryName.Location = new System.Drawing.Point(524, 332);
            this.lbl_CategoryName.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_CategoryName.Name = "lbl_CategoryName";
            this.lbl_CategoryName.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_CategoryName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CategoryName.Size = new System.Drawing.Size(103, 26);
            this.lbl_CategoryName.TabIndex = 4;
            this.lbl_CategoryName.Text = "نام دسته :";
            this.lbl_CategoryName.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_CategoryName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_CategoryDisc
            // 
            this.lbl_CategoryDisc.AllowParentOverrides = false;
            this.lbl_CategoryDisc.AutoEllipsis = false;
            this.lbl_CategoryDisc.CursorType = null;
            this.lbl_CategoryDisc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_CategoryDisc.Location = new System.Drawing.Point(520, 413);
            this.lbl_CategoryDisc.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_CategoryDisc.Name = "lbl_CategoryDisc";
            this.lbl_CategoryDisc.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lbl_CategoryDisc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_CategoryDisc.Size = new System.Drawing.Size(107, 26);
            this.lbl_CategoryDisc.TabIndex = 5;
            this.lbl_CategoryDisc.Text = "توضیحات :";
            this.lbl_CategoryDisc.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_CategoryDisc.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Pic_Box
            // 
            this.Pic_Box.AllowFocused = false;
            this.Pic_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pic_Box.AutoSizeHeight = true;
            this.Pic_Box.BorderRadius = 100;
            this.Pic_Box.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Box.Image")));
            this.Pic_Box.IsCircle = true;
            this.Pic_Box.Location = new System.Drawing.Point(233, 65);
            this.Pic_Box.Name = "Pic_Box";
            this.Pic_Box.Size = new System.Drawing.Size(201, 201);
            this.Pic_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Box.TabIndex = 9;
            this.Pic_Box.TabStop = false;
            this.Pic_Box.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // CategoryCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCard);
            this.Name = "CategoryCard";
            this.Size = new System.Drawing.Size(667, 496);
            this.bunifuCard.ResumeLayout(false);
            this.bunifuGradientPanel.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCard;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Bunifu.UI.WinForms.BunifuLabel lbl_CategoryName;
        private Bunifu.UI.WinForms.BunifuLabel lbl_CategoryDisc;
        private Bunifu.UI.WinForms.BunifuPictureBox Pic_Box;
    }
}
