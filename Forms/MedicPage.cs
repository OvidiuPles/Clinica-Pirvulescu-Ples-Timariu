using MaterialSkin.Controls;
using proiect.Forms.Info;
using proiect.Forms.Pop_ups;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace proiect.Forms
{
    public partial class MedicPage : MaterialForm
    {
        public static User user;

        public MedicPage(string username)
        {
            InitializeComponent();
            CustomTheme.Set(this);
            this.Size = new System.Drawing.Size(735, 545);
            user = new User(username);
            materialLabel9.Text = user.Nume;
            materialLabel10.Text = user.Prenume;
            materialLabel11.Text = user.Telefon;
            materialLabel12.Text = user.Email;
            if (user.Specializare != null) { specializare_materialLabel15.Text = user.Specializare; }
            else { specializare_materialLabel15.Text = "INTRODUCETI!"; }
            if (user.Descriere != null) { descriere_materialLabel15.Text = user.Descriere; }
            else { descriere_materialLabel15.Text = "INTRODUCETI!"; }
            LoadData();
        }


        private void LoadData()
        {
            PacientiListView.Items.Clear(); //tab programari
            ListViewPacienti.Items.Clear(); //tab pacienti
            SimptomeMultiLineTextBox.Clear();
            ListViewPacienti.Width = 250;

            string numeFullMedic = user.Nume + " " + user.Prenume;
            this.Text = "Medic " + numeFullMedic;
            List<string> insertedUsers = new List<string>(); // pentru tab programari

            foreach (DataRow dataRow in DataConnection.DsProgramari.Tables["Programari"].Rows)
            {
                User user = new User(dataRow.ItemArray.GetValue(0).ToString());

                if (dataRow.ItemArray.GetValue(2).ToString() == numeFullMedic
                    && !insertedUsers.Contains(user.Username)
                    && dataRow.ItemArray.GetValue(4).ToString() == "")
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = user.Nume + " " + user.Prenume;
                    item.Tag = user.Username;

                    PacientiListView.Items.Add(item);
                    insertedUsers.Add(user.Username);
                }
            }

            foreach (DataRow dataRow in DataConnection.DsPacientiMedic.Tables["PacientiMedic"].Rows)
            {
                if (dataRow.ItemArray.GetValue(1).ToString() == numeFullMedic)
                {
                    User user = new User(dataRow.ItemArray.GetValue(0).ToString());

                    ListViewItem item = new ListViewItem();
                    item.Text = user.Nume + " " + user.Prenume;
                    item.Tag = user.Username;

                    ListViewPacienti.Items.Add(item);
                }
            }

        }



        private void LogoutButton1_Click(object sender, EventArgs e)
        {
            StateManagement.LogOut();
            this.Hide();
        }

        private void PacientiListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string simptome = null;
            string pacientSelectat = PacientiListView.SelectedItems.Count > 0
                ? PacientiListView.SelectedItems[0].Tag.ToString() : string.Empty;
            foreach (DataRow dataRow in DataConnection.DsProgramari.Tables["Programari"].Rows)
            {
                User user = new User(dataRow.ItemArray.GetValue(0).ToString());
                if (dataRow.ItemArray.GetValue(2).ToString() == MedicPage.user.Nume + " " + MedicPage.user.Prenume
                    && user.Username == pacientSelectat
                    && dataRow.ItemArray.GetValue(4).ToString() == "")
                { 
                    simptome += dataRow.ItemArray.GetValue(1).ToString() + "\n\n";
                }
            }
            SimptomeMultiLineTextBox.Text = simptome;
        }

        private void ProgrameazaButton_Click(object sender, EventArgs e)
        {
            if (PacientiListView.SelectedItems.Count > 0)
            {
                string userProgramat = string.Empty;
                bool pacientNou = true;
                string numeFullMedic = user.Nume + " " + user.Prenume;

                foreach (DataRow dataRow in DataConnection.DsProgramari.Tables["Programari"].Rows)
                {
                    User user = new User(dataRow.ItemArray.GetValue(0).ToString());

                    if (dataRow.ItemArray.GetValue(2).ToString() == numeFullMedic
                    && user.Username == PacientiListView.SelectedItems[0].Tag.ToString())
                    {
                        int selectedId = int.Parse(dataRow.ItemArray.GetValue(5).ToString());
                        DataRow rowToUpdate = DataConnection.DsProgramari.Tables["Programari"].Rows.Find(selectedId);
                        rowToUpdate["data"] = Calendar.SelectionStart.ToShortDateString();
                        rowToUpdate["ora"] = TimePicker.Value.ToShortTimeString();

                        DataConnection.DaProgramari.Update(DataConnection.DsProgramari, "Programari");
                        userProgramat = user.Username;
                    }
                }
                Dialog.Show("Info", "Programarea a fost facuta cu succes");

                foreach (DataRow dataRow in DataConnection.DsPacientiMedic.Tables["PacientiMedic"].Rows)
                {
                    if (dataRow.ItemArray.GetValue(1).ToString() == numeFullMedic
                       && dataRow.ItemArray.GetValue(0).ToString() == userProgramat)
                    {
                        pacientNou = false;
                    }
                }

                if (pacientNou)
                {
                    DataRow newRow = DataConnection.DsPacientiMedic.Tables["PacientiMedic"].NewRow();
                    newRow["username"] = userProgramat;
                    newRow["numeMedic"] = numeFullMedic;
                    Random random = new Random();
                    newRow["id"] = random.Next();

                    DataConnection.DsPacientiMedic.Tables["PacientiMedic"].Rows.Add(newRow);
                    DataConnection.DaPacientiMedic.Update(DataConnection.DsPacientiMedic, "PacientiMedic");
                    DataConnection.DsPacientiMedic.Tables["PacientiMedic"].AcceptChanges();

                    Dialog.Show("Info", "Pacientul a fost adaugat in lista de pacienti");
                }
                LoadData();
            }
            else
            {
                Dialog.Show("Eroare", "Selectati un pacient");
            }
        }

        private void DetaliiPacientButton_Click(object sender, EventArgs e)
        {
            if (ListViewPacienti.SelectedItems.Count > 0)
            {
                this.Hide();
                DosarPacient userDetails = new DosarPacient(ListViewPacienti.SelectedItems[0].Tag.ToString());
                userDetails.ShowDialog();
                this.Show();
            }
            else
            {
                Dialog.Show("Error", "Selectati un pacient");
            }
        }

        private void ProgramareNouaButton_Click(object sender, EventArgs e)
        {
            if (ListViewPacienti.SelectedItems.Count > 0)
            {
                string usernameSelectat = ListViewPacienti.SelectedItems[0].Tag.ToString();
                ProgramareNoua programareNoua = new ProgramareNoua(usernameSelectat, user.Nume + " " + user.Prenume);
                programareNoua.ShowDialog();
            }
            else
            {
                Dialog.Show("Error", "Selectati un pacient");
            }
        }

        private void VeziProgramariButton_Click(object sender, EventArgs e)
        {
            ProgramariMedic programariMedic = new ProgramariMedic(user.Nume + " " + user.Prenume);
            programariMedic.ShowDialog();
        }
        private void PrescrieRetetaButton_Click(object sender, EventArgs e)
        {
            if (ListViewPacienti.SelectedItems.Count > 0)
            {
                string usernameSelectat = ListViewPacienti.SelectedItems[0].Tag.ToString();
                PrescrieReteta prescrieReteta = new PrescrieReteta(usernameSelectat, user.Nume + " " + user.Prenume);
                prescrieReteta.ShowDialog();
            }
            else
            {
                Dialog.Show("Error", "Selectati un pacient");
            }
        }

        private void StergePacientButton_Click(object sender, EventArgs e)
        {
            if (ListViewPacienti.SelectedItems.Count > 0)
            {
                User user = new User(ListViewPacienti.SelectedItems[0].Tag.ToString());
                //stergere programari
                foreach (DataRow dataRow in DataConnection.DsProgramari.Tables["Programari"].Rows)
                {
                    if (dataRow.ItemArray.GetValue(0).ToString().Equals(user.Username)
                        && dataRow.ItemArray.GetValue(2).ToString().Equals(user.Nume + " " + user.Prenume))
                    {
                        dataRow.Delete();
                    }
                }

                //sterge afectiuni si retete
                foreach (DataRow dataRow in DataConnection.DsAfectiuni.Tables["Afectiuni"].Rows)
                {
                    if (dataRow.ItemArray.GetValue(0).ToString().Equals(user.Username)
                        && dataRow.ItemArray.GetValue(1).ToString().Equals(user.Nume + " " + user.Prenume))
                    {
                        dataRow.Delete();
                    }
                }

                //sterge pacient
                foreach (DataRow dataRow in DataConnection.DsPacientiMedic.Tables["PacientiMedic"].Rows)
                {
                    if (dataRow.ItemArray.GetValue(0).ToString().Equals(user.Username)
                        && dataRow.ItemArray.GetValue(1).ToString().Equals(user.Nume + " " + user.Prenume))
                    {
                        dataRow.Delete();
                    }
                }

                DataConnection.DaProgramari.Update(DataConnection.DsProgramari, "Programari");
                DataConnection.DaAfectiuni.Update(DataConnection.DsAfectiuni, "Afectiuni");
                DataConnection.DaPacientiMedic.Update(DataConnection.DsPacientiMedic, "PacientiMedic");

                PacientiListView.Items.Clear();
                ListViewPacienti.Items.Clear();
                LoadData();
                Dialog.Show("Error", "Pacientul a fost sters cu succes");
            }
            else
            {
                Dialog.Show("Error", "Selectati un pacient pentru stergere");
            }
        }


        private void update_button_Click_1(object sender, EventArgs e)
        {
            Doctor_Update updateAccount = new Doctor_Update(user);
            updateAccount.ShowDialog();
        }

        private void RefreshButton_Click_1(object sender, EventArgs e)
        {
            materialLabel11.Text = user.Telefon;
            materialLabel12.Text = user.Email;
            user.Specializare = user.Specializare;
            specializare_materialLabel15.Text = user.Specializare;
            descriere_materialLabel15.Text = user.Descriere;
        }

 
    }
}
