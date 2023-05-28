namespace proiect.Forms.Pop_ups
{
    partial class Reteta
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
            this.label_doctor = new System.Windows.Forms.Label();
            this.RetetaMultiLineTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.ExitButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label_doctor
            // 
            this.label_doctor.AutoSize = true;
            this.label_doctor.Location = new System.Drawing.Point(34, 105);
            this.label_doctor.Name = "label_doctor";
            this.label_doctor.Size = new System.Drawing.Size(44, 16);
            this.label_doctor.TabIndex = 0;
            this.label_doctor.Text = "label1";
            // 
            // RetetaMultiLineTextBox
            // 
            this.RetetaMultiLineTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RetetaMultiLineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RetetaMultiLineTextBox.Depth = 0;
            this.RetetaMultiLineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RetetaMultiLineTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RetetaMultiLineTextBox.Hint = "";
            this.RetetaMultiLineTextBox.Location = new System.Drawing.Point(37, 157);
            this.RetetaMultiLineTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.RetetaMultiLineTextBox.Name = "RetetaMultiLineTextBox";
            this.RetetaMultiLineTextBox.ReadOnly = true;
            this.RetetaMultiLineTextBox.Size = new System.Drawing.Size(400, 270);
            this.RetetaMultiLineTextBox.TabIndex = 1;
            this.RetetaMultiLineTextBox.Text = "";
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = false;
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.Depth = 0;
            this.ExitButton.DrawShadows = true;
            this.ExitButton.HighEmphasis = true;
            this.ExitButton.Icon = null;
            this.ExitButton.Location = new System.Drawing.Point(130, 455);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(190, 40);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Inchide";
            this.ExitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ExitButton.UseAccentColor = false;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Reteta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 523);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RetetaMultiLineTextBox);
            this.Controls.Add(this.label_doctor);
            this.Name = "Reteta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reteta";
            this.Load += new System.EventHandler(this.Reteta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_doctor;
        private MaterialSkin.Controls.MaterialMultiLineTextBox RetetaMultiLineTextBox;
        private MaterialSkin.Controls.MaterialButton ExitButton;
    }
}