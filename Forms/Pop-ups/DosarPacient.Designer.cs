namespace proiect.Forms.Info
{
    partial class DosarPacient
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AfectiuniListView = new MaterialSkin.Controls.MaterialListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label_cnp = new MaterialSkin.Controls.MaterialLabel();
            this.label_email = new MaterialSkin.Controls.MaterialLabel();
            this.label_telefon = new MaterialSkin.Controls.MaterialLabel();
            this.label_sex = new MaterialSkin.Controls.MaterialLabel();
            this.label_prenume = new MaterialSkin.Controls.MaterialLabel();
            this.label_nume = new MaterialSkin.Controls.MaterialLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard8 = new MaterialSkin.Controls.MaterialCard();
            this.CloseButton = new MaterialSkin.Controls.MaterialButton();
            this.RetetaButton = new MaterialSkin.Controls.MaterialButton();
            this.DeleteButton = new MaterialSkin.Controls.MaterialButton();
            this.CloseButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(752, 617);
            this.materialTabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CloseButton2);
            this.tabPage1.Controls.Add(this.DeleteButton);
            this.tabPage1.Controls.Add(this.RetetaButton);
            this.tabPage1.Controls.Add(this.AfectiuniListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Afectiuni";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AfectiuniListView
            // 
            this.AfectiuniListView.AutoSizeTable = false;
            this.AfectiuniListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AfectiuniListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AfectiuniListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume});
            this.AfectiuniListView.Depth = 0;
            this.AfectiuniListView.FullRowSelect = true;
            this.AfectiuniListView.HideSelection = false;
            this.AfectiuniListView.Location = new System.Drawing.Point(51, 44);
            this.AfectiuniListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.AfectiuniListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AfectiuniListView.MouseState = MaterialSkin.MouseState.OUT;
            this.AfectiuniListView.Name = "AfectiuniListView";
            this.AfectiuniListView.OwnerDraw = true;
            this.AfectiuniListView.Size = new System.Drawing.Size(365, 453);
            this.AfectiuniListView.TabIndex = 0;
            this.AfectiuniListView.UseCompatibleStateImageBehavior = false;
            this.AfectiuniListView.View = System.Windows.Forms.View.Details;
            // 
            // Nume
            // 
            this.Nume.Text = "Afectiuni";
            this.Nume.Width = 250;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialCard1);
            this.tabPage2.Controls.Add(this.CloseButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(744, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Date personale";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label_cnp);
            this.materialCard1.Controls.Add(this.label_email);
            this.materialCard1.Controls.Add(this.label_telefon);
            this.materialCard1.Controls.Add(this.label_sex);
            this.materialCard1.Controls.Add(this.label_prenume);
            this.materialCard1.Controls.Add(this.label_nume);
            this.materialCard1.Controls.Add(this.kryptonLabel7);
            this.materialCard1.Controls.Add(this.kryptonLabel8);
            this.materialCard1.Controls.Add(this.kryptonLabel9);
            this.materialCard1.Controls.Add(this.kryptonLabel10);
            this.materialCard1.Controls.Add(this.kryptonLabel11);
            this.materialCard1.Controls.Add(this.kryptonLabel12);
            this.materialCard1.Controls.Add(this.materialCard3);
            this.materialCard1.Controls.Add(this.materialCard4);
            this.materialCard1.Controls.Add(this.materialCard5);
            this.materialCard1.Controls.Add(this.materialCard6);
            this.materialCard1.Controls.Add(this.materialCard7);
            this.materialCard1.Controls.Add(this.materialCard8);
            this.materialCard1.Depth = 0;
            this.materialCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(99, 37);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(546, 398);
            this.materialCard1.TabIndex = 4;
            // 
            // label_cnp
            // 
            this.label_cnp.AutoSize = true;
            this.label_cnp.Depth = 0;
            this.label_cnp.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_cnp.Location = new System.Drawing.Point(238, 148);
            this.label_cnp.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_cnp.Name = "label_cnp";
            this.label_cnp.Size = new System.Drawing.Size(118, 19);
            this.label_cnp.TabIndex = 8;
            this.label_cnp.Text = "5010409255692";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Depth = 0;
            this.label_email.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_email.Location = new System.Drawing.Point(235, 329);
            this.label_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(180, 19);
            this.label_email.TabIndex = 7;
            this.label_email.Text = "mariusflorin@yahoo.com";
            // 
            // label_telefon
            // 
            this.label_telefon.AutoSize = true;
            this.label_telefon.Depth = 0;
            this.label_telefon.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_telefon.Location = new System.Drawing.Point(235, 270);
            this.label_telefon.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_telefon.Name = "label_telefon";
            this.label_telefon.Size = new System.Drawing.Size(91, 19);
            this.label_telefon.TabIndex = 7;
            this.label_telefon.Text = "0752543643";
            // 
            // label_sex
            // 
            this.label_sex.AutoSize = true;
            this.label_sex.Depth = 0;
            this.label_sex.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_sex.Location = new System.Drawing.Point(238, 206);
            this.label_sex.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_sex.Name = "label_sex";
            this.label_sex.Size = new System.Drawing.Size(27, 19);
            this.label_sex.TabIndex = 7;
            this.label_sex.Text = "text";
            // 
            // label_prenume
            // 
            this.label_prenume.AutoSize = true;
            this.label_prenume.Depth = 0;
            this.label_prenume.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_prenume.Location = new System.Drawing.Point(235, 91);
            this.label_prenume.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_prenume.Name = "label_prenume";
            this.label_prenume.Size = new System.Drawing.Size(94, 19);
            this.label_prenume.TabIndex = 7;
            this.label_prenume.Text = "Marius Florin";
            // 
            // label_nume
            // 
            this.label_nume.AutoSize = true;
            this.label_nume.Depth = 0;
            this.label_nume.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_nume.Location = new System.Drawing.Point(235, 41);
            this.label_nume.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_nume.Name = "label_nume";
            this.label_nume.Size = new System.Drawing.Size(50, 19);
            this.label_nume.TabIndex = 6;
            this.label_nume.Text = "Marius";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel7.Location = new System.Drawing.Point(39, 319);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(82, 31);
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.LightGray;
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 5;
            this.kryptonLabel7.Values.Text = "E-mail";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel8.Location = new System.Drawing.Point(39, 258);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(93, 31);
            this.kryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.LightGray;
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 5;
            this.kryptonLabel8.Values.Text = "Telefon";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel9.Location = new System.Drawing.Point(39, 197);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(55, 31);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.LightGray;
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 5;
            this.kryptonLabel9.Values.Text = "Sex";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel10.Location = new System.Drawing.Point(39, 139);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(84, 31);
            this.kryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.LightGray;
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 5;
            this.kryptonLabel10.Values.Text = "C.N.P.";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel11.Location = new System.Drawing.Point(39, 80);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(110, 31);
            this.kryptonLabel11.StateCommon.ShortText.Color1 = System.Drawing.Color.LightGray;
            this.kryptonLabel11.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel11.TabIndex = 5;
            this.kryptonLabel11.Values.Text = "Prenume";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel12.Location = new System.Drawing.Point(39, 29);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(77, 31);
            this.kryptonLabel12.StateCommon.ShortText.Color1 = System.Drawing.Color.LightGray;
            this.kryptonLabel12.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel12.TabIndex = 5;
            this.kryptonLabel12.Values.Text = "Nume";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(226, 319);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(291, 40);
            this.materialCard3.TabIndex = 9;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(226, 258);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(291, 40);
            this.materialCard4.TabIndex = 9;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(226, 197);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(291, 40);
            this.materialCard5.TabIndex = 9;
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(226, 139);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(291, 40);
            this.materialCard6.TabIndex = 9;
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(226, 80);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(291, 40);
            this.materialCard7.TabIndex = 9;
            // 
            // materialCard8
            // 
            this.materialCard8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard8.Depth = 0;
            this.materialCard8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard8.Location = new System.Drawing.Point(226, 29);
            this.materialCard8.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard8.Name = "materialCard8";
            this.materialCard8.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard8.Size = new System.Drawing.Size(291, 40);
            this.materialCard8.TabIndex = 9;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = false;
            this.CloseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseButton.Depth = 0;
            this.CloseButton.DrawShadows = true;
            this.CloseButton.HighEmphasis = true;
            this.CloseButton.Icon = null;
            this.CloseButton.Location = new System.Drawing.Point(245, 468);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CloseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(259, 40);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Inchide";
            this.CloseButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CloseButton.UseAccentColor = false;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RetetaButton
            // 
            this.RetetaButton.AutoSize = false;
            this.RetetaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RetetaButton.Depth = 0;
            this.RetetaButton.DrawShadows = true;
            this.RetetaButton.HighEmphasis = true;
            this.RetetaButton.Icon = null;
            this.RetetaButton.Location = new System.Drawing.Point(468, 114);
            this.RetetaButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RetetaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RetetaButton.Name = "RetetaButton";
            this.RetetaButton.Size = new System.Drawing.Size(228, 45);
            this.RetetaButton.TabIndex = 1;
            this.RetetaButton.Text = "Vezi reteta";
            this.RetetaButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RetetaButton.UseAccentColor = false;
            this.RetetaButton.UseVisualStyleBackColor = true;
            this.RetetaButton.Click += new System.EventHandler(this.RetetaButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = false;
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Depth = 0;
            this.DeleteButton.DrawShadows = true;
            this.DeleteButton.HighEmphasis = true;
            this.DeleteButton.Icon = null;
            this.DeleteButton.Location = new System.Drawing.Point(468, 224);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(228, 45);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "sterge afectiune";
            this.DeleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteButton.UseAccentColor = false;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CloseButton2
            // 
            this.CloseButton2.AutoSize = false;
            this.CloseButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseButton2.Depth = 0;
            this.CloseButton2.DrawShadows = true;
            this.CloseButton2.HighEmphasis = true;
            this.CloseButton2.Icon = null;
            this.CloseButton2.Location = new System.Drawing.Point(468, 330);
            this.CloseButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CloseButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseButton2.Name = "CloseButton2";
            this.CloseButton2.Size = new System.Drawing.Size(228, 45);
            this.CloseButton2.TabIndex = 3;
            this.CloseButton2.Text = "Inchide";
            this.CloseButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CloseButton2.UseAccentColor = false;
            this.CloseButton2.UseVisualStyleBackColor = true;
            this.CloseButton2.Click += new System.EventHandler(this.CloseButton2_Click);
            // 
            // DosarPacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 617);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "DosarPacient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDetails";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel label_cnp;
        private MaterialSkin.Controls.MaterialLabel label_email;
        private MaterialSkin.Controls.MaterialLabel label_telefon;
        private MaterialSkin.Controls.MaterialLabel label_sex;
        private MaterialSkin.Controls.MaterialLabel label_prenume;
        private MaterialSkin.Controls.MaterialLabel label_nume;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private MaterialSkin.Controls.MaterialButton CloseButton;
        private MaterialSkin.Controls.MaterialListView AfectiuniListView;
        private System.Windows.Forms.ColumnHeader Nume;
        private MaterialSkin.Controls.MaterialButton RetetaButton;
        private MaterialSkin.Controls.MaterialButton DeleteButton;
        private MaterialSkin.Controls.MaterialButton CloseButton2;
    }
}