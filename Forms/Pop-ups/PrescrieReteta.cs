using MaterialSkin.Controls;
using System.Data;
using System;

namespace proiect.Forms.Pop_ups
{
    public partial class PrescrieReteta : MaterialForm
    {
        string usernamePacient;
        string numeDoctor;
        public PrescrieReteta(string usernamePacient, string numeDoctor)
        {
            InitializeComponent();
            CustomTheme.Set(this);

            this.usernamePacient = usernamePacient;
            this.numeDoctor = numeDoctor;

            User user = new User(usernamePacient);
            this.Text = "Reteta pentru " + user.Nume + " " + user.Prenume;
        }

        private void InchideButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void TrimiteButton_Click(object sender, System.EventArgs e)
        {
            DataRow newRow = DataConnection.DsAfectiuni.Tables["Afectiuni"].NewRow();
            newRow["username"] = usernamePacient;
            newRow["medic"] = numeDoctor;
            newRow["afectiune"] = AfectiuniTextBox.Text;
            newRow["reteta"] = RetetaMultiLineTextBox.Text;
            Random random = new Random();
            newRow["id"] = random.Next();

            DataConnection.DsAfectiuni.Tables["Afectiuni"].Rows.Add(newRow);
            DataConnection.DaAfectiuni.Update(DataConnection.DsAfectiuni, "Afectiuni");
            DataConnection.DsAfectiuni.Tables["Afectiuni"].AcceptChanges();

            Dialog.Show("Info", "Reteta a fost trimisa cu succes");
            this.Close();
        }
    }
}
