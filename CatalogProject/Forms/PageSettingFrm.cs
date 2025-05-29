using CatalogProject.Servise.Font;
using CatalogProject.Servise.helper;
using CatalogProject.Servise.Them;
using Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using Font = Models.Font;

namespace BunifuGradientPanelDemo
{
    public partial class PageSettingFrm : Form
    {
        private IFontService _fontService;
        private IThemeService _themeService;
        private bool _imageChanged;
        private Font _formFont;
        private Font _buttonFont;
        private FormName _formName;


        public PageSettingFrm(IFontService fontService, IThemeService themeService)
        {
            _fontService = fontService;
            _themeService = themeService;
            InitializeComponent();
            SetupGradientPanel();
            SetupControlPanel();
        }

        public void InitializeData(FormName formName)
        {
            _formName = formName;
        }
        private void SetupGradientPanel()
        {
            // Create the main gradient panel

            gradientPanel.GradientTopLeft = Color.DodgerBlue;
            gradientPanel.GradientTopRight = Color.DeepSkyBlue;
            gradientPanel.GradientBottomLeft = Color.RoyalBlue;
            gradientPanel.GradientBottomRight = Color.Navy;
            gradientPanel.Quality = 10;

        }

        private void SetupControlPanel()
        {
            // Top Left Color

            btnTopLeft.Click += (sender, e) =>
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    gradientPanel.GradientTopLeft = colorDialog.Color;
                    btnTopLeft.BackColor = colorDialog.Color;
                }
            };
            btnTopLeft.BackColor = gradientPanel.GradientTopLeft;

            // Top Right Color

