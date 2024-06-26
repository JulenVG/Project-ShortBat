﻿namespace Project_ShortBat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            loadExcel = new MaterialSkin.Controls.MaterialButton();
            matrix = new RichTextBox();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            pictureBox1 = new PictureBox();
            materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            subFileSwitch = new MaterialSkin.Controls.MaterialSwitch();
            especiesSwitch = new MaterialSkin.Controls.MaterialSwitch();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            enableLimit = new MaterialSkin.Controls.MaterialSwitch();
            cantEspecies = new MaterialSkin.Controls.MaterialSlider();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            buttonSelectDestinationFolder = new Button();
            versionLabel = new MaterialSkin.Controls.MaterialLabel();
            pictureBox2 = new PictureBox();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // loadExcel
            // 
            loadExcel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loadExcel.BackColor = Color.Gold;
            loadExcel.Cursor = Cursors.Hand;
            loadExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            loadExcel.Depth = 0;
            loadExcel.HighEmphasis = true;
            loadExcel.Icon = null;
            loadExcel.Location = new Point(72, 337);
            loadExcel.Margin = new Padding(4, 6, 4, 6);
            loadExcel.MouseState = MaterialSkin.MouseState.HOVER;
            loadExcel.Name = "loadExcel";
            loadExcel.NoAccentTextColor = Color.Empty;
            loadExcel.Size = new Size(126, 36);
            loadExcel.TabIndex = 0;
            loadExcel.Text = "Cargar Excel";
            loadExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            loadExcel.UseAccentColor = false;
            loadExcel.UseVisualStyleBackColor = false;
            loadExcel.Click += buttonLoadExcel_Click;
            // 
            // matrix
            // 
            matrix.BackColor = Color.FromArgb(255, 255, 128);
            matrix.BorderStyle = BorderStyle.None;
            matrix.Font = new Font("Cascadia Code SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            matrix.Location = new Point(49, 17);
            matrix.Name = "matrix";
            matrix.ReadOnly = true;
            matrix.Size = new Size(529, 587);
            matrix.TabIndex = 1;
            matrix.Text = "";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(matrix);
            materialCard1.Controls.Add(pictureBox1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(321, 110);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(595, 621);
            materialCard1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-158, 319);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // materialProgressBar1
            // 
            materialProgressBar1.Depth = 0;
            materialProgressBar1.Location = new Point(0, 760);
            materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            materialProgressBar1.Name = "materialProgressBar1";
            materialProgressBar1.Size = new Size(1003, 5);
            materialProgressBar1.TabIndex = 7;
            // 
            // subFileSwitch
            // 
            subFileSwitch.AutoSize = true;
            subFileSwitch.Depth = 0;
            subFileSwitch.Location = new Point(14, 44);
            subFileSwitch.Margin = new Padding(0);
            subFileSwitch.MouseLocation = new Point(-1, -1);
            subFileSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            subFileSwitch.Name = "subFileSwitch";
            subFileSwitch.Ripple = true;
            subFileSwitch.Size = new Size(135, 37);
            subFileSwitch.TabIndex = 7;
            subFileSwitch.Text = "Estaciones";
            subFileSwitch.UseVisualStyleBackColor = true;
            // 
            // especiesSwitch
            // 
            especiesSwitch.AutoSize = true;
            especiesSwitch.Depth = 0;
            especiesSwitch.Location = new Point(14, 81);
            especiesSwitch.Margin = new Padding(0);
            especiesSwitch.MouseLocation = new Point(-1, -1);
            especiesSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            especiesSwitch.Name = "especiesSwitch";
            especiesSwitch.Ripple = true;
            especiesSwitch.Size = new Size(120, 37);
            especiesSwitch.TabIndex = 7;
            especiesSwitch.Text = "Especies";
            especiesSwitch.UseVisualStyleBackColor = true;
            especiesSwitch.CheckedChanged += especiesSwitch_CheckedChanged;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(enableLimit);
            materialCard2.Controls.Add(cantEspecies);
            materialCard2.Controls.Add(materialLabel1);
            materialCard2.Controls.Add(especiesSwitch);
            materialCard2.Controls.Add(subFileSwitch);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(37, 110);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(256, 207);
            materialCard2.TabIndex = 8;
            // 
            // enableLimit
            // 
            enableLimit.AutoSize = true;
            enableLimit.Depth = 0;
            enableLimit.Location = new Point(14, 118);
            enableLimit.Margin = new Padding(0);
            enableLimit.MouseLocation = new Point(-1, -1);
            enableLimit.MouseState = MaterialSkin.MouseState.HOVER;
            enableLimit.Name = "enableLimit";
            enableLimit.Ripple = true;
            enableLimit.Size = new Size(186, 37);
            enableLimit.TabIndex = 11;
            enableLimit.Text = "Límite por especie";
            enableLimit.UseVisualStyleBackColor = true;
            enableLimit.CheckedChanged += enableLimit_CheckedChanged;
            // 
            // cantEspecies
            // 
            cantEspecies.Depth = 0;
            cantEspecies.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cantEspecies.Location = new Point(2, 158);
            cantEspecies.MouseState = MaterialSkin.MouseState.HOVER;
            cantEspecies.Name = "cantEspecies";
            cantEspecies.Size = new Size(237, 40);
            cantEspecies.TabIndex = 10;
            cantEspecies.Text = "";
            cantEspecies.UseAccentColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel1.Location = new Point(48, 14);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(164, 29);
            materialLabel1.TabIndex = 9;
            materialLabel1.Text = "Tipo de filtrado";
            // 
            // buttonSelectDestinationFolder
            // 
            buttonSelectDestinationFolder.BackgroundImage = (Image)resources.GetObject("buttonSelectDestinationFolder.BackgroundImage");
            buttonSelectDestinationFolder.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSelectDestinationFolder.FlatAppearance.BorderSize = 0;
            buttonSelectDestinationFolder.FlatStyle = FlatStyle.Flat;
            buttonSelectDestinationFolder.Location = new Point(214, 337);
            buttonSelectDestinationFolder.Name = "buttonSelectDestinationFolder";
            buttonSelectDestinationFolder.Size = new Size(62, 36);
            buttonSelectDestinationFolder.TabIndex = 9;
            buttonSelectDestinationFolder.UseVisualStyleBackColor = true;
            buttonSelectDestinationFolder.Click += buttonSelectDestinationFolder_Click;
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Depth = 0;
            versionLabel.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            versionLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            versionLabel.ForeColor = SystemColors.ControlText;
            versionLabel.Location = new Point(903, 744);
            versionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(64, 13);
            versionLabel.TabIndex = 10;
            versionLabel.Text = "materialLabel2";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(162, 429);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(212, 229);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(966, 766);
            Controls.Add(materialCard1);
            Controls.Add(pictureBox2);
            Controls.Add(versionLabel);
            Controls.Add(buttonSelectDestinationFolder);
            Controls.Add(materialCard2);
            Controls.Add(materialProgressBar1);
            Controls.Add(loadExcel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Sizable = false;
            Text = "ShortBat";
            materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton loadExcel;
        private RichTextBox matrix;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialSwitch subFileSwitch;
        private MaterialSkin.Controls.MaterialSwitch especiesSwitch;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSlider cantEspecies;
        private MaterialSkin.Controls.MaterialSwitch enableLimit;
        private Button buttonSelectDestinationFolder;
        private MaterialSkin.Controls.MaterialLabel versionLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
