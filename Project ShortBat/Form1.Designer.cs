namespace Project_ShortBat
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
            buttonStop = new MaterialSkin.Controls.MaterialButton();
            materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            subFileSwitch = new MaterialSkin.Controls.MaterialSwitch();
            especiesSwitch = new MaterialSkin.Controls.MaterialSwitch();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            pippiSwitch = new MaterialSkin.Controls.MaterialSwitch();
            dispositiveSwitch = new MaterialSkin.Controls.MaterialSwitch();
            enableLimit = new MaterialSkin.Controls.MaterialSwitch();
            cantEspecies = new MaterialSkin.Controls.MaterialSlider();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            buttonSelectDestinationFolder = new Button();
            versionLabel = new MaterialSkin.Controls.MaterialLabel();
            pictureBox2 = new PictureBox();
            loadCSV = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
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
            loadExcel.Location = new Point(37, 373);
            loadExcel.Margin = new Padding(4, 6, 4, 6);
            loadExcel.MouseState = MaterialSkin.MouseState.HOVER;
            loadExcel.Name = "loadExcel";
            loadExcel.NoAccentTextColor = Color.Empty;
            loadExcel.Size = new Size(118, 36);
            loadExcel.TabIndex = 0;
            loadExcel.Text = "Cargar XLSX";
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
            matrix.Size = new Size(529, 544);
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
            materialCard1.Location = new Point(321, 81);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(599, 578);
            materialCard1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-158, 348);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // buttonStop
            // 
            buttonStop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonStop.BackColor = Color.Gold;
            buttonStop.Cursor = Cursors.Hand;
            buttonStop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonStop.Depth = 0;
            buttonStop.HighEmphasis = true;
            buttonStop.Icon = null;
            buttonStop.Location = new Point(863, 26);
            buttonStop.Margin = new Padding(4, 6, 4, 6);
            buttonStop.MouseState = MaterialSkin.MouseState.HOVER;
            buttonStop.Name = "buttonStop";
            buttonStop.NoAccentTextColor = Color.Empty;
            buttonStop.Size = new Size(96, 36);
            buttonStop.TabIndex = 15;
            buttonStop.Text = "Cancelar";
            buttonStop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonStop.UseAccentColor = false;
            buttonStop.UseVisualStyleBackColor = false;
            // 
            // materialProgressBar1
            // 
            materialProgressBar1.Depth = 0;
            materialProgressBar1.Location = new Point(1, 689);
            materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            materialProgressBar1.Name = "materialProgressBar1";
            materialProgressBar1.Size = new Size(967, 5);
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
            especiesSwitch.Location = new Point(14, 118);
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
            materialCard2.Controls.Add(pippiSwitch);
            materialCard2.Controls.Add(dispositiveSwitch);
            materialCard2.Controls.Add(enableLimit);
            materialCard2.Controls.Add(cantEspecies);
            materialCard2.Controls.Add(materialLabel1);
            materialCard2.Controls.Add(especiesSwitch);
            materialCard2.Controls.Add(subFileSwitch);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(37, 81);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(256, 281);
            materialCard2.TabIndex = 8;
            // 
            // pippiSwitch
            // 
            pippiSwitch.AutoSize = true;
            pippiSwitch.Depth = 0;
            pippiSwitch.Location = new Point(14, 155);
            pippiSwitch.Margin = new Padding(0);
            pippiSwitch.MouseLocation = new Point(-1, -1);
            pippiSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            pippiSwitch.Name = "pippiSwitch";
            pippiSwitch.Ripple = true;
            pippiSwitch.Size = new Size(157, 37);
            pippiSwitch.TabIndex = 13;
            pippiSwitch.Text = "Excluir PIPPIP";
            pippiSwitch.UseVisualStyleBackColor = true;
            // 
            // dispositiveSwitch
            // 
            dispositiveSwitch.AutoSize = true;
            dispositiveSwitch.Depth = 0;
            dispositiveSwitch.ImageAlign = ContentAlignment.BottomLeft;
            dispositiveSwitch.Location = new Point(14, 81);
            dispositiveSwitch.Margin = new Padding(0);
            dispositiveSwitch.MouseLocation = new Point(-1, -1);
            dispositiveSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            dispositiveSwitch.Name = "dispositiveSwitch";
            dispositiveSwitch.Ripple = true;
            dispositiveSwitch.Size = new Size(137, 37);
            dispositiveSwitch.TabIndex = 12;
            dispositiveSwitch.Text = "Dispositivo";
            dispositiveSwitch.UseVisualStyleBackColor = true;
            // 
            // enableLimit
            // 
            enableLimit.AutoSize = true;
            enableLimit.Depth = 0;
            enableLimit.Location = new Point(14, 192);
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
            cantEspecies.Location = new Point(2, 232);
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
            buttonSelectDestinationFolder.Location = new Point(140, 417);
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
            versionLabel.Location = new Point(896, 673);
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
            // loadCSV
            // 
            loadCSV.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loadCSV.BackColor = Color.Gold;
            loadCSV.Cursor = Cursors.Hand;
            loadCSV.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            loadCSV.Depth = 0;
            loadCSV.HighEmphasis = true;
            loadCSV.Icon = null;
            loadCSV.Location = new Point(183, 373);
            loadCSV.Margin = new Padding(4, 6, 4, 6);
            loadCSV.MouseState = MaterialSkin.MouseState.HOVER;
            loadCSV.Name = "loadCSV";
            loadCSV.NoAccentTextColor = Color.Empty;
            loadCSV.Size = new Size(110, 36);
            loadCSV.TabIndex = 13;
            loadCSV.Text = "Cargar CSV";
            loadCSV.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            loadCSV.UseAccentColor = false;
            loadCSV.UseVisualStyleBackColor = false;
            loadCSV.Click += loadCSV_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            materialLabel2.ForeColor = SystemColors.ControlText;
            materialLabel2.Location = new Point(267, 396);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(26, 13);
            materialLabel2.TabIndex = 14;
            materialLabel2.Text = "BETA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(966, 695);
            Controls.Add(buttonStop);
            Controls.Add(materialLabel2);
            Controls.Add(buttonSelectDestinationFolder);
            Controls.Add(loadCSV);
            Controls.Add(materialCard1);
            Controls.Add(pictureBox2);
            Controls.Add(versionLabel);
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
        private MaterialSkin.Controls.MaterialSwitch dispositiveSwitch;
        private MaterialSkin.Controls.MaterialButton loadCSV;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSwitch pippiSwitch;
        private MaterialSkin.Controls.MaterialButton buttonStop;
    }
}