            btnTopRight.Click += (sender, e) =>
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    gradientPanel.GradientTopRight = colorDialog.Color;
                    btnTopRight.BackColor = colorDialog.Color;
                }
            };
            btnTopRight.BackColor = gradientPanel.GradientTopRight;

            // Bottom Left Color
            btnBottomLeft.Click += (sender, e) =>
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    gradientPanel.GradientBottomLeft = colorDialog.Color;
                    btnBottomLeft.BackColor = colorDialog.Color;
                }
            };
            btnBottomLeft.BackColor = gradientPanel.GradientBottomLeft;

            // Bottom Right Color
            btnBottomRight.Click += (sender, e) =>
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    gradientPanel.GradientBottomRight = colorDialog.Color;
                    btnBottomRight.BackColor = colorDialog.Color;
                }
            };
            btnBottomRight.BackColor = gradientPanel.GradientBottomRight;

            // Quality




            trackQuality.Width = 200;
            trackQuality.Minimum = 1;
            trackQuality.Maximum = 100;
            trackQuality.Value = gradientPanel.Quality;
            trackQuality.TickFrequency = 10;
            trackQuality.ValueChanged += (sender, e) =>
            {
                gradientPanel.Quality = trackQuality.Value;
            };



            // Gradient direction options


            radTopToBottom.AutoSize = true;
            radTopToBottom.Checked = true;
            radTopToBottom.CheckedChanged += (sender, e) =>
            {
                if (radTopToBottom.Checked)
                {
                    gradientPanel.GradientTopLeft = btnTopLeft.BackColor;
                    gradientPanel.GradientTopRight = btnTopLeft.BackColor;
                    gradientPanel.GradientBottomLeft = btnBottomLeft.BackColor;
                    gradientPanel.GradientBottomRight = btnBottomLeft.BackColor;
                }
            };

            radLeftToRight.AutoSize = true;
            radLeftToRight.CheckedChanged += (sender, e) =>
            {
                if (radLeftToRight.Checked)
                {
                    gradientPanel.GradientTopLeft = btnTopLeft.BackColor;
                    gradientPanel.GradientTopRight = btnTopRight.BackColor;
                    gradientPanel.GradientBottomLeft = btnTopLeft.BackColor;
                    gradientPanel.GradientBottomRight = btnTopRight.BackColor;
                }
            };


            radDiagonal.AutoSize = true;
            radDiagonal.CheckedChanged += (sender, e) =>
            {
                if (radDiagonal.Checked)
                {
                    gradientPanel.GradientTopLeft = btnTopLeft.BackColor;
                    gradientPanel.GradientTopRight = btnTopRight.BackColor;
                    gradientPanel.GradientBottomLeft = btnBottomLeft.BackColor;
                    gradientPanel.GradientBottomRight = btnBottomRight.BackColor;
                }
            };

            // Reset button
            btnReset.Click += (sender, e) =>
            {
                gradientPanel.GradientTopLeft = Color.DodgerBlue;
                gradientPanel.GradientTopRight = Color.DeepSkyBlue;
                gradientPanel.GradientBottomLeft = Color.RoyalBlue;
                gradientPanel.GradientBottomRight = Color.Navy;
                gradientPanel.Quality = 10;

                btnTopLeft.BackColor = gradientPanel.GradientTopLeft;
                btnTopRight.BackColor = gradientPanel.GradientTopRight;
                btnBottomLeft.BackColor = gradientPanel.GradientBottomLeft;
                btnBottomRight.BackColor = gradientPanel.GradientBottomRight;

                trackQuality.Value = gradientPanel.Quality;

                radDiagonal.Checked = true;
            };

            ///btn format

            btnHoverColor.Click += (sender, e) =>
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    bunifuButton.onHoverState.FillColor = colorDialog.Color;
                    btnHoverColor.BackColor = colorDialog.Color;
                }
            };


            // Top Right Color

            btnClickColor.Click += (sender, e) =>
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    bunifuButton.OnPressedState.FillColor = colorDialog.Color;
                    btnClickColor.BackColor = colorDialog.Color;
                }
            };


            // Bottom Left Color
            btnFillColor.Click += (sender, e) =>
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    bunifuButton.OnIdleState.FillColor = colorDialog.Color;
                    btnFillColor.BackColor = colorDialog.Color;
                }
            };

            btnBorderColor.Click += (sender, e) =>
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    bunifuButton.OnIdleState.BorderColor = colorDialog.Color;
                    bunifuButton.OnPressedState.BorderColor = colorDialog.Color;
                    bunifuButton.onHoverState.BorderColor = colorDialog.Color;

                    btnBorderColor.BackColor = colorDialog.Color;
                }
            };
            btnTextColor.Click += (sender, e) =>
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    bunifuButton.OnIdleState.ForeColor = colorDialog.Color;
                    bunifuButton.OnPressedState.ForeColor = colorDialog.Color;
                    bunifuButton.onHoverState.ForeColor = colorDialog.Color;

                    btnTextColor.BackColor = colorDialog.Color;
                }
            };
            btnCardBgColor.Click += (sender, e) =>
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    btnCardBgColor.BackColor = colorDialog.Color;
                }
            };
            btnBgColor.Click += (sender, e) =>
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    btnBgColor.BackColor = colorDialog.Color;
                }
            };
            btnMainTextColor.Click += (sender, e) =>
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    btnMainTextColor.BackColor = colorDialog.Color;
                }
            };
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveThemeColors();
                SaveFont();

            }
            catch (Exception exception)
            {

            }

        }

        private void SaveFont()
        {
            if (_formFont != null)
            {
                _fontService.SaveFont(_formFont);
            }
            if (_buttonFont != null)
            {
                _fontService.SaveFont(_buttonFont);

            }
        }

        private void SaveThemeColors()
        {

            var themeColors = new Theme()
            {
                ButtonBorderColor = ColorTranslator.ToHtml(btnBorderColor.BackColor),
                ButtonColor = ColorTranslator.ToHtml(btnFillColor.BackColor),
                ButtonHoverColor = ColorTranslator.ToHtml(btnHoverColor.BackColor),
                ButtonPressedColor = ColorTranslator.ToHtml(btnClickColor.BackColor),
                ButtonTextColor = ColorTranslator.ToHtml(btnTextColor.BackColor),
                //
                GradientBottomLeft = ColorTranslator.ToHtml(gradientPanel.GradientBottomLeft),
                GradientBottomRight = ColorTranslator.ToHtml(gradientPanel.GradientBottomRight),
                GradientTopLeft = ColorTranslator.ToHtml(gradientPanel.GradientTopLeft),
                GradientTopRight = ColorTranslator.ToHtml(gradientPanel.GradientTopRight),
                //
                CardBGColor = ColorTranslator.ToHtml(btnCardBgColor.BackColor),
                BGColor = ColorTranslator.ToHtml(btnBgColor.BackColor),
                FormName = _formName.ToString(),
                MainTextColor = ColorTranslator.ToHtml(btnMainTextColor.BackColor)

            };
            if (_imageChanged)
            {
                var imageName = Helper.SaveFileToDirectoryAndGetImageName(txtImageName.Text,

                    Helper.PathName.BGImage);
                themeColors.BGImageName = imageName;

            }
            _themeService.SaveThemeColors(themeColors);
        }
        private void btnLoadFont_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    System.Drawing.Font selectedFont = fontDialog.Font;

                    _buttonFont = new Font
                    {
                        FontFamily = selectedFont.FontFamily.Name,
                        Size = selectedFont.Size,
                        Style = selectedFont.Style,
                        FormName = _formName,
                        FontPart = FontPart.Button
                    };

                    // اعمال آنی به دکمه پیش‌نمایش (اختیاری)
                    bunifuButton.Font = selectedFont;
                }
            }
        }

      
        private void SetFont()
        {
            var font= _fontService.GetThemeFontWithDetail(_formName,FontPart.Button );
            if (font!=null)
            {
                bunifuButton.Font = font.ToFont();
            }
        }

        private void SetThemeColor()
        {
            var themeColor = _themeService.GetThemeColorsWithName(_formName.ToString());
            if (themeColor!=null)
            {
                gradientPanel.GradientBottomLeft = ColorTranslator.FromHtml(themeColor.GradientBottomLeft);
                btnBottomLeft.BackColor = ColorTranslator.FromHtml(themeColor.GradientBottomLeft);


                gradientPanel.GradientBottomRight = ColorTranslator.FromHtml(themeColor.GradientBottomRight);
                btnBottomRight.BackColor = ColorTranslator.FromHtml(themeColor.GradientBottomRight);

                gradientPanel.GradientTopLeft = ColorTranslator.FromHtml(themeColor.GradientTopLeft);
                btnTopLeft.BackColor = ColorTranslator.FromHtml(themeColor.GradientTopLeft);


                gradientPanel.GradientTopRight = ColorTranslator.FromHtml(themeColor.GradientTopRight);
                btnTopRight.BackColor = ColorTranslator.FromHtml(themeColor.GradientTopRight);

                bunifuButton.onHoverState.FillColor = ColorTranslator.FromHtml(themeColor.ButtonHoverColor);
                btnHoverColor.BackColor = ColorTranslator.FromHtml(themeColor.ButtonHoverColor);

                bunifuButton.OnPressedState.FillColor = ColorTranslator.FromHtml(themeColor.ButtonPressedColor);
                btnClickColor.BackColor = ColorTranslator.FromHtml(themeColor.ButtonPressedColor);

                bunifuButton.OnIdleState.FillColor = ColorTranslator.FromHtml(themeColor.ButtonColor);
                btnFillColor.BackColor = ColorTranslator.FromHtml(themeColor.ButtonColor);

                bunifuButton.OnIdleState.BorderColor = ColorTranslator.FromHtml(themeColor.ButtonBorderColor);
                bunifuButton.OnPressedState.BorderColor = ColorTranslator.FromHtml(themeColor.ButtonBorderColor);
                bunifuButton.onHoverState.BorderColor = ColorTranslator.FromHtml(themeColor.ButtonBorderColor);

                btnBorderColor.BackColor = ColorTranslator.FromHtml(themeColor.ButtonBorderColor);



                bunifuButton.OnIdleState.ForeColor = ColorTranslator.FromHtml(themeColor.ButtonTextColor);
                bunifuButton.OnPressedState.ForeColor = ColorTranslator.FromHtml(themeColor.ButtonTextColor);
                bunifuButton.onHoverState.ForeColor = ColorTranslator.FromHtml(themeColor.ButtonTextColor);

                btnTextColor.BackColor = ColorTranslator.FromHtml(themeColor.ButtonTextColor);

                btnCardBgColor.BackColor = ColorTranslator.FromHtml(themeColor.CardBGColor);
                btnBgColor.BackColor = ColorTranslator.FromHtml(themeColor.BGColor);

                btnMainTextColor.BackColor = ColorTranslator.FromHtml(themeColor.MainTextColor);

                if (!string.IsNullOrEmpty(themeColor.BGImageName))
                {
                    txtImageName.Text = themeColor.BGImageName;
                    picboxBGImage.Image = Helper.LoadImageFromPath(themeColor.BGImageName, Helper.PathName.BGImage);
                }
            }

        }


        private void btnBGimage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "تصاویر|*.jpg;*.png;*.bmp;*.gif" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImageName.Text = ofd.FileName;
                    _imageChanged = true;
                    picboxBGImage.Image = Helper.LoadImageFromPath(ofd.FileName);

                }
            }
        }

        private void btnFormFont_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    System.Drawing.Font selectedFont = fontDialog.Font;

                    _formFont = new Font
                    {
                        FontFamily = selectedFont.FontFamily.Name,
                        Size = selectedFont.Size,
                        Style = selectedFont.Style,
                        FormName = _formName,
                        FontPart = FontPart.Form
                    };

                }
            }
        }

        private void PageSettingFrm_Load(object sender, EventArgs e)
        {
            SetThemeColor();
            SetFont();
        }
    }
}
