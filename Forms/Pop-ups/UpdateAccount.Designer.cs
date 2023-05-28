namespace proiect.Forms
{
    partial class UpdateAccount
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
            this.UsernameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.PasswordTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.ExitButton = new MaterialSkin.Controls.MaterialButton();
            this.UpdateButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneTextBox.Depth = 0;
            this.PhoneTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.PhoneTextBox.Hint = "Nr. nou de telefon";
            this.PhoneTextBox.Location = new System.Drawing.Point(47, 105);
            this.PhoneTextBox.MaxLength = 50;
            this.PhoneTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PhoneTextBox.Multiline = false;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(227, 50);
            this.PhoneTextBox.TabIndex = 0;
            this.PhoneTextBox.Text = "";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTextBox.Depth = 0;
            this.EmailTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.EmailTextBox.Hint = "Email nou";
            this.EmailTextBox.Location = new System.Drawing.Point(47, 195);
            this.EmailTextBox.MaxLength = 50;
            this.EmailTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmailTextBox.Multiline = false;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(227, 50);
            this.EmailTextBox.TabIndex = 1;
            this.EmailTextBox.Text = "";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBox.Depth = 0;
            this.UsernameTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.UsernameTextBox.Hint = "Username nou";
            this.UsernameTextBox.Location = new System.Drawing.Point(339, 105);
            this.UsernameTextBox.MaxLength = 50;
            this.UsernameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.UsernameTextBox.Multiline = false;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(227, 50);
            this.UsernameTextBox.TabIndex = 0;
            this.UsernameTextBox.Text = "";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Depth = 0;
            this.PasswordTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.PasswordTextBox.Hint = "Parola noua";
            this.PasswordTextBox.Location = new System.Drawing.Point(339, 195);
            this.PasswordTextBox.MaxLength = 50;
            this.PasswordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PasswordTextBox.Multiline = false;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(227, 50);
            this.PasswordTextBox.TabIndex = 0;
            this.PasswordTextBox.Text = "";
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = false;
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.Depth = 0;
            this.ExitButton.DrawShadows = true;
            this.ExitButton.HighEmphasis = true;
            this.ExitButton.Icon = null;
            this.ExitButton.Location = new System.Drawing.Point(47, 291);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(227, 45);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ExitButton.UseAccentColor = false;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.AutoSize = false;
            this.UpdateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateButton.Depth = 0;
            this.UpdateButton.DrawShadows = true;
            this.UpdateButton.HighEmphasis = true;
            this.UpdateButton.Icon = null;
            this.UpdateButton.Location = new System.Drawing.Point(339, 291);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(227, 45);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Modifica date";
            this.UpdateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpdateButton.UseAccentColor = false;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 382);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Name = "UpdateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifica datele";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox PhoneTextBox;
        private MaterialSkin.Controls.MaterialTextBox EmailTextBox;
        private MaterialSkin.Controls.MaterialTextBox UsernameTextBox;
        private MaterialSkin.Controls.MaterialTextBox PasswordTextBox;
        private MaterialSkin.Controls.MaterialButton ExitButton;
        private MaterialSkin.Controls.MaterialButton UpdateButton;
    }
}