using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;

namespace proiect.Forms.Pop_ups
{

    public partial class ProgramareNoua : MaterialForm
    {
        string usernamePacient;
        string numeDoctor;
        public ProgramareNoua(string usernamePacient, string numeDoctor)
        {
            InitializeComponent();
            CustomTheme.Set(this);
            this.usernamePacient = usernamePacient;
            this.numeDoctor = numeDoctor;

            User user = new User(usernamePacient);
            this.Text = "Programare pentru " + user.Nume + " " + user.Prenume;
        }

        private void ProgrameazaButton_Click(object sender, EventArgs e)
        {
            DataRow newRow = DataConnection.DsProgramari.Tables["Programari"].NewRow();
            newRow["username"] = usernamePacient;
            newRow["simptome"] = "programare facuta de medic";
            newRow["medic"] = numeDoctor;
            newRow["data"] = Calendar.SelectionStart.ToShortDateString();
            newRow["ora"] = TimePicker.Value.ToShortTimeString();
            Random random = new Random();
            newRow["id"] = random.Next();

            DataConnection.DsProgramari.Tables["Programari"].Rows.Add(newRow);
            DataConnection.DaProgramari.Update(DataConnection.DsProgramari, "Programari");
            DataConnection.DsProgramari.Tables["Programari"].AcceptChanges();

            Dialog.Show("Info", "Programarea a fost facuta cu succes");
            this.Close();
        }
    }
}
