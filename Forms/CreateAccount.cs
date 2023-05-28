using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace proiect.Forms
{
    public partial class CreateAccount : MaterialForm
    {
        public CreateAccount()
        {
            InitializeComponent();
            CustomTheme.Set(this);
            MaximizeBox = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createAcc_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_nume.Text) || String.IsNullOrEmpty(textBox_prenume.Text) || String.IsNullOrEmpty(textBox_cnp.Text) ||
                String.IsNullOrEmpty(textBox_telefon.Text) || String.IsNullOrEmpty(textBox_email.Text) || String.IsNullOrEmpty(textBox_user.Text) ||
                String.IsNullOrEmpty(textBox_parola.Text))
            {
                Dialog.Show("Error", "Date incomplete!");
            }
            else
            {
                if ((textBox_nume.Text.All(char.IsLetter)) && (textBox_prenume.Text.All(char.IsLetter)))
                {
                    if ((textBox_email.Text.Contains(".com")) && (textBox_email.Text.Contains("@")))
                    {
                        if (textBox_cnp.Text.Length == 13 && textBox_cnp.Text.All(char.IsDigit))
                        {
                            if (textBox_telefon.Text.Length == 10 && textBox_telefon.Text.All(char.IsDigit))
                            {
                                DataConnection.MyCon.Open();
                                if (selectPacient.Checked)
                                {
                                    if (CanCreateAccount(textBox_cnp.Text, textBox_user.Text))
                                    {
                                        // Add a new row to the Pacienti table
                                        DataRow newRow2 = DataConnection.DsPacienti.Tables["Pacienti"].NewRow();
                                        newRow2["Nume"] = textBox_nume.Text;
                                        newRow2["Prenume"] = textBox_prenume.Text;
                                        newRow2["CNP"] = textBox_cnp.Text;
                                        newRow2["Telefon"] = textBox_telefon.Text;
                                        newRow2["Email"] = textBox_email.Text;
                                        if (SexComboBox.SelectedIndex == 0)
                                        {
                                            newRow2["Sex"] = "Masculin";
                                        }
                                        else
                                        {
                                            newRow2["Sex"] = "Feminin";
                                        }
                                        DataConnection.DsPacienti.Tables["Pacienti"].Rows.Add(newRow2);

                                        // Update the database with the changes made to the Pacienti table
                                        SqlCommandBuilder builder2 = new SqlCommandBuilder(DataConnection.DaPacienti);
                                        DataConnection.DaPacienti.Update(DataConnection.DsPacienti, "Pacienti");
                                        DataConnection.DsPacienti.Tables["Pacienti"].AcceptChanges();

                                        //add user
                                        // Add a new row to the Users table
                                        DataRow newRow = DataConnection.DsUsers.Tables["Users"].NewRow();
                                        newRow["username"] = textBox_user.Text;
                                        newRow["parola"] = textBox_parola.Text;
                                        newRow["CNPp"] = textBox_cnp.Text;
                                        DataConnection.DsUsers.Tables["Users"].Rows.Add(newRow);

                                        // Update the database with the changes made to the Users table
                                        SqlCommandBuilder builder = new SqlCommandBuilder(DataConnection.DaUsers);
                                        DataConnection.DaUsers.Update(DataConnection.DsUsers, "Users");
                                        DataConnection.DsUsers.Tables["Users"].AcceptChanges();

                                        Dialog.Show("Info", "CONT CREAT CU SUCCES!");
                                        this.Close();
                                    }
                                    else
                                    {
                                        Dialog.Show("Error", "Exista deja un cont cu acest CNP sau username");
                                    }
                                }
                                else if (selectDoctor.Checked)
                                {
                                    if (CanCreateAccount(textBox_cnp.Text, textBox_user.Text))
                                    {
                                        // Add a new row to the Pacienti table
                                        DataRow newRow2 = DataConnection.DsDoctori.Tables["Doctori"].NewRow();
                                        newRow2["Nume"] = textBox_nume.Text;
                                        newRow2["Prenume"] = textBox_prenume.Text;
                                        newRow2["CNP"] = textBox_cnp.Text;
                                        newRow2["Telefon"] = textBox_telefon.Text;
                                        newRow2["Email"] = textBox_email.Text;
                                        if (SexComboBox.SelectedIndex == 0)
                                        {
                                            newRow2["Sex"] = "Masculin";
                                        }
                                        else
                                        {
                                            newRow2["Sex"] = "Feminin";
                                        }
                                        DataConnection.DsDoctori.Tables["Doctori"].Rows.Add(newRow2);

                                        // Update the database with the changes made to the Pacienti table
                                        SqlCommandBuilder builder2 = new SqlCommandBuilder(DataConnection.DaDoctori);
                                        DataConnection.DaDoctori.Update(DataConnection.DsDoctori, "Doctori");
                                        DataConnection.DsDoctori.Tables["Doctori"].AcceptChanges();

                                        //add user
                                        // Add a new row to the Users table
                                        DataRow newRow = DataConnection.DsUsers.Tables["Users"].NewRow();
                                        newRow["username"] = textBox_user.Text;
                                        newRow["parola"] = textBox_parola.Text;
                                        newRow["CNPd"] = textBox_cnp.Text;
                                        DataConnection.DsUsers.Tables["Users"].Rows.Add(newRow);

                                        // Update the database with the changes made to the Users table
                                        SqlCommandBuilder builder = new SqlCommandBuilder(DataConnection.DaUsers);
                                        DataConnection.DaUsers.Update(DataConnection.DsUsers, "Users");
                                        DataConnection.DsUsers.Tables["Users"].AcceptChanges();

                                        Dialog.Show("Error","CONT CREAT CU SUCCES!");
                                        this.Close();
                                    }
                                    else
                                    {
                                        Dialog.Show("Error", "Exista deja un cont cu acest CNP sau username");
                                    }
                                 
                                }
                                DataConnection.MyCon.Close();
                            }
                            else
                            {
                                Dialog.Show("Error", "Nr. de telefon invalid!");
                            }
                        }
                        else
                        {
                            Dialog.Show("Error", "CNP invalid!");
                        }
                    }
                    else
                    {
                        Dialog.Show("Error", "E-mail invalid!");
                    }
                }
                else
                {
                    Dialog.Show("Error", "Nume si/sau prenume invalide!");
                }
            }
        }

        private bool CanCreateAccount(string cnp, string username)
        {
            foreach (DataRow dataRow in DataConnection.DsUsers.Tables["Users"].Rows)
            {
                if (dataRow.ItemArray.GetValue(2).ToString().Equals(username))
                {
                    return false;
                }
            }

            foreach (DataRow dataRow in DataConnection.DsPacienti.Tables["Pacienti"].Rows)
            {
                if (dataRow.ItemArray.GetValue(2).ToString().Equals(cnp))
                {
                    return false;
                }
            }

            foreach (DataRow dataRow in DataConnection.DsDoctori.Tables["Doctori"].Rows)
            {
                if (dataRow.ItemArray.GetValue(2).ToString().Equals(cnp))
                {
                    return false;
                }
            }
            return true;
        }


    }
}
