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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation2 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesFrm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.categoryCard1 = new CatalogProject.Controlls.CategoryCard();
            this.categoryCard2 = new CatalogProject.Controlls.CategoryCard();
            this.categoryCard3 = new CatalogProject.Controlls.CategoryCard();
            this.categoryCard4 = new CatalogProject.Controlls.CategoryCard();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtnPreviosPage = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.BtnNextPage = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.categoryCard1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.categoryCard2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.categoryCard3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.categoryCard4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bunifuButton1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnPreviosPage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnNextPage, 1, 1);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1323, 819);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // categoryCard1
            // 
            this.bunifuTransition1.SetDecoration(this.categoryCard1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.categoryCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryCard1.Location = new System.Drawing.Point(3, 3);
            this.categoryCard1.Name = "categoryCard1";
            this.categoryCard1.Size = new System.Drawing.Size(589, 362);
            this.categoryCard1.TabIndex = 0;
            this.categoryCard1.Tag = "0";
            this.categoryCard1.Click += new System.EventHandler(this.CategoryCart_Click);
            // 
            // categoryCard2
            // 
            this.bunifuTransition1.SetDecoration(this.categoryCard2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.categoryCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryCard2.Location = new System.Drawing.Point(598, 3);
            this.categoryCard2.Name = "categoryCard2";
            this.categoryCard2.Size = new System.Drawing.Size(589, 362);
            this.categoryCard2.TabIndex = 1;
            this.categoryCard2.Tag = "1";
            this.categoryCard2.Click += new System.EventHandler(this.CategoryCart_Click);
            // 
            // categoryCard3
            // 
            this.bunifuTransition1.SetDecoration(this.categoryCard3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.categoryCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryCard3.Location = new System.Drawing.Point(3, 452);
            this.categoryCard3.Name = "categoryCard3";
            this.categoryCard3.Size = new System.Drawing.Size(589, 364);
            this.categoryCard3.TabIndex = 2;
            this.categoryCard3.Tag = "2";
            this.categoryCard3.Click += new System.EventHandler(this.CategoryCart_Click);
            // 
            // categoryCard4
            // 
            this.bunifuTransition1.SetDecoration(this.categoryCard4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.categoryCard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryCard4.Location = new System.Drawing.Point(598, 452);
            this.categoryCard4.Name = "categoryCard4";
            this.categoryCard4.Size = new System.Drawing.Size(589, 364);
            this.categoryCard4.TabIndex = 3;
            this.categoryCard4.Tag = "3";
            this.categoryCard4.Click += new System.EventHandler(this.CategoryCart_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "بازگشت";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges4;
            this.bunifuTransition1.SetDecoration(this.bunifuButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.Empty;
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeft = null;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRight = null;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleBorderRadius = 0;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(1193, 371);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(127, 75);
            this.bunifuButton1.TabIndex = 6;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // BtnPreviosPage
            // 
            this.BtnPreviosPage.AllowAnimations = true;
            this.BtnPreviosPage.AllowMouseEffects = true;
            this.BtnPreviosPage.AllowToggling = false;
            this.BtnPreviosPage.AnimationSpeed = 200;
            this.BtnPreviosPage.AutoGenerateColors = false;
            this.BtnPreviosPage.AutoRoundBorders = false;
            this.BtnPreviosPage.AutoSizeLeftIcon = true;
            this.BtnPreviosPage.AutoSizeRightIcon = true;
            this.BtnPreviosPage.BackColor = System.Drawing.Color.Transparent;
            this.BtnPreviosPage.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.BtnPreviosPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPreviosPage.BackgroundImage")));
            this.BtnPreviosPage.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnPreviosPage.ButtonText = "صفحه قبل";
            this.BtnPreviosPage.ButtonTextMarginLeft = 0;
            this.BtnPreviosPage.ColorContrastOnClick = 45;
            this.BtnPreviosPage.ColorContrastOnHover = 45;
            this.BtnPreviosPage.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.BtnPreviosPage.CustomizableEdges = borderEdges5;
            this.bunifuTransition1.SetDecoration(this.BtnPreviosPage, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.BtnPreviosPage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPreviosPage.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnPreviosPage.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnPreviosPage.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnPreviosPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnPreviosPage.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.BtnPreviosPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnPreviosPage.ForeColor = System.Drawing.Color.White;
            this.BtnPreviosPage.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPreviosPage.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnPreviosPage.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnPreviosPage.IconMarginLeft = 11;
            this.BtnPreviosPage.IconPadding = 10;
            this.BtnPreviosPage.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPreviosPage.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnPreviosPage.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnPreviosPage.IconSize = 25;
            this.BtnPreviosPage.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnPreviosPage.IdleBorderRadius = 1;
            this.BtnPreviosPage.IdleBorderThickness = 1;
            this.BtnPreviosPage.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.BtnPreviosPage.IdleIconLeftImage = null;
            this.BtnPreviosPage.IdleIconRightImage = null;
            this.BtnPreviosPage.IndicateFocus = false;
            this.BtnPreviosPage.Location = new System.Drawing.Point(442, 371);
            this.BtnPreviosPage.Name = "BtnPreviosPage";
            this.BtnPreviosPage.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnPreviosPage.OnDisabledState.BorderRadius = 1;
            this.BtnPreviosPage.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnPreviosPage.OnDisabledState.BorderThickness = 1;
            this.BtnPreviosPage.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnPreviosPage.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnPreviosPage.OnDisabledState.IconLeftImage = null;
            this.BtnPreviosPage.OnDisabledState.IconRightImage = null;
            this.BtnPreviosPage.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnPreviosPage.onHoverState.BorderRadius = 1;
            this.BtnPreviosPage.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnPreviosPage.onHoverState.BorderThickness = 1;
            this.BtnPreviosPage.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnPreviosPage.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnPreviosPage.onHoverState.IconLeftImage = null;
            this.BtnPreviosPage.onHoverState.IconRightImage = null;
            this.BtnPreviosPage.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnPreviosPage.OnIdleState.BorderRadius = 1;
            this.BtnPreviosPage.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnPreviosPage.OnIdleState.BorderThickness = 1;
            this.BtnPreviosPage.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.BtnPreviosPage.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnPreviosPage.OnIdleState.IconLeftImage = null;
            this.BtnPreviosPage.OnIdleState.IconRightImage = null;
            this.BtnPreviosPage.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnPreviosPage.OnPressedState.BorderRadius = 1;
            this.BtnPreviosPage.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnPreviosPage.OnPressedState.BorderThickness = 1;
            this.BtnPreviosPage.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnPreviosPage.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnPreviosPage.OnPressedState.IconLeftImage = null;
            this.BtnPreviosPage.OnPressedState.IconRightImage = null;
            this.BtnPreviosPage.Size = new System.Drawing.Size(150, 75);
            this.BtnPreviosPage.TabIndex = 7;
            this.BtnPreviosPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnPreviosPage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnPreviosPage.TextMarginLeft = 0;
            this.BtnPreviosPage.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnPreviosPage.UseDefaultRadiusAndThickness = true;
            this.BtnPreviosPage.Click += new System.EventHandler(this.BtnPreviosPage_Click);
            // 
            // BtnNextPage
            // 
            this.BtnNextPage.AllowAnimations = true;
            this.BtnNextPage.AllowMouseEffects = true;
            this.BtnNextPage.AllowToggling = false;
            this.BtnNextPage.AnimationSpeed = 200;
            this.BtnNextPage.AutoGenerateColors = false;
            this.BtnNextPage.AutoRoundBorders = false;
            this.BtnNextPage.AutoSizeLeftIcon = true;
            this.BtnNextPage.AutoSizeRightIcon = true;
            this.BtnNextPage.BackColor = System.Drawing.Color.Transparent;
            this.BtnNextPage.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.BtnNextPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNextPage.BackgroundImage")));
            this.BtnNextPage.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnNextPage.ButtonText = "صفحه بعد";
            this.BtnNextPage.ButtonTextMarginLeft = 0;
            this.BtnNextPage.ColorContrastOnClick = 45;
            this.BtnNextPage.ColorContrastOnHover = 45;
            this.BtnNextPage.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.BtnNextPage.CustomizableEdges = borderEdges6;
            this.bunifuTransition1.SetDecoration(this.BtnNextPage, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.BtnNextPage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnNextPage.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnNextPage.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnNextPage.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnNextPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnNextPage.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.BtnNextPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnNextPage.ForeColor = System.Drawing.Color.White;
            this.BtnNextPage.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNextPage.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnNextPage.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnNextPage.IconMarginLeft = 11;
            this.BtnNextPage.IconPadding = 10;
            this.BtnNextPage.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNextPage.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnNextPage.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnNextPage.IconSize = 25;
            this.BtnNextPage.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnNextPage.IdleBorderRadius = 1;
            this.BtnNextPage.IdleBorderThickness = 1;
            this.BtnNextPage.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.BtnNextPage.IdleIconLeftImage = null;
            this.BtnNextPage.IdleIconRightImage = null;
            this.BtnNextPage.IndicateFocus = false;
            this.BtnNextPage.Location = new System.Drawing.Point(598, 371);
            this.BtnNextPage.Name = "BtnNextPage";
            this.BtnNextPage.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnNextPage.OnDisabledState.BorderRadius = 1;
            this.BtnNextPage.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnNextPage.OnDisabledState.BorderThickness = 1;
            this.BtnNextPage.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnNextPage.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnNextPage.OnDisabledState.IconLeftImage = null;
            this.BtnNextPage.OnDisabledState.IconRightImage = null;
            this.BtnNextPage.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnNextPage.onHoverState.BorderRadius = 1;
            this.BtnNextPage.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnNextPage.onHoverState.BorderThickness = 1;
            this.BtnNextPage.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnNextPage.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnNextPage.onHoverState.IconLeftImage = null;
            this.BtnNextPage.onHoverState.IconRightImage = null;
            this.BtnNextPage.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnNextPage.OnIdleState.BorderRadius = 1;
            this.BtnNextPage.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnNextPage.OnIdleState.BorderThickness = 1;
            this.BtnNextPage.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.BtnNextPage.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnNextPage.OnIdleState.IconLeftImage = null;
            this.BtnNextPage.OnIdleState.IconRightImage = null;
            this.BtnNextPage.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnNextPage.OnPressedState.BorderRadius = 1;
            this.BtnNextPage.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnNextPage.OnPressedState.BorderThickness = 1;
            this.BtnNextPage.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnNextPage.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnNextPage.OnPressedState.IconLeftImage = null;
            this.BtnNextPage.OnPressedState.IconRightImage = null;
            this.BtnNextPage.Size = new System.Drawing.Size(150, 75);
            this.BtnNextPage.TabIndex = 7;
            this.BtnNextPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnNextPage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnNextPage.TextMarginLeft = 0;
            this.BtnNextPage.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnNextPage.UseDefaultRadiusAndThickness = true;
            this.BtnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // CategoriesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 819);
            this.Controls.Add(this.tableLayoutPanel1);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoriesFrm";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.CategoriesFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controlls.CategoryCard categoryCard1;
        private Controlls.CategoryCard categoryCard2;
        private Controlls.CategoryCard categoryCard3;
        private Controlls.CategoryCard categoryCard4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 BtnPreviosPage;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 BtnNextPage;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
    }
}