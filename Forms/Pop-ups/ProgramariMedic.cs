using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace proiect.Forms.Pop_ups
{
    public partial class ProgramariMedic : MaterialForm
    {
        string numeMedic;
        public ProgramariMedic(string numeMedic)
        {
            InitializeComponent();
            CustomTheme.Set(this);
            this.numeMedic = numeMedic;

            this.Text = "Programari " + numeMedic;
            ProgramariListView.Width = 400;

            LoadData();
        }

        public void LoadData()
        {
            foreach (DataRow dataRow in DataConnection.DsProgramari.Tables["Programari"].Rows)
            {
                if (dataRow.ItemArray.GetValue(2).ToString().Equals(numeMedic))
                {
                    User user = new User(dataRow.ItemArray.GetValue(0).ToString());
                    ListViewItem item = new ListViewItem();
                    item.Text = user.Nume + " " + user.Prenume;
                    item.SubItems.Add(dataRow.ItemArray.GetValue(3).ToString());
                    item.SubItems.Add(dataRow.ItemArray.GetValue(4).ToString());
                    item.Tag = dataRow.ItemArray.GetValue(5).ToString();

                    ProgramariListView.Items.Add(item);
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StergeButton_Click(object sender, EventArgs e)
        {
            if (ProgramariListView.SelectedItems.Count > 0)
            {
                foreach (DataRow dataRow in DataConnection.DsProgramari.Tables["Programari"].Rows)
                {
                    string idSelectat = ProgramariListView.SelectedItems[0].Tag.ToString();
                    if (dataRow.ItemArray.GetValue(5).ToString().Equals(idSelectat))
                    {
                        dataRow.Delete();
                        DataConnection.DaProgramari.Update(DataConnection.DsProgramari, "Programari");
                        break;
                    }
                }
                ProgramariListView.Items.Clear();
                LoadData();
                Dialog.Show("Info", "Programarea a fost stearsa cu succes");
            }
            else
            {
                Dialog.Show("Error", "Selectati o programare pentru stergere");
            }
        }
    }
}
