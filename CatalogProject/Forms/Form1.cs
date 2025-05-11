using System;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace BunifuGradientPanelDemo
{
    public partial class Form1 : Form
    {
        private BunifuGradientPanel gradientPanel;

        public Form1()
        {
            InitializeComponent();
            SetupGradientPanel();
            SetupControlPanel();
        }

        private void SetupGradientPanel()
        {
            // Create the main gradient panel
            gradientPanel = new BunifuGradientPanel();
            gradientPanel.Location = new Point(20, 20);
            gradientPanel.Size = new Size(400, 300);
            gradientPanel.GradientTopLeft = Color.DodgerBlue;
            gradientPanel.GradientTopRight = Color.DeepSkyBlue;
            gradientPanel.GradientBottomLeft = Color.RoyalBlue;
            gradientPanel.GradientBottomRight = Color.Navy;
            gradientPanel.Quality = 10;

            // Add a label to show it's the preview panel
            Label previewLabel = new Label();
            previewLabel.Text = "Gradient Panel Preview";
            previewLabel.ForeColor = Color.White;
            previewLabel.AutoSize = true;
            previewLabel.Location = new Point(150, 140);
            gradientPanel.Controls.Add(previewLabel);

            this.Controls.Add(gradientPanel);
        }

        private void SetupControlPanel()
        {
            // Create a panel to hold all the controls
            Panel controlPanel = new Panel();
            controlPanel.Location = new Point(20, 340);
            controlPanel.Size = new Size(760, 250);
            controlPanel.BorderStyle = BorderStyle.FixedSingle;

            // Top Left Color
            Label lblTopLeft = new Label();
            lblTopLeft.Text = "Top Left Color:";
            lblTopLeft.Location = new Point(10, 20);
            lblTopLeft.AutoSize = true;

            Button btnTopLeft = new Button();
            btnTopLeft.Text = "Choose Color";
            btnTopLeft.Location = new Point(120, 15);
            btnTopLeft.Click += (sender, e) => {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    gradientPanel.GradientTopLeft = colorDialog.Color;
                    btnTopLeft.BackColor = colorDialog.Color;
                }
            };
            btnTopLeft.BackColor = gradientPanel.GradientTopLeft;

            // Top Right Color
            Label lblTopRight = new Label();
            lblTopRight.Text = "Top Right Color:";
            lblTopRight.Location = new Point(10, 60);
            lblTopRight.AutoSize = true;

            Button btnTopRight = new Button();
            btnTopRight.Text = "Choose Color";
            btnTopRight.Location = new Point(120, 55);
            btnTopRight.Click += (sender, e) => {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    gradientPanel.GradientTopRight = colorDialog.Color;
                    btnTopRight.BackColor = colorDialog.Color;
                }
            };
            btnTopRight.BackColor = gradientPanel.GradientTopRight;

            // Bottom Left Color
            Label lblBottomLeft = new Label();
            lblBottomLeft.Text = "Bottom Left Color:";
            lblBottomLeft.Location = new Point(10, 100);
            lblBottomLeft.AutoSize = true;

            Button btnBottomLeft = new Button();
            btnBottomLeft.Text = "Choose Color";
            btnBottomLeft.Location = new Point(120, 95);
            btnBottomLeft.Click += (sender, e) => {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    gradientPanel.GradientBottomLeft = colorDialog.Color;
                    btnBottomLeft.BackColor = colorDialog.Color;
                }
            };
            btnBottomLeft.BackColor = gradientPanel.GradientBottomLeft;

            // Bottom Right Color
            Label lblBottomRight = new Label();
            lblBottomRight.Text = "Bottom Right Color:";
            lblBottomRight.Location = new Point(10, 140);
            lblBottomRight.AutoSize = true;

            Button btnBottomRight = new Button();
            btnBottomRight.Text = "Choose Color";
            btnBottomRight.Location = new Point(120, 135);
            btnBottomRight.Click += (sender, e) => {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    gradientPanel.GradientBottomRight = colorDialog.Color;
                    btnBottomRight.BackColor = colorDialog.Color;
                }
            };
            btnBottomRight.BackColor = gradientPanel.GradientBottomRight;

            // Quality
            Label lblQuality = new Label();
            lblQuality.Text = "Quality:";
            lblQuality.Location = new Point(10, 180);
            lblQuality.AutoSize = true;

            Label lblQualityValue = new Label();
            lblQualityValue.Text = gradientPanel.Quality.ToString();
            lblQualityValue.Location = new Point(330, 180);
            lblQualityValue.AutoSize = true;

            TrackBar trackQuality = new TrackBar();
            trackQuality.Location = new Point(120, 175);
            trackQuality.Width = 200;
            trackQuality.Minimum = 1;
            trackQuality.Maximum = 100;
            trackQuality.Value = gradientPanel.Quality;
            trackQuality.TickFrequency = 10;
            trackQuality.ValueChanged += (sender, e) => {
                gradientPanel.Quality = trackQuality.Value;
                lblQualityValue.Text = trackQuality.Value.ToString();
            };

      

            // Gradient direction options
            GroupBox grpDirection = new GroupBox();
            grpDirection.Text = "Gradient Direction";
            grpDirection.Location = new Point(400, 15);
            grpDirection.Size = new Size(300, 180);

            RadioButton radTopToBottom = new RadioButton();
            radTopToBottom.Text = "Top to Bottom";
            radTopToBottom.Location = new Point(20, 30);
            radTopToBottom.AutoSize = true;
            radTopToBottom.Checked = true;
            radTopToBottom.CheckedChanged += (sender, e) => {
                if (radTopToBottom.Checked)
                {
                    gradientPanel.GradientTopLeft = btnTopLeft.BackColor;
                    gradientPanel.GradientTopRight = btnTopLeft.BackColor;
                    gradientPanel.GradientBottomLeft = btnBottomLeft.BackColor;
                    gradientPanel.GradientBottomRight = btnBottomLeft.BackColor;
                }
            };

            RadioButton radLeftToRight = new RadioButton();
            radLeftToRight.Text = "Left to Right";
            radLeftToRight.Location = new Point(20, 60);
            radLeftToRight.AutoSize = true;
            radLeftToRight.CheckedChanged += (sender, e) => {
                if (radLeftToRight.Checked)
                {
                    gradientPanel.GradientTopLeft = btnTopLeft.BackColor;
                    gradientPanel.GradientTopRight = btnTopRight.BackColor;
                    gradientPanel.GradientBottomLeft = btnTopLeft.BackColor;
                    gradientPanel.GradientBottomRight = btnTopRight.BackColor;
                }
            };

            RadioButton radDiagonal = new RadioButton();
            radDiagonal.Text = "Diagonal";
            radDiagonal.Location = new Point(20, 90);
            radDiagonal.AutoSize = true;
            radDiagonal.CheckedChanged += (sender, e) => {
                if (radDiagonal.Checked)
                {
                    gradientPanel.GradientTopLeft = btnTopLeft.BackColor;
                    gradientPanel.GradientTopRight = btnTopRight.BackColor;
                    gradientPanel.GradientBottomLeft = btnBottomLeft.BackColor;
                    gradientPanel.GradientBottomRight = btnBottomRight.BackColor;
                }
            };

            // Reset button
            Button btnReset = new Button();
            btnReset.Text = "Reset to Default";
            btnReset.Location = new Point(400, 210);
            btnReset.Size = new Size(150, 30);
            btnReset.Click += (sender, e) => {
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
                lblQualityValue.Text = gradientPanel.Quality.ToString();

                radDiagonal.Checked = true;
            };

            // Add all controls to the panel
            controlPanel.Controls.Add(lblTopLeft);
            controlPanel.Controls.Add(btnTopLeft);
            controlPanel.Controls.Add(lblTopRight);
            controlPanel.Controls.Add(btnTopRight);
            controlPanel.Controls.Add(lblBottomLeft);
            controlPanel.Controls.Add(btnBottomLeft);
            controlPanel.Controls.Add(lblBottomRight);
            controlPanel.Controls.Add(btnBottomRight);
            controlPanel.Controls.Add(lblQuality);
            controlPanel.Controls.Add(trackQuality);
            controlPanel.Controls.Add(lblQualityValue);
            controlPanel.Controls.Add(btnReset);

            grpDirection.Controls.Add(radTopToBottom);
            grpDirection.Controls.Add(radLeftToRight);
            grpDirection.Controls.Add(radDiagonal);
            controlPanel.Controls.Add(grpDirection);

            this.Controls.Add(controlPanel);
        }
    }
}
