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
            textBoxData = new MaterialSkin.Controls.MaterialMultiLineTextBox();
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
            loadExcel.Location = new Point(756, 668);
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
            // textBoxData
            // 
            textBoxData.BackColor = Color.FromArgb(255, 255, 255);
            textBoxData.BorderStyle = BorderStyle.None;
            textBoxData.Depth = 0;
            textBoxData.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxData.ForeColor = Color.FromArgb(222, 0, 0, 0);
            textBoxData.Location = new Point(282, 73);
            textBoxData.MouseState = MaterialSkin.MouseState.HOVER;
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(1099, 510);
            textBoxData.TabIndex = 1;
            textBoxData.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1715, 876);
            Controls.Add(textBoxData);
            Controls.Add(loadExcel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton loadExcel;
        private MaterialSkin.Controls.MaterialMultiLineTextBox textBoxData;
    }
}
