namespace proiect.Forms
{
    partial class CreateAccount
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.SexComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.createAcc_button = new MaterialSkin.Controls.MaterialButton();
            this.ExitButton = new MaterialSkin.Controls.MaterialButton();
            this.textBox_prenume = new MaterialSkin.Controls.MaterialTextBox();
            this.textBox_email = new MaterialSkin.Controls.MaterialTextBox();
            this.textBox_parola = new MaterialSkin.Controls.MaterialTextBox();
            this.textBox_user = new MaterialSkin.Controls.MaterialTextBox();
            this.textBox_telefon = new MaterialSkin.Controls.MaterialTextBox();
            this.textBox_cnp = new MaterialSkin.Controls.MaterialTextBox();
            this.textBox_nume = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectDoctor = new MaterialSkin.Controls.MaterialRadioButton();
            this.selectPacient = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.SexComboBox);
            this.materialCard1.Controls.Add(this.createAcc_button);
            this.materialCard1.Controls.Add(this.ExitButton);
            this.materialCard1.Controls.Add(this.textBox_prenume);
            this.materialCard1.Controls.Add(this.textBox_email);
            this.materialCard1.Controls.Add(this.textBox_parola);
            this.materialCard1.Controls.Add(this.textBox_user);
            this.materialCard1.Controls.Add(this.textBox_telefon);
            this.materialCard1.Controls.Add(this.textBox_cnp);
            this.materialCard1.Controls.Add(this.textBox_nume);
            this.materialCard1.Controls.Add(this.groupBox1);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 99);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(756, 621);
            this.materialCard1.TabIndex = 0;
            // 
            // SexComboBox
            // 
            this.SexComboBox.AutoResize = false;
            this.SexComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SexComboBox.Depth = 0;
            this.SexComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SexComboBox.DropDownHeight = 174;
            this.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexComboBox.DropDownWidth = 121;
            this.SexComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SexComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Hint = "Sex";
            this.SexComboBox.IntegralHeight = false;
            this.SexComboBox.ItemHeight = 43;
            this.SexComboBox.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.SexComboBox.Location = new System.Drawing.Point(395, 263);
            this.SexComboBox.MaxDropDownItems = 4;
            this.SexComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(343, 49);
            this.SexComboBox.TabIndex = 6;
            // 
            // createAcc_button
            // 
            this.createAcc_button.AutoSize = false;
            this.createAcc_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createAcc_button.Depth = 0;
            this.createAcc_button.DrawShadows = true;
            this.createAcc_button.HighEmphasis = true;
            this.createAcc_button.Icon = null;
            this.createAcc_button.Location = new System.Drawing.Point(395, 536);
            this.createAcc_button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createAcc_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.createAcc_button.Name = "createAcc_button";
            this.createAcc_button.Size = new System.Drawing.Size(343, 45);
            this.createAcc_button.TabIndex = 4;
            this.createAcc_button.Text = "Create account";
            this.createAcc_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createAcc_button.UseAccentColor = false;
            this.createAcc_button.UseVisualStyleBackColor = true;
            this.createAcc_button.Click += new System.EventHandler(this.createAcc_button_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = false;
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.Depth = 0;
            this.ExitButton.DrawShadows = true;
            this.ExitButton.HighEmphasis = true;
            this.ExitButton.Icon = null;
            this.ExitButton.Location = new System.Drawing.Point(17, 536);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(343, 45);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ExitButton.UseAccentColor = false;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // textBox_prenume
            // 
            this.textBox_prenume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_prenume.Depth = 0;
            this.textBox_prenume.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBox_prenume.Hint = "Prenume";
            this.textBox_prenume.Location = new System.Drawing.Point(395, 186);
            this.textBox_prenume.MaxLength = 20;
            this.textBox_prenume.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox_prenume.Multiline = false;
            this.textBox_prenume.Name = "textBox_prenume";
            this.textBox_prenume.Size = new System.Drawing.Size(343, 50);
            this.textBox_prenume.TabIndex = 2;
            this.textBox_prenume.Text = "";
            // 
            // textBox_email
            // 
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_email.Depth = 0;
            this.textBox_email.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBox_email.Hint = "E-mail";
            this.textBox_email.Location = new System.Drawing.Point(395, 350);
            this.textBox_email.MaxLength = 40;
            this.textBox_email.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox_email.Multiline = false;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(343, 50);
            this.textBox_email.TabIndex = 2;
            this.textBox_email.Text = "";
            // 
            // textBox_parola
            // 
            this.textBox_parola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_parola.Depth = 0;
            this.textBox_parola.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBox_parola.Hint = "Parola";
            this.textBox_parola.Location = new System.Drawing.Point(395, 436);
            this.textBox_parola.MaxLength = 50;
            this.textBox_parola.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox_parola.Multiline = false;
            this.textBox_parola.Name = "textBox_parola";
            this.textBox_parola.Size = new System.Drawing.Size(343, 50);
            this.textBox_parola.TabIndex = 2;
            this.textBox_parola.Text = "";
            // 
            // textBox_user
            // 
            this.textBox_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_user.Depth = 0;
            this.textBox_user.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBox_user.Hint = "Username";
            this.textBox_user.Location = new System.Drawing.Point(20, 436);
            this.textBox_user.MaxLength = 50;
            this.textBox_user.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox_user.Multiline = false;
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(343, 50);
            this.textBox_user.TabIndex = 2;
            this.textBox_user.Text = "";
            // 
            // textBox_telefon
            // 
            this.textBox_telefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_telefon.Depth = 0;
            this.textBox_telefon.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBox_telefon.Hint = "Numar de telefon";
            this.textBox_telefon.Location = new System.Drawing.Point(17, 350);
            this.textBox_telefon.MaxLength = 10;
            this.textBox_telefon.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox_telefon.Multiline = false;
            this.textBox_telefon.Name = "textBox_telefon";
            this.textBox_telefon.Size = new System.Drawing.Size(343, 50);
            this.textBox_telefon.TabIndex = 2;
            this.textBox_telefon.Text = "";
            // 
            // textBox_cnp
            // 
            this.textBox_cnp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_cnp.Depth = 0;
            this.textBox_cnp.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBox_cnp.Hint = "C.N.P.";
            this.textBox_cnp.Location = new System.Drawing.Point(20, 263);
            this.textBox_cnp.MaxLength = 13;
            this.textBox_cnp.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox_cnp.Multiline = false;
            this.textBox_cnp.Name = "textBox_cnp";
            this.textBox_cnp.Size = new System.Drawing.Size(343, 50);
            this.textBox_cnp.TabIndex = 2;
            this.textBox_cnp.Text = "";
            // 
            // textBox_nume
            // 
            this.textBox_nume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_nume.Depth = 0;
            this.textBox_nume.Font = new System.Drawing.Font("Roboto", 12F);
            this.textBox_nume.Hint = "Nume";
            this.textBox_nume.Location = new System.Drawing.Point(20, 186);
            this.textBox_nume.MaxLength = 20;
            this.textBox_nume.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox_nume.Multiline = false;
            this.textBox_nume.Name = "textBox_nume";
            this.textBox_nume.Size = new System.Drawing.Size(340, 50);
            this.textBox_nume.TabIndex = 2;
            this.textBox_nume.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectDoctor);
            this.groupBox1.Controls.Add(this.selectPacient);
            this.groupBox1.Location = new System.Drawing.Point(20, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipul contului";
            // 
            // selectDoctor
            // 
            this.selectDoctor.AutoSize = true;
            this.selectDoctor.Depth = 0;
            this.selectDoctor.Location = new System.Drawing.Point(507, 27);
            this.selectDoctor.Margin = new System.Windows.Forms.Padding(0);
            this.selectDoctor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.selectDoctor.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectDoctor.Name = "selectDoctor";
            this.selectDoctor.Ripple = true;
            this.selectDoctor.Size = new System.Drawing.Size(82, 37);
            this.selectDoctor.TabIndex = 1;
            this.selectDoctor.TabStop = true;
            this.selectDoctor.Text = "Doctor";
            this.selectDoctor.UseVisualStyleBackColor = true;
            // 
            // selectPacient
            // 
            this.selectPacient.AutoSize = true;
            this.selectPacient.Depth = 0;
            this.selectPacient.Location = new System.Drawing.Point(76, 27);
            this.selectPacient.Margin = new System.Windows.Forms.Padding(0);
            this.selectPacient.MouseLocation = new System.Drawing.Point(-1, -1);
            this.selectPacient.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectPacient.Name = "selectPacient";
            this.selectPacient.Ripple = true;
            this.selectPacient.Size = new System.Drawing.Size(88, 37);
            this.selectPacient.TabIndex = 0;
            this.selectPacient.TabStop = true;
            this.selectPacient.Text = "Pacient";
            this.selectPacient.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(219, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Completati cu datele personale";
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 736);
            this.Controls.Add(this.materialCard1);
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create new account";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton selectPacient;
        private MaterialSkin.Controls.MaterialRadioButton selectDoctor;
        private MaterialSkin.Controls.MaterialTextBox textBox_nume;
        private MaterialSkin.Controls.MaterialTextBox textBox_telefon;
        private MaterialSkin.Controls.MaterialTextBox textBox_cnp;
        private MaterialSkin.Controls.MaterialTextBox textBox_prenume;
        private MaterialSkin.Controls.MaterialTextBox textBox_email;
        private MaterialSkin.Controls.MaterialTextBox textBox_parola;
        private MaterialSkin.Controls.MaterialTextBox textBox_user;
        private MaterialSkin.Controls.MaterialButton ExitButton;
        private MaterialSkin.Controls.MaterialButton createAcc_button;
        private MaterialSkin.Controls.MaterialComboBox SexComboBox;
    }
}