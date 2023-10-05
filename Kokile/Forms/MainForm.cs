using Kokile.Forms;
using System;
using System.Windows.Forms;

namespace Kokile
{

    public partial class MainForm : Form
    {
        public ConfigManager configManager;
        private DatabaseForm databaseForm;
        private KokilaForm kokilaForm;
        private ImageForm imageForm;

        public MainForm()
        {
            InitializeComponent();
            InitializeConfig();
            InitializeTabLayout();
            configManager.ConfigUpdated += ConfigManager_ConfigUpdated;
        }

        private void InitializeConfig()
        {
            this.configManager = new ConfigManager();
        }

        private void InitializeTabLayout()
        {
            kokilaForm = new KokilaForm(configManager);
            databaseForm = new DatabaseForm(configManager, kokilaForm);
            imageForm = new ImageForm(configManager);

            kokilaForm.TopLevel = false;
            kokilaForm.ControlBox = false;
            kokilaForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            databaseForm.TopLevel = false;
            databaseForm.ControlBox = false;
            databaseForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            imageForm.TopLevel = false;
            imageForm.ControlBox = false;
            imageForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            var tabPage1 = new TabPage("Dodaj kokile");
            var tabPage2 = new TabPage("Lista kokil");
            var tabPage3 = new TabPage("Kod kreskowy");
            
            tabPage1.Controls.Add(kokilaForm);
            tabPage2.Controls.Add(databaseForm);
            tabPage3.Controls.Add(imageForm);

            tabControl.TabPages.Add(tabPage1);
            tabControl.TabPages.Add(tabPage2);
            tabControl.TabPages.Add(tabPage3);

            kokilaForm.Dock = DockStyle.Fill;
            databaseForm.Dock = DockStyle.Fill;
            imageForm.Dock = DockStyle.Fill;

            kokilaForm.Show();
            databaseForm.Show();
            imageForm.Show();
        }

        private void ConfigManager_ConfigUpdated(object sender, EventArgs e)
        {
            kokilaForm.UpdateConfigFromConfigManager(configManager);
            databaseForm.UpdateConfigFromConfigManager(configManager);
            imageForm.UpdateConfigFromConfigManager(configManager);
        }
    }
}
