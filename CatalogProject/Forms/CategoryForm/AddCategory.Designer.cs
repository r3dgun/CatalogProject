namespace CatalogProject.Forms.CategoryForm
{
    partial class AddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategory));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.txtDescribtion = new System.Windows.Forms.RichTextBox();
            this.txtCompanyName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnInsertCategory = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtCategoryImageName = new System.Windows.Forms.TextBox();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.PicBoxImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescribtion
            // 
            this.txtDescribtion.Location = new System.Drawing.Point(545, 63);
            this.txtDescribtion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescribtion.Name = "txtDescribtion";
            this.txtDescribtion.Size = new System.Drawing.Size(193, 117);
            this.txtDescribtion.TabIndex = 6;
            this.txtDescribtion.Text = "";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.AcceptsReturn = false;
            this.txtCompanyName.AcceptsTab = false;
            this.txtCompanyName.AnimationSpeed = 200;
            this.txtCompanyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCompanyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCompanyName.AutoSizeHeight = true;
            this.txtCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.txtCompanyName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCompanyName.BackgroundImage")));
            this.txtCompanyName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtCompanyName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCompanyName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtCompanyName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtCompanyName.BorderRadius = 1;
            this.txtCompanyName.BorderThickness = 1;
            this.txtCompanyName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompanyName.DefaultFont = new System.Drawing.Font("B Nazanin", 12F);
            this.txtCompanyName.DefaultText = "";
            this.txtCompanyName.FillColor = System.Drawing.Color.White;
            this.txtCompanyName.HideSelection = true;
            this.txtCompanyName.IconLeft = null;
            this.txtCompanyName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompanyName.IconPadding = 10;
            this.txtCompanyName.IconRight = null;
            this.txtCompanyName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompanyName.Lines = new string[0];
            this.txtCompanyName.Location = new System.Drawing.Point(545, 15);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompanyName.MaxLength = 32767;
            this.txtCompanyName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCompanyName.Modified = false;
            this.txtCompanyName.Multiline = false;
            this.txtCompanyName.Name = "txtCompanyName";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCompanyName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCompanyName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCompanyName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCompanyName.OnIdleState = stateProperties4;
            this.txtCompanyName.Padding = new System.Windows.Forms.Padding(4);
            this.txtCompanyName.PasswordChar = '\0';
            this.txtCompanyName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtCompanyName.PlaceholderText = "Enter text";
            this.txtCompanyName.ReadOnly = false;
            this.txtCompanyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCompanyName.SelectedText = "";
            this.txtCompanyName.SelectionLength = 0;
            this.txtCompanyName.SelectionStart = 0;
            this.txtCompanyName.ShortcutsEnabled = true;
            this.txtCompanyName.Size = new System.Drawing.Size(195, 40);
            this.txtCompanyName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtCompanyName.TabIndex = 3;
            this.txtCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCompanyName.TextMarginBottom = 0;
            this.txtCompanyName.TextMarginLeft = 3;
            this.txtCompanyName.TextMarginTop = 1;
            this.txtCompanyName.TextPlaceholder = "Enter text";
            this.txtCompanyName.UseSystemPasswordChar = false;
            this.txtCompanyName.WordWrap = true;
            // 
            // btnInsertCategory
            // 
            this.btnInsertCategory.AllowAnimations = true;
            this.btnInsertCategory.AllowMouseEffects = true;
            this.btnInsertCategory.AllowToggling = false;
            this.btnInsertCategory.AnimationSpeed = 200;
            this.btnInsertCategory.AutoGenerateColors = false;
            this.btnInsertCategory.AutoRoundBorders = false;
            this.btnInsertCategory.AutoSizeLeftIcon = true;
            this.btnInsertCategory.AutoSizeRightIcon = true;
            this.btnInsertCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnInsertCategory.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnInsertCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertCategory.BackgroundImage")));
            this.btnInsertCategory.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInsertCategory.ButtonText = "اضافه کردن دسته";
            this.btnInsertCategory.ButtonTextMarginLeft = 0;
            this.btnInsertCategory.ColorContrastOnClick = 45;
            this.btnInsertCategory.ColorContrastOnHover = 45;
            this.btnInsertCategory.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnInsertCategory.CustomizableEdges = borderEdges1;
            this.btnInsertCategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInsertCategory.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnInsertCategory.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnInsertCategory.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnInsertCategory.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnInsertCategory.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.btnInsertCategory.ForeColor = System.Drawing.Color.White;
            this.btnInsertCategory.IconLeft = null;
            this.btnInsertCategory.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertCategory.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnInsertCategory.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnInsertCategory.IconMarginLeft = 11;
            this.btnInsertCategory.IconPadding = 10;
            this.btnInsertCategory.IconRight = null;
            this.btnInsertCategory.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertCategory.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnInsertCategory.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnInsertCategory.IconSize = 25;
            this.btnInsertCategory.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnInsertCategory.IdleBorderRadius = 0;
            this.btnInsertCategory.IdleBorderThickness = 0;
            this.btnInsertCategory.IdleFillColor = System.Drawing.Color.Empty;
            this.btnInsertCategory.IdleIconLeftImage = null;
            this.btnInsertCategory.IdleIconRightImage = null;
            this.btnInsertCategory.IndicateFocus = false;
            this.btnInsertCategory.Location = new System.Drawing.Point(330, 275);
            this.btnInsertCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertCategory.Name = "btnInsertCategory";
            this.btnInsertCategory.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnInsertCategory.OnDisabledState.BorderRadius = 1;
            this.btnInsertCategory.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInsertCategory.OnDisabledState.BorderThickness = 1;
            this.btnInsertCategory.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnInsertCategory.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnInsertCategory.OnDisabledState.IconLeftImage = null;
            this.btnInsertCategory.OnDisabledState.IconRightImage = null;
            this.btnInsertCategory.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnInsertCategory.onHoverState.BorderRadius = 1;
            this.btnInsertCategory.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInsertCategory.onHoverState.BorderThickness = 1;
            this.btnInsertCategory.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnInsertCategory.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnInsertCategory.onHoverState.IconLeftImage = null;
            this.btnInsertCategory.onHoverState.IconRightImage = null;
            this.btnInsertCategory.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnInsertCategory.OnIdleState.BorderRadius = 1;
            this.btnInsertCategory.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInsertCategory.OnIdleState.BorderThickness = 1;
            this.btnInsertCategory.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnInsertCategory.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnInsertCategory.OnIdleState.IconLeftImage = null;
            this.btnInsertCategory.OnIdleState.IconRightImage = null;
            this.btnInsertCategory.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnInsertCategory.OnPressedState.BorderRadius = 1;
            this.btnInsertCategory.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInsertCategory.OnPressedState.BorderThickness = 1;
            this.btnInsertCategory.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnInsertCategory.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnInsertCategory.OnPressedState.IconLeftImage = null;
            this.btnInsertCategory.OnPressedState.IconRightImage = null;
            this.btnInsertCategory.Size = new System.Drawing.Size(200, 48);
            this.btnInsertCategory.TabIndex = 9;
            this.btnInsertCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsertCategory.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInsertCategory.TextMarginLeft = 0;
            this.btnInsertCategory.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnInsertCategory.UseDefaultRadiusAndThickness = true;
            this.btnInsertCategory.Click += new System.EventHandler(this.btnInsertCategory_Click);
            // 
            // txtCategoryImageName
            // 
            this.txtCategoryImageName.Location = new System.Drawing.Point(109, 15);
            this.txtCategoryImageName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryImageName.Name = "txtCategoryImageName";
            this.txtCategoryImageName.ReadOnly = true;
            this.txtCategoryImageName.Size = new System.Drawing.Size(197, 37);
            this.txtCategoryImageName.TabIndex = 10;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(9, 12);
            this.btnSaveImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(92, 40);
            this.btnSaveImage.TabIndex = 11;
            this.btnSaveImage.Text = "بارگذاری";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // PicBoxImage
            // 
            this.PicBoxImage.AllowFocused = false;
            this.PicBoxImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicBoxImage.AutoSizeHeight = true;
            this.PicBoxImage.BorderRadius = 63;
            this.PicBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxImage.Image")));
            this.PicBoxImage.IsCircle = true;
            this.PicBoxImage.Location = new System.Drawing.Point(180, 56);
            this.PicBoxImage.Name = "PicBoxImage";
            this.PicBoxImage.Size = new System.Drawing.Size(126, 126);
            this.PicBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxImage.TabIndex = 16;
            this.PicBoxImage.TabStop = false;
            this.PicBoxImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(748, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "اسم دسته";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(748, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "توضیحات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(314, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "عکس دسته";
            // 
            // AddCategory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(845, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PicBoxImage);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.txtCategoryImageName);
            this.Controls.Add(this.btnInsertCategory);
            this.Controls.Add(this.txtDescribtion);
            this.Controls.Add(this.txtCompanyName);
            this.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddCategory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "AddCategory";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtDescribtion;
        private Bunifu.UI.WinForms.BunifuTextBox txtCompanyName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnInsertCategory;
        private System.Windows.Forms.TextBox txtCategoryImageName;
        private System.Windows.Forms.Button btnSaveImage;
        private Bunifu.UI.WinForms.BunifuPictureBox PicBoxImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}