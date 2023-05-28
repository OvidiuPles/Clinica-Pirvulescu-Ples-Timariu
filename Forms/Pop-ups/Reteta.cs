using MaterialSkin.Controls;
using System;
using System.Data;

namespace proiect.Forms.Pop_ups
{
    public partial class Reteta : MaterialForm
    {
        string idReteta;
        public Reteta(string idReteta)
        {
            InitializeComponent();
            CustomTheme.Set(this);
            this.idReteta = idReteta;
            ShowData();
        }

        private void ShowData()
        {
            foreach (DataRow dataRow in DataConnection.DsAfectiuni.Tables["Afectiuni"].Rows)
            {
                if (dataRow.ItemArray.GetValue(4).ToString() == idReteta)
                {
                    this.Text = "Reteta pentru " + dataRow.ItemArray.GetValue(2).ToString();
                    label_doctor.Text = "Prescrisa de Dr. " + dataRow.ItemArray.GetValue(1).ToString();
                    RetetaMultiLineTextBox.Text = dataRow.ItemArray.GetValue(3).ToString();
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reteta_Load(object sender, EventArgs e)
        {

        }
    }
}
