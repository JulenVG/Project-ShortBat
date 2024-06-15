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
            loadExcel = new MaterialSkin.Controls.MaterialButton();
            matrix = new RichTextBox();
            checkSubCarpetas = new CheckBox();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialCard1.SuspendLayout();
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
            loadExcel.Location = new Point(438, 738);
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
            matrix.Location = new Point(17, 17);
            matrix.Name = "matrix";
            matrix.ReadOnly = true;
            matrix.Size = new Size(561, 587);
            matrix.TabIndex = 1;
            matrix.Text = "";
            // 
            // checkSubCarpetas
            // 
            checkSubCarpetas.AutoSize = true;
            checkSubCarpetas.Location = new Point(196, 316);
            checkSubCarpetas.Name = "checkSubCarpetas";
            checkSubCarpetas.Size = new Size(90, 19);
            checkSubCarpetas.TabIndex = 2;
            checkSubCarpetas.Text = "Subcarpetas";
            checkSubCarpetas.UseVisualStyleBackColor = true;
            checkSubCarpetas.CheckedChanged += checkSubCarpetas_CheckedChanged;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(matrix);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(1013, 137);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(595, 621);
            materialCard1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1715, 876);
            Controls.Add(checkSubCarpetas);
            Controls.Add(loadExcel);
            Controls.Add(materialCard1);
            Name = "Form1";
            Text = "Form1";
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton loadExcel;
        private RichTextBox matrix;
        private CheckBox checkSubCarpetas;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}
