using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proiect
{
    public enum AccountType
    {
        pacient,
        doctor
    }

    public class User
    {
        private String nume = string.Empty;
        private String prenume = string.Empty;
        private String cnp = string.Empty;
        private String telefon = string.Empty;
        private String email = string.Empty;
        private String username = string.Empty;
        private String sex = string.Empty;
        private String specializare = string.Empty;
        private String descriere = string.Empty;
        private AccountType accountType;

        public User(string username)
        {
            GetUserInfo(username);
        }

        public void GetUserInfo(string username)
        {
            DataConnection.GetDataFromDataBase();
            String cnpp = string.Empty;
            String cnpd = string.Empty;

            string query = "SELECT CNPp FROM Users WHERE username = @user ";
            string query2 = "SELECT CNPd FROM Users WHERE username = @user ";
            SqlCommand com = new SqlCommand(query, DataConnection.MyCon);
            SqlCommand com2 = new SqlCommand(query2, DataConnection.MyCon);

            com.Parameters.AddWithValue("@user", username);
            com2.Parameters.AddWithValue("@user", username);
            try
            {
                DataConnection.MyCon.Open();
                cnpp = com.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { DataConnection.MyCon.Close(); }
            try
            {
                DataConnection.MyCon.Open();
                cnpd = com2.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { DataConnection.MyCon.Close(); }

            if (String.IsNullOrEmpty(cnpd))
            {
                accountType = AccountType.pacient;
                cnp = cnpp;
                string query3 = "SELECT Nume FROM Pacienti WHERE CNP = @cnp";
                string query4 = "SELECT Prenume FROM Pacienti WHERE CNP = @cnp";
                string query5 = "SELECT Telefon FROM Pacienti WHERE CNP = @cnp";
                string query6 = "SELECT Email FROM Pacienti WHERE CNP = @cnp";
                string query7 = "SELECT Sex FROM Pacienti WHERE CNP = @cnp";
                SqlCommand com3 = new SqlCommand(query3, DataConnection.MyCon);
                SqlCommand com4 = new SqlCommand(query4, DataConnection.MyCon);
                SqlCommand com5 = new SqlCommand(query5, DataConnection.MyCon);
                SqlCommand com6 = new SqlCommand(query6, DataConnection.MyCon);
                SqlCommand com7 = new SqlCommand(query7, DataConnection.MyCon);
                com3.Parameters.AddWithValue("@cnp", cnp);
                com4.Parameters.AddWithValue("@cnp", cnp);
                com5.Parameters.AddWithValue("@cnp", cnp);
                com6.Parameters.AddWithValue("@cnp", cnp);
                com7.Parameters.AddWithValue("@cnp", cnp);
                try
                {
                    DataConnection.MyCon.Open();
                    sex = com7.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally { DataConnection.MyCon.Close(); }

                try
                {
                    DataConnection.MyCon.Open();
                    nume = com3.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally { DataConnection.MyCon.Close(); }
                try
                {
                    DataConnection.MyCon.Open();
                    prenume = com4.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally { DataConnection.MyCon.Close(); }
                try
                {
                    DataConnection.MyCon.Open();
                    telefon = com5.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally { DataConnection.MyCon.Close(); }
                try
                {
                    DataConnection.MyCon.Open();
                    email = com6.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally { DataConnection.MyCon.Close(); }
            }
            else
            {
                accountType = AccountType.doctor;
                cnp = cnpd;
                string query3 = "SELECT Nume FROM Doctori WHERE CNP = @cnp";
                string query4 = "SELECT Prenume FROM Doctori WHERE CNP = @cnp";
                string query5 = "SELECT Telefon FROM Doctori WHERE CNP = @cnp";
                string query6 = "SELECT Email FROM Doctori WHERE CNP = @cnp";
                string query7 = "SELECT Sex FROM Doctori WHERE CNP = @cnp";
                string query8 = "SELECT Specializare FROM Doctori WHERE CNP = @cnp";
                string query9 = "SELECT Descriere FROM Doctori WHERE CNP = @cnp";
                SqlCommand com3 = new SqlCommand(query3, DataConnection.MyCon);
                SqlCommand com4 = new SqlCommand(query4, DataConnection.MyCon);
                SqlCommand com5 = new SqlCommand(query5, DataConnection.MyCon);
                SqlCommand com6 = new SqlCommand(query6, DataConnection.MyCon);
                SqlCommand com7 = new SqlCommand(query7, DataConnection.MyCon);
                SqlCommand com8 = new SqlCommand(query8, DataConnection.MyCon);
                SqlCommand com9 = new SqlCommand(query9, DataConnection.MyCon);
                com3.Parameters.AddWithValue("@cnp", cnp);
                com4.Parameters.AddWithValue("@cnp", cnp);
                com5.Parameters.AddWithValue("@cnp", cnp);
                com6.Parameters.AddWithValue("@cnp", cnp);
                com7.Parameters.AddWithValue("@cnp", cnp);
                com8.Parameters.AddWithValue("@cnp", cnp);
                com9.Parameters.AddWithValue("@cnp", cnp);
                try
                {
                    DataConnection.MyCon.Open();
                    sex = com7.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally { DataConnection.MyCon.Close(); }
                try
                {
                    DataConnection.MyCon.Open();
                    nume = com3.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally { DataConnection.MyCon.Close(); }
                try
                {
                    DataConnection.MyCon.Open();
                    prenume = com4.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally { DataConnection.MyCon.Close(); }
                try
                {
                    DataConnection.MyCon.Open();
                    telefon = com5.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally { DataConnection.MyCon.Close(); }
                try
                {
                    DataConnection.MyCon.Open();
                    email = com6.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally { DataConnection.MyCon.Close(); }
                try
                {
                    DataConnection.MyCon.Open();
                    specializare = com8.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally { DataConnection.MyCon.Close(); }
                try
                {
                    DataConnection.MyCon.Open();
                    descriere = com9.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally { DataConnection.MyCon.Close(); }
            }
            this.username = username;
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }

        public string CNP
        {
            get { return cnp; }
            set { cnp = value; }
        }

        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string Specializare
        {
            get { return specializare; }
            set { specializare = value; }
        }
        public string Descriere
        {
            get { return descriere; }
            set { descriere = value; }
        }

        public AccountType AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }
    }
}
