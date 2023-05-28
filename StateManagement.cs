using proiect.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proiect
{
    internal class StateManagement
    {
        public static void Start()
        {
            DataConnection.GetDataFromDataBase();

            if (LogedUser() != "null")
            {
                User user = new User(LogedUser());
                if (user.AccountType == AccountType.pacient)
                {
                    Application.Run(new HomePage(LogedUser()));
                }
                else
                {
                    Application.Run(new MedicPage(LogedUser()));
                }
            }
            else
            {
                Application.Run(new Login());
            }
        }

        public static void LogOut()
        {
            Login login = new Login();
            login.Show();

            SqlCommandBuilder builder = new SqlCommandBuilder(DataConnection.DaLogedUser);
            DataConnection.DaLogedUser.UpdateCommand = builder.GetUpdateCommand();

            DataRow dataRow = DataConnection.DsLogedUser.Tables["LogedUser"].Rows[0];
            dataRow["username"] = "null";

            DataConnection.DaLogedUser.Update(DataConnection.DsLogedUser, "LogedUser");
            dataRow.AcceptChanges();
        }

        public static void Login(string username)
        {
            User user = new User(username);
            if (user.AccountType == AccountType.pacient)
            {
                HomePage homePage = new HomePage(username);
                homePage.Show();
            }
            else
            {
                MedicPage medicPage = new MedicPage(username);
                medicPage.Show();
            }
        }

        private static string LogedUser()
        {
            DataRow dataRow = DataConnection.DsLogedUser.Tables["LogedUser"].Rows[0];
            return dataRow["username"].ToString();
        }
    }
}
