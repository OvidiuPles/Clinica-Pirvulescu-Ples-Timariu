namespace proiect.Forms
{
    partial class MedicPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicPage));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.StergePacientButton = new MaterialSkin.Controls.MaterialButton();
            this.VeziProgramariButton = new MaterialSkin.Controls.MaterialButton();
            this.DetaliiPacientButton = new MaterialSkin.Controls.MaterialButton();
            this.ProgramareNouaButton = new MaterialSkin.Controls.MaterialButton();
            this.PrescrieRetetaButton = new MaterialSkin.Controls.MaterialButton();
            this.ListViewPacienti = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ProgrameazaButton = new MaterialSkin.Controls.MaterialButton();
            this.TimePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.Calendar = new ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar();
            this.SimptomeMultiLineTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.PacientiListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RefreshButton = new MaterialSkin.Controls.MaterialButton();
            this.update_button = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.descriere_materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.specializare_materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.LogoutButton1 = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(945, 610);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.StergePacientButton);
            this.tabPage1.Controls.Add(this.VeziProgramariButton);
            this.tabPage1.Controls.Add(this.DetaliiPacientButton);
            this.tabPage1.Controls.Add(this.ProgramareNouaButton);
            this.tabPage1.Controls.Add(this.PrescrieRetetaButton);
            this.tabPage1.Controls.Add(this.ListViewPacienti);
            this.tabPage1.ImageKey = "icons8-fever-48.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(937, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pacienti";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // StergePacientButton
            // 
            this.StergePacientButton.AutoSize = false;
            this.StergePacientButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StergePacientButton.Depth = 0;
            this.StergePacientButton.DrawShadows = true;
            this.StergePacientButton.HighEmphasis = true;
            this.StergePacientButton.Icon = null;
            this.StergePacientButton.Location = new System.Drawing.Point(524, 417);
            this.StergePacientButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StergePacientButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StergePacientButton.Name = "StergePacientButton";
            this.StergePacientButton.Size = new System.Drawing.Size(242, 45);
            this.StergePacientButton.TabIndex = 3;
            this.StergePacientButton.Text = "Sterge pacient";
            this.StergePacientButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StergePacientButton.UseAccentColor = false;
            this.StergePacientButton.UseVisualStyleBackColor = true;
            this.StergePacientButton.Click += new System.EventHandler(this.StergePacientButton_Click);
            // 
            // VeziProgramariButton
            // 
            this.VeziProgramariButton.AutoSize = false;
            this.VeziProgramariButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VeziProgramariButton.Depth = 0;
            this.VeziProgramariButton.DrawShadows = true;
            this.VeziProgramariButton.HighEmphasis = true;
            this.VeziProgramariButton.Icon = null;
            this.VeziProgramariButton.Location = new System.Drawing.Point(524, 327);
            this.VeziProgramariButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.VeziProgramariButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.VeziProgramariButton.Name = "VeziProgramariButton";
            this.VeziProgramariButton.Size = new System.Drawing.Size(242, 45);
            this.VeziProgramariButton.TabIndex = 2;
            this.VeziProgramariButton.Text = "Vezi programari";
            this.VeziProgramariButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.VeziProgramariButton.UseAccentColor = false;
            this.VeziProgramariButton.UseVisualStyleBackColor = true;
            this.VeziProgramariButton.Click += new System.EventHandler(this.VeziProgramariButton_Click);
            // 
            // DetaliiPacientButton
            // 
            this.DetaliiPacientButton.AutoSize = false;
            this.DetaliiPacientButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DetaliiPacientButton.Depth = 0;
            this.DetaliiPacientButton.DrawShadows = true;
            this.DetaliiPacientButton.HighEmphasis = true;
            this.DetaliiPacientButton.Icon = null;
            this.DetaliiPacientButton.Location = new System.Drawing.Point(524, 54);
            this.DetaliiPacientButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DetaliiPacientButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DetaliiPacientButton.Name = "DetaliiPacientButton";
            this.DetaliiPacientButton.Size = new System.Drawing.Size(242, 45);
            this.DetaliiPacientButton.TabIndex = 1;
            this.DetaliiPacientButton.Text = "Dosar pacient";
            this.DetaliiPacientButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DetaliiPacientButton.UseAccentColor = false;
            this.DetaliiPacientButton.UseVisualStyleBackColor = true;
            this.DetaliiPacientButton.Click += new System.EventHandler(this.DetaliiPacientButton_Click);
            // 
            // ProgramareNouaButton
            // 
            this.ProgramareNouaButton.AutoSize = false;
            this.ProgramareNouaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProgramareNouaButton.Depth = 0;
            this.ProgramareNouaButton.DrawShadows = true;
            this.ProgramareNouaButton.HighEmphasis = true;
            this.ProgramareNouaButton.Icon = null;
            this.ProgramareNouaButton.Location = new System.Drawing.Point(524, 237);
            this.ProgramareNouaButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ProgramareNouaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProgramareNouaButton.Name = "ProgramareNouaButton";
            this.ProgramareNouaButton.Size = new System.Drawing.Size(242, 45);
            this.ProgramareNouaButton.TabIndex = 1;
            this.ProgramareNouaButton.Text = "Programeaza pacient";
            this.ProgramareNouaButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ProgramareNouaButton.UseAccentColor = false;
            this.ProgramareNouaButton.UseVisualStyleBackColor = true;
            this.ProgramareNouaButton.Click += new System.EventHandler(this.ProgramareNouaButton_Click);
            // 
            // PrescrieRetetaButton
            // 
            this.PrescrieRetetaButton.AutoSize = false;
            this.PrescrieRetetaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrescrieRetetaButton.Depth = 0;
            this.PrescrieRetetaButton.DrawShadows = true;
            this.PrescrieRetetaButton.HighEmphasis = true;
            this.PrescrieRetetaButton.Icon = null;
            this.PrescrieRetetaButton.Location = new System.Drawing.Point(524, 145);
            this.PrescrieRetetaButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PrescrieRetetaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PrescrieRetetaButton.Name = "PrescrieRetetaButton";
            this.PrescrieRetetaButton.Size = new System.Drawing.Size(242, 45);
            this.PrescrieRetetaButton.TabIndex = 1;
            this.PrescrieRetetaButton.Text = "Prescrie reteta";
            this.PrescrieRetetaButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PrescrieRetetaButton.UseAccentColor = false;
            this.PrescrieRetetaButton.UseVisualStyleBackColor = true;
            this.PrescrieRetetaButton.Click += new System.EventHandler(this.PrescrieRetetaButton_Click);
            // 
            // ListViewPacienti
            // 
            this.ListViewPacienti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListViewPacienti.AutoSizeTable = false;
            this.ListViewPacienti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListViewPacienti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewPacienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.ListViewPacienti.Depth = 0;
            this.ListViewPacienti.FullRowSelect = true;
            this.ListViewPacienti.HideSelection = false;
            this.ListViewPacienti.Location = new System.Drawing.Point(138, 70);
            this.ListViewPacienti.MinimumSize = new System.Drawing.Size(200, 100);
            this.ListViewPacienti.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListViewPacienti.MouseState = MaterialSkin.MouseState.OUT;
            this.ListViewPacienti.Name = "ListViewPacienti";
            this.ListViewPacienti.OwnerDraw = true;
            this.ListViewPacienti.Size = new System.Drawing.Size(300, 415);
            this.ListViewPacienti.TabIndex = 0;
            this.ListViewPacienti.UseCompatibleStateImageBehavior = false;
            this.ListViewPacienti.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pacienti";
            this.columnHeader2.Width = 250;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ProgrameazaButton);
            this.tabPage2.Controls.Add(this.TimePicker);
            this.tabPage2.Controls.Add(this.Calendar);
            this.tabPage2.Controls.Add(this.SimptomeMultiLineTextBox);
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Controls.Add(this.materialLabel1);
            this.tabPage2.Controls.Add(this.PacientiListView);
            this.tabPage2.ImageKey = "icons8-calendar-48.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(937, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cereri programare";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ProgrameazaButton
            // 
            this.ProgrameazaButton.AutoSize = false;
            this.ProgrameazaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProgrameazaButton.Depth = 0;
            this.ProgrameazaButton.DrawShadows = true;
            this.ProgrameazaButton.HighEmphasis = true;
            this.ProgrameazaButton.Icon = null;
            this.ProgrameazaButton.Location = new System.Drawing.Point(528, 409);
            this.ProgrameazaButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ProgrameazaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProgrameazaButton.Name = "ProgrameazaButton";
            this.ProgrameazaButton.Size = new System.Drawing.Size(247, 45);
            this.ProgrameazaButton.TabIndex = 5;
            this.ProgrameazaButton.Text = "Programeaza pacient";
            this.ProgrameazaButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ProgrameazaButton.UseAccentColor = false;
            this.ProgrameazaButton.UseVisualStyleBackColor = true;
            this.ProgrameazaButton.Click += new System.EventHandler(this.ProgrameazaButton_Click);
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(528, 341);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(247, 25);
            this.TimePicker.TabIndex = 4;
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(30, 279);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.Calendar.Size = new System.Drawing.Size(391, 220);
            this.Calendar.TabIndex = 3;
            // 
            // SimptomeMultiLineTextBox
            // 
            this.SimptomeMultiLineTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SimptomeMultiLineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SimptomeMultiLineTextBox.Depth = 0;
            this.SimptomeMultiLineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SimptomeMultiLineTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SimptomeMultiLineTextBox.Hint = "";
            this.SimptomeMultiLineTextBox.Location = new System.Drawing.Point(469, 61);
            this.SimptomeMultiLineTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SimptomeMultiLineTextBox.Name = "SimptomeMultiLineTextBox";
            this.SimptomeMultiLineTextBox.ReadOnly = true;
            this.SimptomeMultiLineTextBox.Size = new System.Drawing.Size(357, 247);
            this.SimptomeMultiLineTextBox.TabIndex = 2;
            this.SimptomeMultiLineTextBox.Text = "";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(466, 23);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(130, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Simptome pacient";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(47, 23);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(148, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Cereri de programare";
            // 
            // PacientiListView
            // 
            this.PacientiListView.AutoSizeTable = true;
            this.PacientiListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PacientiListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PacientiListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.PacientiListView.Depth = 0;
            this.PacientiListView.FullRowSelect = true;
            this.PacientiListView.HideSelection = false;
            this.PacientiListView.Location = new System.Drawing.Point(50, 61);
            this.PacientiListView.MaximumSize = new System.Drawing.Size(300, 300);
            this.PacientiListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.PacientiListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PacientiListView.MouseState = MaterialSkin.MouseState.OUT;
            this.PacientiListView.Name = "PacientiListView";
            this.PacientiListView.OwnerDraw = true;
            this.PacientiListView.Scrollable = false;
            this.PacientiListView.Size = new System.Drawing.Size(230, 100);
            this.PacientiListView.TabIndex = 0;
            this.PacientiListView.UseCompatibleStateImageBehavior = false;
            this.PacientiListView.View = System.Windows.Forms.View.Details;
            this.PacientiListView.SelectedIndexChanged += new System.EventHandler(this.PacientiListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume pacient";
            this.columnHeader1.Width = 230;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RefreshButton);
            this.tabPage3.Controls.Add(this.update_button);
            this.tabPage3.Controls.Add(this.materialCard1);
            this.tabPage3.Controls.Add(this.LogoutButton1);
            this.tabPage3.ImageKey = "icons8-customer-48.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(937, 567);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Date personale";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.AutoSize = false;
            this.RefreshButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RefreshButton.Depth = 0;
            this.RefreshButton.DrawShadows = true;
            this.RefreshButton.HighEmphasis = true;
            this.RefreshButton.Icon = null;
            this.RefreshButton.Location = new System.Drawing.Point(53, 230);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RefreshButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(171, 43);
            this.RefreshButton.TabIndex = 12;
            this.RefreshButton.Text = "REFRESH";
            this.RefreshButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RefreshButton.UseAccentColor = false;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click_1);
            // 
            // update_button
            // 
            this.update_button.AutoSize = false;
            this.update_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.update_button.Depth = 0;
            this.update_button.DrawShadows = true;
            this.update_button.HighEmphasis = true;
            this.update_button.Icon = null;
            this.update_button.Location = new System.Drawing.Point(53, 131);
            this.update_button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.update_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(171, 43);
            this.update_button.TabIndex = 11;
            this.update_button.Text = "MODIFICA DATE";
            this.update_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.update_button.UseAccentColor = false;
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click_1);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialCard7);
            this.materialCard1.Controls.Add(this.materialCard6);
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialCard5);
            this.materialCard1.Controls.Add(this.materialCard4);
            this.materialCard1.Controls.Add(this.materialCard3);
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(267, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(559, 534);
            this.materialCard1.TabIndex = 1;
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.descriere_materialLabel15);
            this.materialCard7.Controls.Add(this.materialLabel14);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(303, 367);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(239, 139);
            this.materialCard7.TabIndex = 9;
            // 
            // descriere_materialLabel15
            // 
            this.descriere_materialLabel15.AutoSize = true;
            this.descriere_materialLabel15.Depth = 0;
            this.descriere_materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.descriere_materialLabel15.Location = new System.Drawing.Point(7, 14);
            this.descriere_materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.descriere_materialLabel15.Name = "descriere_materialLabel15";
            this.descriere_materialLabel15.Size = new System.Drawing.Size(76, 19);
            this.descriere_materialLabel15.TabIndex = 11;
            this.descriere_materialLabel15.Text = "Introduceti";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(17, 14);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(1, 0);
            this.materialLabel14.TabIndex = 10;
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.specializare_materialLabel15);
            this.materialCard6.Controls.Add(this.materialLabel13);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(303, 300);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(239, 40);
            this.materialCard6.TabIndex = 8;
            // 
            // specializare_materialLabel15
            // 
            this.specializare_materialLabel15.AutoSize = true;
            this.specializare_materialLabel15.Depth = 0;
            this.specializare_materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.specializare_materialLabel15.Location = new System.Drawing.Point(17, 14);
            this.specializare_materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.specializare_materialLabel15.Name = "specializare_materialLabel15";
            this.specializare_materialLabel15.Size = new System.Drawing.Size(76, 19);
            this.specializare_materialLabel15.TabIndex = 10;
            this.specializare_materialLabel15.Text = "Introduceti";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(17, 14);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(1, 0);
            this.materialLabel13.TabIndex = 10;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(17, 389);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(66, 19);
            this.materialLabel8.TabIndex = 7;
            this.materialLabel8.Text = "Descriere";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(17, 321);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(87, 19);
            this.materialLabel7.TabIndex = 6;
            this.materialLabel7.Text = "Specializare";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(17, 253);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(41, 19);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "Email";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(17, 185);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(55, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Telefon";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(17, 117);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(64, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Prenume";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(17, 49);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(43, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Nume";
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.materialLabel12);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(303, 232);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(239, 40);
            this.materialCard5.TabIndex = 2;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(17, 14);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(1, 0);
            this.materialLabel12.TabIndex = 10;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.materialLabel11);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(303, 164);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(239, 40);
            this.materialCard4.TabIndex = 1;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(17, 14);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(1, 0);
            this.materialLabel11.TabIndex = 9;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabel10);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(303, 96);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(239, 40);
            this.materialCard3.TabIndex = 1;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(17, 14);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(1, 0);
            this.materialLabel10.TabIndex = 8;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel9);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(303, 28);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(239, 40);
            this.materialCard2.TabIndex = 0;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(17, 14);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(1, 0);
            this.materialLabel9.TabIndex = 2;
            // 
            // LogoutButton1
            // 
            this.LogoutButton1.AutoSize = false;
            this.LogoutButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogoutButton1.Depth = 0;
            this.LogoutButton1.DrawShadows = true;
            this.LogoutButton1.HighEmphasis = true;
            this.LogoutButton1.Icon = null;
            this.LogoutButton1.Location = new System.Drawing.Point(53, 335);
            this.LogoutButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LogoutButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.LogoutButton1.Name = "LogoutButton1";
            this.LogoutButton1.Size = new System.Drawing.Size(171, 45);
            this.LogoutButton1.TabIndex = 0;
            this.LogoutButton1.Text = "Log out";
            this.LogoutButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LogoutButton1.UseAccentColor = false;
            this.LogoutButton1.UseVisualStyleBackColor = true;
            this.LogoutButton1.Click += new System.EventHandler(this.LogoutButton1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-calendar-48.png");
            this.imageList1.Images.SetKeyName(1, "icons8-fever-48.png");
            this.imageList1.Images.SetKeyName(2, "icons8-customer-48.png");
            // 
            // MedicPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 610);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "MedicPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medic account";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard7.ResumeLayout(false);
            this.materialCard7.PerformLayout();
            this.materialCard6.ResumeLayout(false);
            this.materialCard6.PerformLayout();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton LogoutButton1;
        private MaterialSkin.Controls.MaterialListView PacientiListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox SimptomeMultiLineTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar Calendar;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker TimePicker;
        private MaterialSkin.Controls.MaterialButton ProgrameazaButton;
        private MaterialSkin.Controls.MaterialListView ListViewPacienti;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialButton PrescrieRetetaButton;
        private MaterialSkin.Controls.MaterialButton DetaliiPacientButton;
        private MaterialSkin.Controls.MaterialButton ProgramareNouaButton;
        private MaterialSkin.Controls.MaterialButton VeziProgramariButton;
        private MaterialSkin.Controls.MaterialButton StergePacientButton;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialLabel descriere_materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialLabel specializare_materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialButton update_button;
        private MaterialSkin.Controls.MaterialButton RefreshButton;
    }
}