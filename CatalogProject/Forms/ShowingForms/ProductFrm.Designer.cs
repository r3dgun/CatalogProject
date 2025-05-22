namespace CatalogProject.Forms.ShowingForms
{
    partial class ProductFrm
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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductFrm));
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.tableLayer = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCard_Image = new Bunifu.Framework.UI.BunifuCards();
            this.picBox_product = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuCards_Detail = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards_Options = new Bunifu.Framework.UI.BunifuCards();
            this.picBox_Catalug = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuPictureBox3 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.productDetail = new CatalogProject.Controlls.ProductDetail();
            this.productOptions = new CatalogProject.Controlls.ProductOptions();
            this.bunifuGradientPanel1.SuspendLayout();
            this.tableLayer.SuspendLayout();
            this.bunifuCard_Image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_product)).BeginInit();
            this.bunifuCards_Detail.SuspendLayout();
            this.bunifuCards_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Catalug)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.tableLayer);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(92)))), ((int)(((byte)(188)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(60)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1444, 753);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // tableLayer
            // 
            this.tableLayer.ColumnCount = 3;
            this.tableLayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.12966F));
            this.tableLayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.92362F));
            this.tableLayer.Controls.Add(this.bunifuCard_Image, 1, 0);
            this.tableLayer.Controls.Add(this.bunifuCards_Detail, 0, 0);
            this.tableLayer.Controls.Add(this.bunifuCards_Options, 0, 1);
            this.tableLayer.Controls.Add(this.tableLayoutPanel1, 2, 0);
            this.tableLayer.Controls.Add(this.picBox_Catalug, 1, 1);
            this.bunifuTransition1.SetDecoration(this.tableLayer, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tableLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayer.Location = new System.Drawing.Point(0, 0);
            this.tableLayer.Name = "tableLayer";
            this.tableLayer.RowCount = 2;
            this.tableLayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.4158F));
            this.tableLayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.5842F));
            this.tableLayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayer.Size = new System.Drawing.Size(1444, 753);
            this.tableLayer.TabIndex = 4;
            // 
            // bunifuCard_Image
            // 
            this.bunifuCard_Image.BackColor = System.Drawing.Color.White;
            this.bunifuCard_Image.BorderRadius = 5;
            this.bunifuCard_Image.BottomSahddow = false;
            this.bunifuCard_Image.color = System.Drawing.Color.Transparent;
            this.bunifuCard_Image.Controls.Add(this.picBox_product);
            this.bunifuTransition1.SetDecoration(this.bunifuCard_Image, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCard_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCard_Image.LeftSahddow = false;
            this.bunifuCard_Image.Location = new System.Drawing.Point(184, 10);
            this.bunifuCard_Image.Margin = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.bunifuCard_Image.Name = "bunifuCard_Image";
            this.bunifuCard_Image.RightSahddow = false;
            this.bunifuCard_Image.ShadowDepth = 20;
            this.bunifuCard_Image.Size = new System.Drawing.Size(370, 367);
            this.bunifuCard_Image.TabIndex = 25;
            // 
            // picBox_product
            // 
            this.picBox_product.AllowFocused = false;
            this.picBox_product.AutoSizeHeight = false;
            this.picBox_product.BorderRadius = 185;
            this.bunifuTransition1.SetDecoration(this.picBox_product, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.picBox_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox_product.Image = ((System.Drawing.Image)(resources.GetObject("picBox_product.Image")));
            this.picBox_product.IsCircle = true;
            this.picBox_product.Location = new System.Drawing.Point(0, 0);
            this.picBox_product.Margin = new System.Windows.Forms.Padding(15);
            this.picBox_product.Name = "picBox_product";
            this.picBox_product.Size = new System.Drawing.Size(370, 367);
            this.picBox_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_product.TabIndex = 24;
            this.picBox_product.TabStop = false;
            this.picBox_product.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuCards_Detail
            // 
            this.bunifuCards_Detail.BackColor = System.Drawing.Color.White;
            this.bunifuCards_Detail.BorderRadius = 5;
            this.bunifuCards_Detail.BottomSahddow = false;
            this.bunifuCards_Detail.color = System.Drawing.Color.Tomato;
            this.bunifuCards_Detail.Controls.Add(this.productDetail);
            this.bunifuTransition1.SetDecoration(this.bunifuCards_Detail, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCards_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards_Detail.LeftSahddow = false;
            this.bunifuCards_Detail.Location = new System.Drawing.Point(582, 3);
            this.bunifuCards_Detail.Name = "bunifuCards_Detail";
            this.bunifuCards_Detail.RightSahddow = false;
            this.bunifuCards_Detail.ShadowDepth = 20;
            this.bunifuCards_Detail.Size = new System.Drawing.Size(859, 381);
            this.bunifuCards_Detail.TabIndex = 26;
            // 
            // bunifuCards_Options
            // 
            this.bunifuCards_Options.BackColor = System.Drawing.Color.White;
            this.bunifuCards_Options.BorderRadius = 5;
            this.bunifuCards_Options.BottomSahddow = false;
            this.bunifuCards_Options.color = System.Drawing.Color.Tomato;
            this.bunifuCards_Options.Controls.Add(this.productOptions);
            this.bunifuTransition1.SetDecoration(this.bunifuCards_Options, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCards_Options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards_Options.LeftSahddow = false;
            this.bunifuCards_Options.Location = new System.Drawing.Point(582, 390);
            this.bunifuCards_Options.Name = "bunifuCards_Options";
            this.bunifuCards_Options.RightSahddow = false;
            this.bunifuCards_Options.ShadowDepth = 20;
            this.bunifuCards_Options.Size = new System.Drawing.Size(859, 360);
            this.bunifuCards_Options.TabIndex = 27;
            // 
            // picBox_Catalug
            // 
            this.picBox_Catalug.AllowFocused = false;
            this.picBox_Catalug.AutoSizeHeight = true;
            this.picBox_Catalug.BorderRadius = 180;
            this.bunifuTransition1.SetDecoration(this.picBox_Catalug, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.picBox_Catalug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox_Catalug.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Catalug.Image")));
            this.picBox_Catalug.IsCircle = true;
            this.picBox_Catalug.Location = new System.Drawing.Point(189, 417);
            this.picBox_Catalug.Margin = new System.Windows.Forms.Padding(30);
            this.picBox_Catalug.Name = "picBox_Catalug";
            this.picBox_Catalug.Size = new System.Drawing.Size(360, 360);
            this.picBox_Catalug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Catalug.TabIndex = 24;
            this.picBox_Catalug.TabStop = false;
            this.picBox_Catalug.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.bunifuPictureBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bunifuPictureBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bunifuPictureBox1, 0, 0);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(153, 381);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // bunifuPictureBox3
            // 
            this.bunifuPictureBox3.AllowFocused = false;
            this.bunifuPictureBox3.AutoSizeHeight = true;
            this.bunifuPictureBox3.BorderRadius = 51;
            this.bunifuTransition1.SetDecoration(this.bunifuPictureBox3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox3.Image")));
            this.bunifuPictureBox3.IsCircle = true;
            this.bunifuPictureBox3.Location = new System.Drawing.Point(25, 275);
            this.bunifuPictureBox3.Margin = new System.Windows.Forms.Padding(25);
            this.bunifuPictureBox3.Name = "bunifuPictureBox3";
            this.bunifuPictureBox3.Size = new System.Drawing.Size(103, 103);
            this.bunifuPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox3.TabIndex = 0;
            this.bunifuPictureBox3.TabStop = false;
            this.bunifuPictureBox3.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.AutoSizeHeight = true;
            this.bunifuPictureBox2.BorderRadius = 51;
            this.bunifuTransition1.SetDecoration(this.bunifuPictureBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox2.Image")));
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(25, 150);
            this.bunifuPictureBox2.Margin = new System.Windows.Forms.Padding(25);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(103, 103);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 0;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 51;
            this.bunifuTransition1.SetDecoration(this.bunifuPictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(25, 25);
            this.bunifuPictureBox1.Margin = new System.Windows.Forms.Padding(25);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(103, 103);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // productDetail
            // 
            this.productDetail.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.productDetail, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.productDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productDetail.Location = new System.Drawing.Point(0, 0);
            this.productDetail.Margin = new System.Windows.Forms.Padding(15);
            this.productDetail.Name = "productDetail";
            this.productDetail.Padding = new System.Windows.Forms.Padding(20);
            this.productDetail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productDetail.Size = new System.Drawing.Size(859, 381);
            this.productDetail.TabIndex = 1;
            // 
            // productOptions
            // 
            this.productOptions.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.productOptions, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.productOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productOptions.ForeColor = System.Drawing.Color.Black;
            this.productOptions.Location = new System.Drawing.Point(0, 0);
            this.productOptions.Margin = new System.Windows.Forms.Padding(15);
            this.productOptions.Name = "productOptions";
            this.productOptions.Padding = new System.Windows.Forms.Padding(20);
            this.productOptions.Size = new System.Drawing.Size(859, 360);
            this.productOptions.TabIndex = 1;
            // 
            // ProductFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1444, 753);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Name = "ProductFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "product";
            this.Load += new System.EventHandler(this.ProductFrm_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.tableLayer.ResumeLayout(false);
            this.bunifuCard_Image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_product)).EndInit();
            this.bunifuCards_Detail.ResumeLayout(false);
            this.bunifuCards_Options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Catalug)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayer;
        private Bunifu.UI.WinForms.BunifuPictureBox picBox_Catalug;
        private Bunifu.Framework.UI.BunifuCards bunifuCard_Image;
        private Bunifu.UI.WinForms.BunifuPictureBox picBox_product;
        private Bunifu.Framework.UI.BunifuCards bunifuCards_Detail;
        private Controlls.ProductDetail productDetail;
        private Bunifu.Framework.UI.BunifuCards bunifuCards_Options;
        private Controlls.ProductOptions productOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox3;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}