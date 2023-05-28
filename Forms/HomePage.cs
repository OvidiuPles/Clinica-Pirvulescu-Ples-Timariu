using MaterialSkin.Controls;
using proiect.Forms.Pop_ups;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace proiect.Forms
{
    public partial class HomePage : MaterialForm
    {
        public static User user;

        public HomePage(string username)
        {
            InitializeComponent();
            CustomTheme.Set(this);
            user = new User(username);
            ShowData();

            MaximizeBox = false;
            ProgramariListView.Width = 576;
            AfectiuniListView.Width = 380;
            label_welcome.Text = "Bine ai venit, " + user.Prenume + " " + user.Nume + "!";
            this.Size = new System.Drawing.Size(735, 545);
        }

        private void ShowData()
        {
            label_nume.Text = user.Nume;
            label_prenume.Text = user.Prenume;
            label_cnp.Text = user.CNP;
            label_telefon.Text = user.Telefon;
            label_email.Text = user.Email;
            label_sex.Text = user.Sex;

            ////////////////////////////////////////

            foreach (DataRow dataRow in DataConnection.DsDoctori.Tables["Doctori"].Rows)
            {
                List<string> doctori = new List<string>();
                doctori.Add(dataRow.ItemArray.GetValue(0).ToString() + " " + dataRow.ItemArray.GetValue(1).ToString());

                foreach (object o in doctori)
                {
                    doctori_ComboBox1.Items.Add(o);
                }
            }

            foreach (DataRow dataRow in DataConnection.DsDoctori.Tables["Doctori"].Rows)
            {
                List<string> spec = new List<string>();
                if (String.IsNullOrEmpty((dataRow.ItemArray.GetValue(5).ToString()))) { }
                else { spec.Add(dataRow.ItemArray.GetValue(5).ToString()); }
                foreach (object item in spec)
                    SpecializariComboBox.Items.Add(item);
            }


            //////////////////////////////////////////////////

            foreach (DataRow dataRow in DataConnection.DsProgramari.Tables["Programari"].Rows)
            {
                if (dataRow.ItemArray.GetValue(0).ToString().Equals(user.Username)
                    && !dataRow.ItemArray.GetValue(4).ToString().Equals(""))
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = dataRow.ItemArray.GetValue(2).ToString();
                    item.SubItems.Add(dataRow.ItemArray.GetValue(3).ToString());
                    item.SubItems.Add(dataRow.ItemArray.GetValue(4).ToString());
                    ProgramariListView.Items.Add(item);
                }
            }

            foreach (DataRow dataRow in DataConnection.DsAfectiuni.Tables["Afectiuni"].Rows)
            {
                if (dataRow.ItemArray.GetValue(0).ToString().Equals(user.Username))
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = dataRow.ItemArray.GetValue(2).ToString();
                    item.Tag = dataRow.ItemArray.GetValue(4).ToString();
                    AfectiuniListView.Items.Add(item);
                }
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            StateManagement.LogOut();
            this.Hide();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateAccount updateAccount = new UpdateAccount(user);
            updateAccount.ShowDialog();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            label_nume.Text = user.Nume;
            label_prenume.Text = user.Prenume;
            label_cnp.Text = user.CNP;
            label_telefon.Text = user.Telefon;
            label_email.Text = user.Email;
            label_sex.Text = user.Sex;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DataRow newRow = DataConnection.DsProgramari.Tables["Programari"].NewRow();
            newRow["username"] = user.Username;
            newRow["simptome"] = SimptomeTextBox.Text;
            newRow["medic"] = MediciComboBox.SelectedItem.ToString();
            Random random = new Random();
            newRow["id"] = random.Next(); // ????????????
            DataConnection.DsProgramari.Tables["Programari"].Rows.Add(newRow);

            SqlCommandBuilder builder = new SqlCommandBuilder(DataConnection.DaProgramari);
            DataConnection.DaProgramari.Update(DataConnection.DsProgramari, "Programari");
            DataConnection.DsProgramari.Tables["Programari"].AcceptChanges();

            Dialog.Show("Info", "Cererea de programare a fost facuta");
            SimptomeTextBox.Clear();
        }

        private void SpecializariComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            MediciComboBox.Items.Clear();
            foreach (DataRow dataRow in DataConnection.DsDoctori.Tables["Doctori"].Rows)
            {
                if (dataRow.ItemArray.GetValue(5).ToString() == SpecializariComboBox.SelectedItem.ToString())
                {
                    MediciComboBox.Items.Add(dataRow.ItemArray.GetValue(0).ToString()
                                        + " " + dataRow.ItemArray.GetValue(1).ToString());
                }
            }
        }

        private void VeziRetetaButton_Click(object sender, EventArgs e)
        {
            if (AfectiuniListView.SelectedItems.Count > 0)
            {
                Reteta reteta = new Reteta(AfectiuniListView.SelectedItems[0].Tag.ToString());
                reteta.ShowDialog();
            }
            else
            {
                Dialog.Show("Error", "Selectati o afectiune");
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

            pictureBox_untold.Image = Image.FromFile("untold.jpg");
            pictureBox_analize.Image = Image.FromFile("analize.jpg");
        }


        private void doctori_ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (DataRow dataRow in DataConnection.DsDoctori.Tables["Doctori"].Rows)
            {

                if (dataRow.ItemArray.GetValue(0).ToString() + " " + dataRow.ItemArray.GetValue(1).ToString() == doctori_ComboBox1.SelectedItem.ToString())
                {
                    spec_pacient_label.Text = dataRow.ItemArray.GetValue(5).ToString();
                    descr_pacient_label.Text = dataRow.ItemArray.GetValue(7).ToString();
                    telef_pac_label.Text = dataRow.ItemArray.GetValue(3).ToString();
                    email_pac_label1.Text = dataRow.ItemArray.GetValue(4).ToString();
                }
            }
        }


        int counter = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter < 3)
            {
                pictureBox_imagini.Image = imageList2.Images[counter];
                counter++;
            }
            else
            {
                counter = 0;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.synlab.ro/servicii/analize-de-laborator");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://untold.com/regulament-blood-network");
        }
    }

}
