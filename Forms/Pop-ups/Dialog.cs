using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect.Forms
{
    public partial class Dialog : MaterialForm
    {
        public Dialog(string titlu, string mesaj)
        {
            InitializeComponent();
            CustomTheme.Set(this);
            MaximizeBox = false;

            this.Text = titlu;
            label1.Text = mesaj;
        }

        public static void Show(string titlu, string mesaj)
        {
            Dialog dialog = new Dialog(titlu, mesaj);
            dialog.ShowDialog();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
