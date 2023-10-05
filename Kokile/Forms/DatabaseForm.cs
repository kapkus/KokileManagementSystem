using Kokile.Database;
using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Kokile.Forms
{
    public partial class DatabaseForm : Form
    {
        private UserSettings userSettings;
        private ConfigManager configManager;
        public KokilaDataGridView dbDataGridView;
        private KokilaForm kokilaForm;

        public DatabaseForm(ConfigManager configManager, KokilaForm kokilaForm)
        {
            this.configManager = configManager;
            this.kokilaForm = kokilaForm;
            kokilaForm.DataSent += AddForm_DataSent;
            InitializeComponent();
            LoadUserSettings();
            BindDatabase(userSettings.databasePath);
            dbPathTextBox.Text = userSettings.databasePath;
        }

        private void LoadUserSettings()
        {
            this.userSettings = new UserSettings();
            this.userSettings = configManager.LoadSettings();
        }

        private void BindDatabase(string databasePath)
        {
            if (!IsDatabaseFileExists()) return;

            this.dbDataGridView = new KokilaDataGridView(databaseGridView, this.userSettings.databasePath);
            if (this.dbDataGridView.LoadDataFromDatabase())
            {
                databaseGridView.Columns[1].HeaderText = "Data";
                databaseGridView.Columns[2].HeaderText = "Typ felgi";
                databaseGridView.Columns[3].HeaderText = "Selekcja";
                databaseGridView.Columns[4].HeaderText = "Kod kreskowy";
                databaseGridView.Columns[5].HeaderText = "Zmiana";
                databaseGridView.Columns[6].HeaderText = "Brygada";
                databaseGridView.Columns[7].HeaderText = "Id";
                this.databaseGridView.Sort(this.databaseGridView.Columns["id"], ListSortDirection.Descending);

            }
        }

        private void createDatabaseBtn_Click(object sender, EventArgs e)
        {
            DatabaseCreator.Create();
            BindDatabase(userSettings.databasePath);
            IsDatabaseFileExists();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            if (!IsDatabaseFileExists())
                return;

            if (databaseGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = databaseGridView.SelectedRows[0];

                string realId = selectedRow.Cells["id"].Value.ToString();
                string previewId = selectedRow.Cells["previewId"].Value.ToString();
                string typFelgi = selectedRow.Cells["typFelgi"].Value.ToString();
                string selekcja = selectedRow.Cells["selekcja"].Value.ToString();
                string kodKreskowy = selectedRow.Cells["kodKreskowy"].Value.ToString();
                string zmiana = selectedRow.Cells["zmiana"].Value.ToString();
                string brygada = selectedRow.Cells["brygada"].Value.ToString();
                string[] rowValues = { realId, previewId, typFelgi, selekcja, kodKreskowy, zmiana, brygada };
                EditKokilaRow editRow = new EditKokilaRow(rowValues);

                editRow.DataEdited += EditRow_DataEdited;
                editRow.Show();
            }
        }

        public void UpdateConfigFromConfigManager(ConfigManager configManager)
        {
            this.configManager = configManager;
            this.userSettings = this.configManager.LoadSettings();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!IsDatabaseFileExists())
                return;

            if (databaseGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = databaseGridView.SelectedRows[0];
                int idValue = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string previewId = selectedRow.Cells["previewId"].Value.ToString();
                DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć wiersz {previewId}?", "Potwierdzenie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    dbDataGridView.DeleteRecord(idValue);
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            if (!IsDatabaseFileExists())
                return;

            dbDataGridView.LoadDataFromDatabase();
        }

        private void EditRow_DataEdited(object sender, DataEditedEventArgs e)
        {
            string[] editedData = e.EditedData;
            dbDataGridView.ModifyRecord(editedData);
        }

        private bool IsDatabaseFileExists()
        {
            bool fileExists = File.Exists(this.userSettings.databasePath);
            if (fileExists)
            {
                statusTxt.Text = "Połączono";
                statusTxt.ForeColor = Color.Green;
            }
            else
            {
                statusTxt.Text = "Nie połączono";
                statusTxt.ForeColor = Color.Red;
            }
            return fileExists;
        }


        private void AddForm_DataSent(object sender, DataSentEventArgs e)
        {
            if (!IsDatabaseFileExists()) return;
            string[] receivedData = e.Data;
            dbDataGridView.AddRecord(receivedData);

        }

        private void changeDbBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "SQLite Database Files (*.db;*.sqlite)|*.db;*.sqlite|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                dbPathTextBox.Text = selectedFilePath;
                userSettings.databasePath = selectedFilePath;
                BindDatabase(selectedFilePath);
                configManager.SaveSettings(userSettings);
            }
        }

        private void backupDatabaseBtn_Click(object sender, EventArgs e)
        {
            if (!IsDatabaseFileExists())
                return;

            const string databaseCopyPath = @"data\kokileKopia.db";
            if (File.Exists(databaseCopyPath)) 
            {
                DialogResult result = MessageBox.Show("kokileKopia.db już istnieje, czy chciałbyś ją nadpisać?", "Potwierdzenie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    BackupDatabase(userSettings.databasePath, databaseCopyPath);
                    MessageBox.Show("Pomyślnie nadpisano plik.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
            BackupDatabase(userSettings.databasePath, databaseCopyPath);
            MessageBox.Show("Pomyślnie stworzono kopię.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void BackupDatabase(string sourceFile, string destFile)
        {
            using (SQLiteConnection source = new SQLiteConnection(String.Format("Data Source = {0}", sourceFile)))
            using (SQLiteConnection destination = new SQLiteConnection(String.Format("Data Source = {0}", destFile)))
            {
                source.Open();
                destination.Open();
                source.BackupDatabase(destination, "main", "main", -1, null, -1);
            }
        }

        private void filterInput_TextChanged(object sender, EventArgs e)
        {
            if (!IsDatabaseFileExists())
                return;

            string searchCriteria = filterInput.Text;
            dbDataGridView.ApplyFilter(searchCriteria);
        }
    }

    public class DatabaseGridViewEventArgs : EventArgs
    {
        public KokilaDataGridView DatabaseGridView { get; }

        public DatabaseGridViewEventArgs(KokilaDataGridView databaseGridView)
        {
            DatabaseGridView = databaseGridView;
        }
    }
}
