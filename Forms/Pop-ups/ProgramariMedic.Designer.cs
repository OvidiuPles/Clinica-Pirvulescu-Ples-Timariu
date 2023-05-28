namespace proiect.Forms.Pop_ups
{
    partial class ProgramariMedic
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
            this.ProgramariListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StergeButton = new MaterialSkin.Controls.MaterialButton();
            this.ExitButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // ProgramariListView
            // 
            this.ProgramariListView.AutoSizeTable = false;
            this.ProgramariListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProgramariListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProgramariListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ProgramariListView.Depth = 0;
            this.ProgramariListView.FullRowSelect = true;
            this.ProgramariListView.HideSelection = false;
            this.ProgramariListView.Location = new System.Drawing.Point(40, 113);
            this.ProgramariListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.ProgramariListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ProgramariListView.MouseState = MaterialSkin.MouseState.OUT;
            this.ProgramariListView.Name = "ProgramariListView";
            this.ProgramariListView.OwnerDraw = true;
            this.ProgramariListView.Size = new System.Drawing.Size(501, 299);
            this.ProgramariListView.TabIndex = 0;
            this.ProgramariListView.UseCompatibleStateImageBehavior = false;
            this.ProgramariListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pacient";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ora";
            this.columnHeader3.Width = 100;
            // 
            // StergeButton
            // 
            this.StergeButton.AutoSize = false;
            this.StergeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StergeButton.Depth = 0;
            this.StergeButton.DrawShadows = true;
            this.StergeButton.HighEmphasis = true;
            this.StergeButton.Icon = null;
            this.StergeButton.Location = new System.Drawing.Point(322, 444);
            this.StergeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StergeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StergeButton.Name = "StergeButton";
            this.StergeButton.Size = new System.Drawing.Size(252, 45);
            this.StergeButton.TabIndex = 1;
            this.StergeButton.Text = "Sterge programare";
            this.StergeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StergeButton.UseAccentColor = false;
            this.StergeButton.UseVisualStyleBackColor = true;
            this.StergeButton.Click += new System.EventHandler(this.StergeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = false;
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.Depth = 0;
            this.ExitButton.DrawShadows = true;
            this.ExitButton.HighEmphasis = true;
            this.ExitButton.Icon = null;
            this.ExitButton.Location = new System.Drawing.Point(40, 444);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(253, 45);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Inchide";
            this.ExitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ExitButton.UseAccentColor = false;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ProgramariMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 518);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StergeButton);
            this.Controls.Add(this.ProgramariListView);
            this.Name = "ProgramariMedic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgramariMedic";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView ProgramariListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialButton StergeButton;
        private MaterialSkin.Controls.MaterialButton ExitButton;
    }
}