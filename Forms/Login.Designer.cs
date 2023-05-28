namespace proiect.Forms
{
    partial class Login
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
            this.user_box = new MaterialSkin.Controls.MaterialTextBox();
            this.parola_box = new MaterialSkin.Controls.MaterialTextBox();
            this.LoginButton = new MaterialSkin.Controls.MaterialButton();
            this.CreateAccountButton = new MaterialSkin.Controls.MaterialButton();
            this.RememberCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.SuspendLayout();
            // 
            // user_box
            // 
            this.user_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_box.Depth = 0;
            this.user_box.Font = new System.Drawing.Font("Roboto", 12F);
            this.user_box.Hint = "Username";
            this.user_box.Location = new System.Drawing.Point(83, 125);
            this.user_box.MaxLength = 50;
            this.user_box.MouseState = MaterialSkin.MouseState.OUT;
            this.user_box.Multiline = false;
            this.user_box.Name = "user_box";
            this.user_box.Size = new System.Drawing.Size(323, 50);
            this.user_box.TabIndex = 3;
            this.user_box.Text = "";
            this.user_box.TextChanged += new System.EventHandler(this.user_box_TextChanged);
            // 
            // parola_box
            // 
            this.parola_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.parola_box.Depth = 0;
            this.parola_box.Font = new System.Drawing.Font("Roboto", 12F);
            this.parola_box.Hint = "Password";
            this.parola_box.Location = new System.Drawing.Point(83, 221);
            this.parola_box.MaxLength = 50;
            this.parola_box.MouseState = MaterialSkin.MouseState.OUT;
            this.parola_box.Multiline = false;
            this.parola_box.Name = "parola_box";
            this.parola_box.Password = true;
            this.parola_box.Size = new System.Drawing.Size(323, 50);
            this.parola_box.TabIndex = 4;
            this.parola_box.Text = "";
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = false;
            this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginButton.Depth = 0;
            this.LoginButton.DrawShadows = true;
            this.LoginButton.HighEmphasis = true;
            this.LoginButton.Icon = null;
            this.LoginButton.Location = new System.Drawing.Point(83, 370);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(322, 45);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Log In";
            this.LoginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LoginButton.UseAccentColor = false;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.AutoSize = false;
            this.CreateAccountButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateAccountButton.Depth = 0;
            this.CreateAccountButton.DrawShadows = true;
            this.CreateAccountButton.HighEmphasis = true;
            this.CreateAccountButton.Icon = null;
            this.CreateAccountButton.Location = new System.Drawing.Point(83, 441);
            this.CreateAccountButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreateAccountButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(322, 45);
            this.CreateAccountButton.TabIndex = 6;
            this.CreateAccountButton.Text = "Create an account";
            this.CreateAccountButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CreateAccountButton.UseAccentColor = false;
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // RememberCheckbox
            // 
            this.RememberCheckbox.AutoSize = true;
            this.RememberCheckbox.Depth = 0;
            this.RememberCheckbox.Location = new System.Drawing.Point(83, 303);
            this.RememberCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.RememberCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RememberCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.RememberCheckbox.Name = "RememberCheckbox";
            this.RememberCheckbox.Ripple = true;
            this.RememberCheckbox.Size = new System.Drawing.Size(137, 37);
            this.RememberCheckbox.TabIndex = 7;
            this.RememberCheckbox.Text = "Remember me";
            this.RememberCheckbox.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 543);
            this.Controls.Add(this.RememberCheckbox);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.parola_box);
            this.Controls.Add(this.user_box);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinica Life Med";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox user_box;
        private MaterialSkin.Controls.MaterialTextBox parola_box;
        private MaterialSkin.Controls.MaterialButton LoginButton;
        private MaterialSkin.Controls.MaterialButton CreateAccountButton;
        private MaterialSkin.Controls.MaterialCheckbox RememberCheckbox;
    }
}