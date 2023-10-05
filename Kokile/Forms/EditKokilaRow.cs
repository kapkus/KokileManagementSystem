using System;
using System.Windows.Forms;

namespace Kokile.Forms
{
    public partial class EditKokilaRow : Form
    {
        public event EventHandler<DataEditedEventArgs> DataEdited;
        private string id;

        public EditKokilaRow(string[] rowValues)
        {
            InitializeComponent();
            FillForm(rowValues);
        }

        private void FillForm(string[] rowValues)
        {
            this.id = rowValues[0];
            rowIndexLabel.Text = rowValues[1];
            typFelgiInput.Text = rowValues[2];
            selekcjaInput.Text = rowValues[3];
            kodKreskowyInput.Text = rowValues[4];
            zmianaComboBox.Text = rowValues[5];
            brygadaComboBox.Text = rowValues[6];
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string[] editedData = {
                this.id,
                typFelgiInput.Text,
                selekcjaInput.Text,
                kodKreskowyInput.Text,
                zmianaComboBox.Text,
                brygadaComboBox.Text
            };

            DataEdited?.Invoke(this, new DataEditedEventArgs(editedData));
            this.Close();
        }
    }

    public class DataEditedEventArgs : EventArgs
    {
        public string[] EditedData { get; }

        public DataEditedEventArgs(string[] editedData)
        {
            EditedData = editedData;
        }
    }
}
