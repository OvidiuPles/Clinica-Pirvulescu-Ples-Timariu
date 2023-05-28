using MaterialSkin.Controls;
using proiect.Forms.Pop_ups;
using System.Data;
using System.Windows.Forms;

namespace proiect.Forms.Info
{
    public partial class DosarPacient : MaterialForm
    {
        User user;
        public DosarPacient(string username)
        {
            InitializeComponent();
            CustomTheme.Set(this);
            user = new User(username);
            this.Text = "Dosar " + user.Nume + " " + user.Prenume;
            AfectiuniListView.Width = 250;

            label_cnp.Text = user.CNP;
            label_email.Text = user.Email;
            label_nume.Text = user.Nume;
            label_prenume.Text = user.Prenume;
            label_sex.Text = user.Sex;
            label_telefon.Text = user.Telefon;
            LoadData();
        }

        private void LoadData()
        {
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

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void CloseButton2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void RetetaButton_Click(object sender, System.EventArgs e)
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

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            if (AfectiuniListView.SelectedItems.Count > 0)
            {
                foreach (DataRow dataRow in DataConnection.DsAfectiuni.Tables["Afectiuni"].Rows)
                {
                    string idSelectat = AfectiuniListView.SelectedItems[0].Tag.ToString();
                    if (dataRow.ItemArray.GetValue(4).ToString().Equals(idSelectat))
                    {
                        dataRow.Delete();
                        DataConnection.DaAfectiuni.Update(DataConnection.DsAfectiuni, "Afectiuni");
                        break;
                    }
                }
                AfectiuniListView.Items.Clear();
                LoadData();
                Dialog.Show("Info", "Afectiunea a fost stearsa cu succes");
            }
            else
            {
                Dialog.Show("Error", "Selectati o afectiune pentru stergere");
            }
        }
    }
}
