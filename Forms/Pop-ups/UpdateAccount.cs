using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;

namespace proiect.Forms
{
    public partial class UpdateAccount : MaterialForm
    {
        User user;
        public UpdateAccount(User user)
        {
            InitializeComponent();
            CustomTheme.Set(this);
            this.user = user;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdatePacient();

            if (UpdateUser() && (PhoneTextBox.Text != "" || EmailTextBox.Text != ""
                || UsernameTextBox.Text != "" || PasswordTextBox.Text != ""))
            {
                Dialog.Show("Info", "Datele au fost actualizate");
                this.Close();
            }
        }

        private bool UpdateUser()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(DataConnection.DaUsers);
            DataConnection.DaUsers.UpdateCommand = builder.GetUpdateCommand();
            bool canUpdateUsername = true;

            DataRow rowToUpdate = DataConnection.DsUsers.Tables["Users"].Rows.Find(user.Username);
            if (UsernameTextBox.Text != "")
            {
                foreach (DataRow dataRow in DataConnection.DsUsers.Tables["Users"].Rows)
                {
                    if (dataRow.ItemArray.GetValue(2).ToString().Equals(UsernameTextBox.Text))
                    {
                        Dialog.Show("Error", "Un cont cu acest username exista deja");
                        canUpdateUsername = false;
                    }
                }
                if (canUpdateUsername)
                {
                    rowToUpdate["username"] = UsernameTextBox.Text;
                    HomePage.user.Username = UsernameTextBox.Text;
                }
            }
            if (PasswordTextBox.Text != "")
            {
                rowToUpdate["parola"] = PasswordTextBox.Text;
            }
            DataConnection.DaUsers.Update(DataConnection.DsUsers, "Users");
            rowToUpdate.AcceptChanges();
            return canUpdateUsername;
        }

        private void UpdatePacient()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(DataConnection.DaPacienti);
            DataConnection.DaPacienti.UpdateCommand = builder.GetUpdateCommand();

            DataRow rowToUpdate = DataConnection.DsPacienti.Tables["Pacienti"].Rows.Find(user.CNP);
            if (PhoneTextBox.Text != "")
            {
                rowToUpdate["Telefon"] = PhoneTextBox.Text;
                HomePage.user.Telefon = PhoneTextBox.Text;
            }
            if (EmailTextBox.Text != "")
            {
                rowToUpdate["Email"] = EmailTextBox.Text;
                HomePage.user.Email = EmailTextBox.Text;
            }
            try
            {
                DataConnection.DaPacienti.Update(DataConnection.DsPacienti, "Pacienti");
            }
            catch (Exception)
            {
                Dialog.Show("Error", "Date invalide");
            }
            rowToUpdate.AcceptChanges();
        }

        


    }
}
