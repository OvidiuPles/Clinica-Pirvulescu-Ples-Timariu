namespace proiect.Forms.Pop_ups
{
    partial class Doctor_Update
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
            this.PhoneTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.EmailTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.SpecializareTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.DescriereTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.UpdateButton1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneTextBox.Depth = 0;
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PhoneTextBox.Hint = "Nr. nou de telefon";
            this.PhoneTextBox.Location = new System.Drawing.Point(28, 98);
            this.PhoneTextBox.MaxLength = 50;
            this.PhoneTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PhoneTextBox.Multiline = false;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(188, 50);
            this.PhoneTextBox.TabIndex = 3;
            this.PhoneTextBox.Text = "";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTextBox.Depth = 0;
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EmailTextBox.Hint = "Email nou";
            this.EmailTextBox.Location = new System.Drawing.Point(28, 191);
            this.EmailTextBox.MaxLength = 50;
            this.EmailTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmailTextBox.Multiline = false;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(188, 50);
            this.EmailTextBox.TabIndex = 4;
            this.EmailTextBox.Text = "";
            // 
            // SpecializareTextBox
            // 
            this.SpecializareTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SpecializareTextBox.Depth = 0;
            this.SpecializareTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SpecializareTextBox.Hint = "Specializare*";
            this.SpecializareTextBox.Location = new System.Drawing.Point(28, 292);
            this.SpecializareTextBox.MaxLength = 50;
            this.SpecializareTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.SpecializareTextBox.Multiline = false;
            this.SpecializareTextBox.Name = "SpecializareTextBox";
            this.SpecializareTextBox.Size = new System.Drawing.Size(188, 50);
            this.SpecializareTextBox.TabIndex = 5;
            this.SpecializareTextBox.Text = "";
            // 
            // DescriereTextBox
            // 
            this.DescriereTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DescriereTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriereTextBox.Depth = 0;
            this.DescriereTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DescriereTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DescriereTextBox.Hint = "Descriere*";
            this.DescriereTextBox.Location = new System.Drawing.Point(342, 85);
            this.DescriereTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.DescriereTextBox.Name = "DescriereTextBox";
            this.DescriereTextBox.Size = new System.Drawing.Size(204, 201);
            this.DescriereTextBox.TabIndex = 6;
            this.DescriereTextBox.Text = "";
            // 
            // UpdateButton1
            // 
            this.UpdateButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateButton1.Depth = 0;
            this.UpdateButton1.DrawShadows = true;
            this.UpdateButton1.HighEmphasis = true;
            this.UpdateButton1.Icon = null;
            this.UpdateButton1.Location = new System.Drawing.Point(363, 317);
            this.UpdateButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateButton1.Name = "UpdateButton1";
            this.UpdateButton1.Size = new System.Drawing.Size(90, 36);
            this.UpdateButton1.TabIndex = 7;
            this.UpdateButton1.Text = "Modifica";
            this.UpdateButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpdateButton1.UseAccentColor = false;
            this.UpdateButton1.UseVisualStyleBackColor = true;
            this.UpdateButton1.Click += new System.EventHandler(this.UpdateButton1_Click);
            // 
            // Doctor_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 368);
            this.Controls.Add(this.UpdateButton1);
            this.Controls.Add(this.DescriereTextBox);
            this.Controls.Add(this.SpecializareTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Name = "Doctor_Update";
            this.Text = "Modifica Datele";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox PhoneTextBox;
        private MaterialSkin.Controls.MaterialTextBox EmailTextBox;
        private MaterialSkin.Controls.MaterialTextBox SpecializareTextBox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox DescriereTextBox;
        private MaterialSkin.Controls.MaterialButton UpdateButton1;
    }
}