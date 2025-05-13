namespace CatalogProject.Forms.ShowingForms
{
    partial class CompaniesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompaniesFrm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation2 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.LbCompanyPhone = new Bunifu.UI.WinForms.BunifuLabel();
            this.LbCompanyAddress = new Bunifu.UI.WinForms.BunifuLabel();
            this.LbCompanyEmail = new Bunifu.UI.WinForms.BunifuLabel();
            this.LbCompanyDescription = new Bunifu.UI.WinForms.BunifuLabel();
            this.LbCompanyName = new Bunifu.UI.WinForms.BunifuLabel();
            this.MainPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PageChanger = new Bunifu.UI.WinForms.BunifuVSlider();
            this.btn_Exit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.companyCart1 = new CatalogProject.Controlls.CompanyCart();
            this.companyCart2 = new CatalogProject.Controlls.CompanyCart();
            this.companyCart3 = new CatalogProject.Controlls.CompanyCart();
            this.companyCart4 = new CatalogProject.Controlls.CompanyCart();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.MainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbCompanyPhone
            // 
            this.LbCompanyPhone.AllowParentOverrides = false;
            this.LbCompanyPhone.AutoEllipsis = false;
            this.LbCompanyPhone.AutoSize = false;
            this.LbCompanyPhone.AutoSizeHeightOnly = true;
            this.LbCompanyPhone.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.LbCompanyPhone, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LbCompanyPhone.Font = new System.Drawing.Font("A Ghasem", 10.2F);
            this.LbCompanyPhone.Location = new System.Drawing.Point(424, 185);
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
            this.bunifuTransition1.SetDecoration(this.LbCompanyAddress, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LbCompanyAddress.Font = new System.Drawing.Font("A Ghasem", 10.2F);
            this.LbCompanyAddress.Location = new System.Drawing.Point(424, 221);
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
            this.bunifuTransition1.SetDecoration(this.LbCompanyEmail, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LbCompanyEmail.Font = new System.Drawing.Font("A Ghasem", 10.2F);
            this.LbCompanyEmail.Location = new System.Drawing.Point(424, 257);
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
            this.bunifuTransition1.SetDecoration(this.LbCompanyDescription, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LbCompanyDescription.Font = new System.Drawing.Font("A Ghasem", 10.2F);
            this.LbCompanyDescription.Location = new System.Drawing.Point(424, 293);
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
            this.bunifuTransition1.SetDecoration(this.LbCompanyName, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LbCompanyName.Font = new System.Drawing.Font("A Ghasem", 10.2F);
            this.LbCompanyName.Location = new System.Drawing.Point(424, 149);
            this.LbCompanyName.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.LbCompanyName.Name = "LbCompanyName";
            this.LbCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbCompanyName.Size = new System.Drawing.Size(84, 26);
            this.LbCompanyName.TabIndex = 2;
            this.LbCompanyName.Text = "نام شرکت :";
            this.LbCompanyName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbCompanyName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.BorderColor = System.Drawing.Color.Transparent;
            this.MainPanel.BorderRadius = 3;
            this.MainPanel.BorderThickness = 1;
            this.MainPanel.Controls.Add(this.tableLayoutPanel1);
            this.bunifuTransition1.SetDecoration(this.MainPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.ShowBorders = true;
            this.MainPanel.Size = new System.Drawing.Size(1342, 773);
            this.MainPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.PageChanger, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Exit, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.companyCart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.companyCart2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.companyCart3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.companyCart4, 1, 1);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1342, 773);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // PageChanger
            // 
            this.PageChanger.AllowCursorChanges = true;
            this.PageChanger.AllowHomeEndKeysDetection = false;
            this.PageChanger.AllowIncrementalClickMoves = true;
            this.PageChanger.AllowMouseDownEffects = false;
            this.PageChanger.AllowMouseHoverEffects = false;
            this.PageChanger.AllowScrollingAnimations = true;
            this.PageChanger.AllowScrollKeysDetection = true;
            this.PageChanger.AllowScrollOptionsMenu = true;
            this.PageChanger.AllowShrinkingOnFocusLost = false;
            this.PageChanger.BackColor = System.Drawing.Color.Transparent;
            this.PageChanger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PageChanger.BackgroundImage")));
            this.PageChanger.BindingContainer = null;
            this.PageChanger.BorderRadius = 2;
            this.PageChanger.BorderThickness = 1;
            this.PageChanger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.PageChanger, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PageChanger.DirectionalScroll = Utilities.BunifuSlider.BunifuVScrollBar.DirectionalMovements.BottomUp;
            this.PageChanger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageChanger.DrawThickBorder = false;
            this.PageChanger.DurationBeforeShrink = 2000;
            this.PageChanger.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.PageChanger.LargeChange = 1;
            this.PageChanger.Location = new System.Drawing.Point(1211, 50);
            this.PageChanger.Margin = new System.Windows.Forms.Padding(5, 50, 5, 50);
            this.PageChanger.Maximum = 4;
            this.PageChanger.Minimum = 1;
            this.PageChanger.MinimumSize = new System.Drawing.Size(4, 0);
            this.PageChanger.MinimumThumbLength = 18;
            this.PageChanger.Name = "PageChanger";
            this.PageChanger.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.PageChanger.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.PageChanger.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.PageChanger.OnDisableSlider.ElapsedColor = System.Drawing.Color.Silver;
            this.PageChanger.OnDisableSlider.SliderColor = System.Drawing.Color.Gainsboro;
            this.PageChanger.OnDisableSlider.ThumbColor = System.Drawing.Color.Silver;
            this.PageChanger.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.PageChanger.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.PageChanger.ShrinkSizeLimit = 3;
            this.PageChanger.Size = new System.Drawing.Size(126, 286);
            this.PageChanger.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.PageChanger.SliderStyle = Bunifu.UI.WinForms.BunifuVSlider.SliderStyles.Thin;
            this.PageChanger.SliderThumbStyle = Utilities.BunifuSlider.BunifuVScrollBar.SliderThumbStyles.Circular;
            this.PageChanger.SmallChange = 1;
            this.PageChanger.TabIndex = 1;
            this.PageChanger.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.PageChanger.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.PageChanger.ThumbLength = 71;
            this.PageChanger.ThumbMargin = 1;
            this.PageChanger.ThumbSize = Bunifu.UI.WinForms.BunifuVSlider.ThumbSizes.Large;
            this.PageChanger.ThumbStyle = Bunifu.UI.WinForms.BunifuVSlider.ThumbStyles.Outline;
            this.PageChanger.Value = 1;
            this.PageChanger.ValueChanged += new System.EventHandler<Utilities.BunifuSlider.BunifuVScrollBar.ValueChangedEventArgs>(this.PageChanger_ValueChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.AllowAnimations = true;
            this.btn_Exit.AllowMouseEffects = true;
            this.btn_Exit.AllowToggling = false;
            this.btn_Exit.AnimationSpeed = 200;
            this.btn_Exit.AutoGenerateColors = false;
            this.btn_Exit.AutoRoundBorders = false;
            this.btn_Exit.AutoSizeLeftIcon = true;
            this.btn_Exit.AutoSizeRightIcon = true;
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Exit.ButtonText = "بازگشت";
            this.btn_Exit.ButtonTextMarginLeft = 0;
            this.btn_Exit.ColorContrastOnClick = 45;
            this.btn_Exit.ColorContrastOnHover = 45;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_Exit.CustomizableEdges = borderEdges2;
            this.bunifuTransition1.SetDecoration(this.btn_Exit, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Exit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Exit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Exit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Exit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Exit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Exit.IconMarginLeft = 11;
            this.btn_Exit.IconPadding = 10;
            this.btn_Exit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Exit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Exit.IconSize = 25;
            this.btn_Exit.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Exit.IdleBorderRadius = 1;
            this.btn_Exit.IdleBorderThickness = 1;
            this.btn_Exit.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Exit.IdleIconLeftImage = null;
            this.btn_Exit.IdleIconRightImage = null;
            this.btn_Exit.IndicateFocus = false;
            this.btn_Exit.Location = new System.Drawing.Point(1211, 391);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Exit.OnDisabledState.BorderRadius = 1;
            this.btn_Exit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Exit.OnDisabledState.BorderThickness = 1;
            this.btn_Exit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Exit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Exit.OnDisabledState.IconLeftImage = null;
            this.btn_Exit.OnDisabledState.IconRightImage = null;
            this.btn_Exit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Exit.onHoverState.BorderRadius = 1;
            this.btn_Exit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Exit.onHoverState.BorderThickness = 1;
            this.btn_Exit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Exit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.onHoverState.IconLeftImage = null;
            this.btn_Exit.onHoverState.IconRightImage = null;
            this.btn_Exit.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Exit.OnIdleState.BorderRadius = 1;
            this.btn_Exit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Exit.OnIdleState.BorderThickness = 1;
            this.btn_Exit.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Exit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.OnIdleState.IconLeftImage = null;
            this.btn_Exit.OnIdleState.IconRightImage = null;
            this.btn_Exit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Exit.OnPressedState.BorderRadius = 1;
            this.btn_Exit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Exit.OnPressedState.BorderThickness = 1;
            this.btn_Exit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Exit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.OnPressedState.IconLeftImage = null;
            this.btn_Exit.OnPressedState.IconRightImage = null;
            this.btn_Exit.Size = new System.Drawing.Size(126, 65);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Exit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Exit.TextMarginLeft = 0;
            this.btn_Exit.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Exit.UseDefaultRadiusAndThickness = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // companyCart1
            // 
            this.bunifuTransition1.SetDecoration(this.companyCart1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.companyCart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyCart1.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.companyCart1.Location = new System.Drawing.Point(3, 3);
            this.companyCart1.Name = "companyCart1";
            this.companyCart1.Size = new System.Drawing.Size(597, 380);
            this.companyCart1.TabIndex = 9;
            this.companyCart1.Tag = "0";
            this.companyCart1.Click += new System.EventHandler(this.companyCart_Click);
            // 
            // companyCart2
            // 
            this.bunifuTransition1.SetDecoration(this.companyCart2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.companyCart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyCart2.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.companyCart2.Location = new System.Drawing.Point(606, 3);
            this.companyCart2.Name = "companyCart2";
            this.companyCart2.Size = new System.Drawing.Size(597, 380);
            this.companyCart2.TabIndex = 10;
            this.companyCart2.Tag = "1";
            this.companyCart2.Click += new System.EventHandler(this.companyCart_Click);
            // 
            // companyCart3
            // 
            this.bunifuTransition1.SetDecoration(this.companyCart3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.companyCart3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyCart3.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.companyCart3.Location = new System.Drawing.Point(3, 389);
            this.companyCart3.Name = "companyCart3";
            this.companyCart3.Size = new System.Drawing.Size(597, 381);
            this.companyCart3.TabIndex = 9;
            this.companyCart3.Tag = "2";
            this.companyCart3.Click += new System.EventHandler(this.companyCart_Click);
            // 
            // companyCart4
            // 
            this.bunifuTransition1.SetDecoration(this.companyCart4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.companyCart4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyCart4.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.companyCart4.Location = new System.Drawing.Point(606, 389);
            this.companyCart4.Name = "companyCart4";
            this.companyCart4.Size = new System.Drawing.Size(597, 381);
            this.companyCart4.TabIndex = 10;
            this.companyCart4.Tag = "3";
            this.companyCart4.Click += new System.EventHandler(this.companyCart_Click);
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
            this.bunifuTransition1.MaxAnimationTime = 2000;
            // 
            // CompaniesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 773);
            this.Controls.Add(this.MainPanel);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Name = "CompaniesFrm";
            this.Text = "Companies";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CompaniesFrm_Load);
            this.MainPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel LbCompanyPhone;
        private Bunifu.UI.WinForms.BunifuLabel LbCompanyAddress;
        private Bunifu.UI.WinForms.BunifuLabel LbCompanyEmail;
        private Bunifu.UI.WinForms.BunifuLabel LbCompanyDescription;
        private Bunifu.UI.WinForms.BunifuLabel LbCompanyName;
        private Bunifu.UI.WinForms.BunifuPanel MainPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuVSlider PageChanger;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_Exit;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private Controlls.CompanyCart companyCart1;
        private Controlls.CompanyCart companyCart2;
        private Controlls.CompanyCart companyCart3;
        private Controlls.CompanyCart companyCart4;
    }
}