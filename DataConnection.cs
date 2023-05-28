using System.Data;
using System.Data.SqlClient;

namespace proiect
{
    internal class DataConnection
    {
        static private SqlConnection myCon = new SqlConnection();
        static private DataSet dsUsers;
        static private DataSet dsPacienti;
        static private DataSet dsDoctori;
        static private DataSet dsLogedUser;
        static private DataSet dsProgramari;
        static private DataSet dsPacientiMedic;
        static private DataSet dsAfectiuni;
        static private SqlDataAdapter daUsers;
        static private SqlDataAdapter daPacienti;
        static private SqlDataAdapter daDoctori;
        static private SqlDataAdapter daLogedUser;
        static private SqlDataAdapter daProgramari;
        static private SqlDataAdapter daPacientiMedic;
        static private SqlDataAdapter daAfectiuni;

        public static void GetDataFromDataBase()
        {
            myCon.Close();
            myCon.ConnectionString = @"Data Source=DESKTOP-AHGBQ61\SQLEXPRESS;Initial Catalog=Clinica_II;Integrated Security=True";
            myCon.Open();
            dsUsers = new DataSet();
            dsPacienti = new DataSet();
            dsDoctori = new DataSet();
            dsLogedUser = new DataSet();
            dsProgramari = new DataSet();
            dsPacientiMedic = new DataSet();
            dsAfectiuni = new DataSet();

            daUsers = new SqlDataAdapter("SELECT * FROM Users", myCon);
            daUsers.Fill(dsUsers, "Users");

            daPacienti = new SqlDataAdapter("SELECT * FROM Pacienti", myCon);
            daPacienti.Fill(dsPacienti, "Pacienti");

            daDoctori = new SqlDataAdapter("SELECT * FROM Doctori", myCon);
            daDoctori.Fill(dsDoctori, "Doctori");

            daLogedUser = new SqlDataAdapter("SELECT * FROM LogedUser", myCon);
            daLogedUser.Fill(dsLogedUser, "LogedUser");

            daProgramari = new SqlDataAdapter("SELECT * FROM Programari", myCon);
            daProgramari.Fill(dsProgramari, "Programari");

            daPacientiMedic = new SqlDataAdapter("SELECT * FROM PacientiMedic", myCon);
            daPacientiMedic.Fill(dsPacientiMedic, "PacientiMedic");

            daAfectiuni = new SqlDataAdapter("SELECT * FROM Afectiuni", myCon);
            daAfectiuni.Fill(dsAfectiuni, "Afectiuni");

            dsUsers.Tables["Users"].PrimaryKey = new DataColumn[] { dsUsers.Tables["Users"].Columns["username"] };
            dsPacienti.Tables["Pacienti"].PrimaryKey = new DataColumn[] { dsPacienti.Tables["Pacienti"].Columns["CNP"] };
            dsDoctori.Tables["Doctori"].PrimaryKey = new DataColumn[] { dsDoctori.Tables["Doctori"].Columns["CNP"] };
            dsProgramari.Tables["Programari"].PrimaryKey = new DataColumn[] { dsProgramari.Tables["Programari"].Columns["id"] };
            dsPacientiMedic.Tables["PacientiMedic"].PrimaryKey = new DataColumn[] { dsPacientiMedic.Tables["PacientiMedic"].Columns["id"] };
            dsAfectiuni.Tables["Afectiuni"].PrimaryKey = new DataColumn[] { dsAfectiuni.Tables["Afectiuni"].Columns["id"] };

            SqlCommandBuilder builder = new SqlCommandBuilder(DaProgramari);
            DaProgramari.UpdateCommand = builder.GetUpdateCommand();

            SqlCommandBuilder builder2 = new SqlCommandBuilder(DaPacientiMedic);
            DaPacientiMedic.UpdateCommand = builder2.GetUpdateCommand();

            SqlCommandBuilder builder3 = new SqlCommandBuilder(DaAfectiuni);
            DaAfectiuni.UpdateCommand = builder3.GetUpdateCommand();

            myCon.Close();
        }

        public static SqlConnection MyCon
        {
            get { return myCon; }
            set { myCon = value; }
        }

        public static DataSet DsUsers
        {
            get { return dsUsers; }
            set { dsUsers = value; }
        }

        public static DataSet DsPacienti
        {
            get { return dsPacienti; }
            set { dsPacienti = value; }
        }

        public static DataSet DsDoctori
        {
            get { return dsDoctori; }
            set { dsDoctori = value; }
        }

        public static DataSet DsLogedUser
        {
            get { return dsLogedUser; }
            set { dsLogedUser = value; }
        }

        public static DataSet DsProgramari
        {
            get { return dsProgramari; }
            set { dsProgramari = value; }
        }

        public static DataSet DsPacientiMedic
        {
            get { return dsPacientiMedic; }
            set { dsPacientiMedic = value; }
        }

        public static DataSet DsAfectiuni
        {
            get { return dsAfectiuni; }
            set { dsAfectiuni = value; }
        }

        public static SqlDataAdapter DaUsers
        {
            get { return daUsers; }
            set { daUsers = value; }
        }

        public static SqlDataAdapter DaPacienti
        {
            get { return daPacienti; }
            set { daPacienti = value; }
        }

        public static SqlDataAdapter DaDoctori
        {
            get { return daDoctori; }
            set { daDoctori = value; }
        }

        public static SqlDataAdapter DaLogedUser
        {
            get { return daLogedUser; }
            set { daLogedUser = value; }
        }

        public static SqlDataAdapter DaProgramari
        {
            get { return daProgramari; }
            set { daProgramari = value; }
        }

        public static SqlDataAdapter DaPacientiMedic
        {
            get { return daPacientiMedic; }
            set { daPacientiMedic = value; }
        }

        public static SqlDataAdapter DaAfectiuni
        {
            get { return daAfectiuni; }
            set { daAfectiuni = value; }
        }
    }
}

