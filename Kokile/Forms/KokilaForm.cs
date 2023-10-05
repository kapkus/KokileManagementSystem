using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace Kokile.Forms
{
    public partial class KokilaForm : Form
    {
        public event EventHandler<DataSentEventArgs> DataSent;
        private ConfigManager configManager;
        private UserSettings userSettings;
        private SQLiteManager sqliteManager;
        private RadlistForm radlistForm;

        public KokilaForm(ConfigManager configManager)
        {
            this.configManager = configManager;
            InitializeComponent();
            LoadUserSettings();
            SetupComboBoxes();
            
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> formValues = new Dictionary<string, object>();
            formValues.Add("typFelgi", typFelgiInput.Text);
            formValues.Add("selekcja", selekcjaInput.Text);
            formValues.Add("kodKreskowy", kodKreskowyInput.Text);
            formValues.Add("zmiana", zmianaComboBox.Text);
            formValues.Add("brygada", brygadaComboBox.Text);

            if (!File.Exists(this.userSettings.databasePath))
            {
                MessageBox.Show("Nie można połączyć się z bazą danych.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string barcodeNumber = GetBarcode(kodKreskowyInput.Text);

            BarcodeCreator2D barcode2D = new BarcodeCreator2D(barcodeNumber);
            BarcodeCreator1D barcode1D = new BarcodeCreator1D(barcodeNumber);
            barcode2D.DrawBarcodes();
            barcode1D.DrawBarcode();

            formValues.Add("kodKreskowyO1", barcode2D.getFirstBitmap());
            formValues.Add("kodKreskowyO2", barcode2D.getSecondBitmap());
            formValues.Add("kodKreskowyO3", barcode1D.GetBitmap());

            WordDocumentCreator wordDocumentCreator = new WordDocumentCreator();
            wordDocumentCreator.InsertFormData(formValues);
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"data\kokila.docx"))
            {
                Process.Start(@"data\kokila.docx");
            }
            else
            {
                Process.Start(@"data\");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
            string[] data = { DateTime.Now.ToString("yyyy/MM/dd HH:mm"),
                              typFelgiInput.Text, selekcjaInput.Text,
                              kodKreskowyInput.Text, zmianaComboBox.Text,
                              brygadaComboBox.Text };

            SendData(data);
        }

        public void UpdateConfigFromConfigManager(ConfigManager configManager)
        {
            this.configManager = configManager;
            this.userSettings = this.configManager.LoadSettings();
            this.sqliteManager = new SQLiteManager(userSettings.databasePath);
        }

        private void LoadUserSettings()
        {
            this.userSettings = new UserSettings();
            this.userSettings = this.configManager.LoadSettings();
            this.sqliteManager = new SQLiteManager(userSettings.databasePath);
        }

        public void SendData(string[] data)
        {
            DataSent?.Invoke(this, new DataSentEventArgs(data));
        }

        private string GetBarcode(string barcodeId)
        {
            string barcodeNumber = "";

            if (!File.Exists(this.userSettings.databasePath))
            {
                MessageBox.Show("Nie można połączyć się z bazą danych.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return barcodeNumber;
            }

            try
            {
                barcodeNumber = sqliteManager.GetBarcodeString(barcodeId);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return barcodeNumber;
        }

        private void SetupComboBoxes()
        {
            zmianaComboBox.SelectedIndex = 0;
            brygadaComboBox.SelectedIndex = 0;
        }

        private void loadKokilaBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(this.userSettings.databasePath))
            {
                MessageBox.Show("Nie można połączyć się z bazą danych.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                typFelgiInput.Text = sqliteManager.GetKokilaFromBarcode(kodKreskowyInput.Text);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editRadlistBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(this.userSettings.databasePath))
            {
                MessageBox.Show("Nie można połączyć się z bazą danych.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            radlistForm = new RadlistForm(this.userSettings.databasePath);
            radlistForm.Show();
        }

        private void addToRadlistBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(this.userSettings.databasePath))
            {
                MessageBox.Show("Nie można połączyć się z bazą danych.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var isNumeric = int.TryParse(kodKreskowyInput.Text, out _);
            if (!isNumeric)
            {
                MessageBox.Show($"Error: kod kreskowy musi mieć wartość numeryczną.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                sqliteManager.InsertRadlistRecord(kodKreskowyInput.Text, typFelgiInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class DataSentEventArgs : EventArgs
    {
        public string[] Data { get; }

        public DataSentEventArgs(string[] data)
        {
            Data = data;
        }
    }
}
