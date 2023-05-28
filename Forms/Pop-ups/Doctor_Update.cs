using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect.Forms.Pop_ups
{
    public partial class Doctor_Update : MaterialForm 
    {
        User user;

        public Doctor_Update(User user)
        {
            InitializeComponent();
            CustomTheme.Set(this);
            this.user = user;
        }

        private void UpdateDoctor()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(DataConnection.DaDoctori);
            DataConnection.DaDoctori.UpdateCommand = builder.GetUpdateCommand();

            DataRow rowToUpdate = DataConnection.DsDoctori.Tables["Doctori"].Rows.Find(user.CNP);
            if (PhoneTextBox.Text != "")
            {
                rowToUpdate["Telefon"] = PhoneTextBox.Text;
                MedicPage.user.Telefon= PhoneTextBox.Text;
            }
            if (EmailTextBox.Text != "")
            {
                rowToUpdate["Email"] = EmailTextBox.Text;
                MedicPage.user.Email = EmailTextBox.Text;
            }
            if (SpecializareTextBox.Text != "")
            {
                rowToUpdate["Specializare"] = SpecializareTextBox.Text;
                MedicPage.user.Specializare = SpecializareTextBox.Text;
            }
            if (DescriereTextBox.Text != "")
            {
                rowToUpdate["Descriere"] = DescriereTextBox.Text;
                MedicPage.user.Descriere = DescriereTextBox.Text;
            }
            DataConnection.DaDoctori.Update(DataConnection.DsDoctori, "Doctori");
            rowToUpdate.AcceptChanges();
        }

        private void UpdateButton1_Click(object sender, EventArgs e)
        {
            UpdateDoctor();
            Dialog.Show("Info", "Datele au fost actualizate");
            this.Close();
        }
    }
}
