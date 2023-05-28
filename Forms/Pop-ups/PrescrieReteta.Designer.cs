namespace proiect.Forms.Pop_ups
{
    partial class PrescrieReteta
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
            this.AfectiuniTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.RetetaMultiLineTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.TrimiteButton = new MaterialSkin.Controls.MaterialButton();
            this.InchideButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // AfectiuniTextBox
            // 
            this.AfectiuniTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AfectiuniTextBox.Depth = 0;
            this.AfectiuniTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.AfectiuniTextBox.Hint = "Afectiune";
            this.AfectiuniTextBox.Location = new System.Drawing.Point(41, 111);
            this.AfectiuniTextBox.MaxLength = 50;
            this.AfectiuniTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.AfectiuniTextBox.Multiline = false;
            this.AfectiuniTextBox.Name = "AfectiuniTextBox";
            this.AfectiuniTextBox.Size = new System.Drawing.Size(521, 50);
            this.AfectiuniTextBox.TabIndex = 0;
            this.AfectiuniTextBox.Text = "";
            // 
            // RetetaMultiLineTextBox
            // 
            this.RetetaMultiLineTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RetetaMultiLineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RetetaMultiLineTextBox.Depth = 0;
            this.RetetaMultiLineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RetetaMultiLineTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RetetaMultiLineTextBox.Hint = "Reteta";
            this.RetetaMultiLineTextBox.Location = new System.Drawing.Point(41, 215);
            this.RetetaMultiLineTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.RetetaMultiLineTextBox.Name = "RetetaMultiLineTextBox";
            this.RetetaMultiLineTextBox.Size = new System.Drawing.Size(521, 354);
            this.RetetaMultiLineTextBox.TabIndex = 1;
            this.RetetaMultiLineTextBox.Text = "";
            // 
            // TrimiteButton
            // 
            this.TrimiteButton.AutoSize = false;
            this.TrimiteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TrimiteButton.Depth = 0;
            this.TrimiteButton.DrawShadows = true;
            this.TrimiteButton.HighEmphasis = true;
            this.TrimiteButton.Icon = null;
            this.TrimiteButton.Location = new System.Drawing.Point(313, 611);
            this.TrimiteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TrimiteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.TrimiteButton.Name = "TrimiteButton";
            this.TrimiteButton.Size = new System.Drawing.Size(249, 45);
            this.TrimiteButton.TabIndex = 2;
            this.TrimiteButton.Text = "Trimite reteta";
            this.TrimiteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.TrimiteButton.UseAccentColor = false;
            this.TrimiteButton.UseVisualStyleBackColor = true;
            this.TrimiteButton.Click += new System.EventHandler(this.TrimiteButton_Click);
            // 
            // InchideButton
            // 
            this.InchideButton.AutoSize = false;
            this.InchideButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InchideButton.Depth = 0;
            this.InchideButton.DrawShadows = true;
            this.InchideButton.HighEmphasis = true;
            this.InchideButton.Icon = null;
            this.InchideButton.Location = new System.Drawing.Point(41, 611);
            this.InchideButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.InchideButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.InchideButton.Name = "InchideButton";
            this.InchideButton.Size = new System.Drawing.Size(244, 45);
            this.InchideButton.TabIndex = 2;
            this.InchideButton.Text = "Inchide";
            this.InchideButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.InchideButton.UseAccentColor = false;
            this.InchideButton.UseVisualStyleBackColor = true;
            this.InchideButton.Click += new System.EventHandler(this.InchideButton_Click);
            // 
            // PrescrieReteta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 689);
            this.Controls.Add(this.InchideButton);
            this.Controls.Add(this.TrimiteButton);
            this.Controls.Add(this.RetetaMultiLineTextBox);
            this.Controls.Add(this.AfectiuniTextBox);
            this.Name = "PrescrieReteta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrescrieReteta";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox AfectiuniTextBox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox RetetaMultiLineTextBox;
        private MaterialSkin.Controls.MaterialButton TrimiteButton;
        private MaterialSkin.Controls.MaterialButton InchideButton;
    }
}