namespace proiect.Forms.Pop_ups
{
    partial class ProgramareNoua
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
            this.ProgrameazaButton = new MaterialSkin.Controls.MaterialButton();
            this.TimePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.Calendar = new ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar();
            this.SuspendLayout();
            // 
            // ProgrameazaButton
            // 
            this.ProgrameazaButton.AutoSize = false;
            this.ProgrameazaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProgrameazaButton.Depth = 0;
            this.ProgrameazaButton.DrawShadows = true;
            this.ProgrameazaButton.HighEmphasis = true;
            this.ProgrameazaButton.Icon = null;
            this.ProgrameazaButton.Location = new System.Drawing.Point(83, 449);
            this.ProgrameazaButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ProgrameazaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProgrameazaButton.Name = "ProgrameazaButton";
            this.ProgrameazaButton.Size = new System.Drawing.Size(305, 45);
            this.ProgrameazaButton.TabIndex = 8;
            this.ProgrameazaButton.Text = "Programeaza pacient";
            this.ProgrameazaButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ProgrameazaButton.UseAccentColor = false;
            this.ProgrameazaButton.UseVisualStyleBackColor = true;
            this.ProgrameazaButton.Click += new System.EventHandler(this.ProgrameazaButton_Click);
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(83, 375);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(305, 25);
            this.TimePicker.TabIndex = 7;
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(83, 124);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.Calendar.Size = new System.Drawing.Size(293, 220);
            this.Calendar.TabIndex = 6;
            // 
            // ProgramareNoua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 537);
            this.Controls.Add(this.ProgrameazaButton);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.Calendar);
            this.Name = "ProgramareNoua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programare noua";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton ProgrameazaButton;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker TimePicker;
        private ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar Calendar;
    }
}