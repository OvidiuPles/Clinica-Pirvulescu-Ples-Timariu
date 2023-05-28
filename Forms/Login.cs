using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace proiect.Forms
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            CustomTheme.Set(this);
            MaximizeBox = false;
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            DataConnection.GetDataFromDataBase();
            List<string> useri = new List<string>();
            List<string> parola = new List<string>();

            foreach (DataRow dr in DataConnection.DsUsers.Tables["Users"].Rows)
            {
                useri.Add(dr.ItemArray.GetValue(2).ToString());
                parola.Add(dr.ItemArray.GetValue(3).ToString());
            }
            if (user_box.Text == string.Empty || parola_box.Text == string.Empty) { Dialog.Show("Error", "Date invalide!"); }
            else
            {
                if (useri.Contains(user_box.Text) && parola.Contains(parola_box.Text))
                {
                    RememberUserIfChecked();
                    StateManagement.Login(user_box.Text);
                    this.Hide();
                }
                else
                {
                    Dialog.Show("Error", "Username si/sau parola invalide!");
                }
            }
        }

        private void CreateAccountButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            MaterialForm CreateAccount = new CreateAccount();
            CreateAccount.ShowDialog();
            this.Show();
        }

        private void RememberUserIfChecked()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(DataConnection.DaLogedUser);
            DataConnection.DaLogedUser.UpdateCommand = builder.GetUpdateCommand();

            DataRow dataRow = DataConnection.DsLogedUser.Tables["LogedUser"].Rows[0];
            if (RememberCheckbox.Checked)
            {
                dataRow["username"] = user_box.Text;
            }
            else
            {
                dataRow["username"] = "null";
            }
            DataConnection.DaLogedUser.Update(DataConnection.DsLogedUser, "LogedUser");
            dataRow.AcceptChanges();
        }

        private void user_box_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
