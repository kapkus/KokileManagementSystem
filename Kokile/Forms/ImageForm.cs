using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Kokile.Forms
{

    public partial class ImageForm : Form
    {
        string shortBarcodeDefaultVal = "100000000100000001";
        string longBarcodeDefaultVal = "1000000001000100000001";
        BarcodeFinder barcodeFinder;
        string barcodeNumber;
        private ConfigManager configManager;
        private UserSettings userSettings;
        private SQLiteManager sqliteManager;
  

        public ImageForm(ConfigManager configManager)
        {
            InitializeComponent();
            this.configManager = configManager;
            barcodeFinder = new BarcodeFinder(barcodePictureBox, longBarcodeDefaultVal);
            LoadUserSettings();
            sqliteManager = new SQLiteManager(userSettings.databasePath);

            if(CheckDatabaseConnection())
                barcodeLabel.Text = sqliteManager.SearchForBarcodeId(longBarcodeDefaultVal).ToString();

        }

        private void BarcodePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            barcodeNumber = barcodeFinder.CalculateClickedRectangleIndex(e.X);
            if (!File.Exists(this.userSettings.databasePath)) 
            {
                barcodeLabel.Text = "Nie połączono z bazą danych";
                barcodeLabel.ForeColor = Color.Red;
                return;
            }

            barcodeLabel.ForeColor = Color.Black;
            int barcodeId = sqliteManager.SearchForBarcodeId(barcodeNumber);

            if (barcodeId == -1)
            {
                barcodeLabel.Text = "brak";
            }
            else
            {
                barcodeLabel.Text = barcodeId.ToString();
            }
        }

        private bool CheckDatabaseConnection()
        {
            if (!File.Exists(this.userSettings.databasePath))
            {
                barcodeLabel.Text = "Nie połączono z bazą danych";
                barcodeLabel.ForeColor = Color.Red;
                return false;
            }
            barcodeLabel.ForeColor = Color.Black;
            return true;
        }

        private void longRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!CheckDatabaseConnection())
                return;

            if (longRadioBtn.Checked)
            {
                barcodeFinder = new BarcodeFinder(barcodePictureBox, longBarcodeDefaultVal);
                barcodeLabel.Text = sqliteManager.SearchForBarcodeId(longBarcodeDefaultVal).ToString();
            }
        }

        private void shortRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!CheckDatabaseConnection())
                return;

            if (shortRadioBtn.Checked)
            {
                barcodeFinder = new BarcodeFinder(barcodePictureBox, shortBarcodeDefaultVal);
                barcodeLabel.Text = sqliteManager.SearchForBarcodeId(shortBarcodeDefaultVal).ToString();
            }
        }

        private void LoadUserSettings()
        {
            this.userSettings = new UserSettings();
            this.userSettings = configManager.LoadSettings();
        }

        public void UpdateConfigFromConfigManager(ConfigManager configManager)
        {
            this.configManager = configManager;
            this.userSettings = this.configManager.LoadSettings();
            sqliteManager.changeDatabasePath(userSettings.databasePath);
        }
    }
}
