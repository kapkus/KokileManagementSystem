using System;
using System.IO;
using System.Text.Json;

namespace Kokile
{
    public class UserSettings
    {
        public string databasePath { get; set; }
        public string outputFilePath { get; set; }
    }

    public class ConfigManager
    {
        private readonly string configFileName;
        public delegate void ConfigUpdatedEventHandler(object sender, EventArgs e);
        public event ConfigUpdatedEventHandler ConfigUpdated;

        public ConfigManager(string configFileName = "config.json")
        {
            this.configFileName = configFileName;
            CreateConfig();
        }

        private void CreateConfig() 
        {
            string json;
            if (!File.Exists(configFileName))
            {
                using (File.Create(configFileName))
                {
                    UserSettings userSettings = new UserSettings();
                    userSettings.databasePath = Path.GetFullPath(@"data\kokile.db");
                    userSettings.outputFilePath = Path.GetFullPath("data");
                    json = JsonSerializer.Serialize(userSettings);
                }
                File.WriteAllText(configFileName, json);
            }
        }

        public UserSettings LoadSettings()
        {
            if (File.Exists(configFileName))
            {
                string json = File.ReadAllText(configFileName);
                return JsonSerializer.Deserialize<UserSettings>(json);
            }

            return null;
        }

        public void SaveSettings(UserSettings settings)
        {
            string json = JsonSerializer.Serialize(settings);
            File.WriteAllText(configFileName, json);
            OnConfigUpdated();
        }

        public void AddOrUpdateSetting(string key, string value)
        {
            UserSettings settings = LoadSettings() ?? new UserSettings();

            switch (key)
            {
                case "databasePath":
                    settings.databasePath = value;
                    break;
                case "outputFilePath":
                    settings.outputFilePath = value;
                    break;
                default:
                    throw new ArgumentException($"Invalid key: {key}");
            }

            SaveSettings(settings);
        }

        public void DeleteSetting(string key)
        {
            UserSettings settings = LoadSettings();

            if (settings == null)
                return;

            switch (key)
            {
                case "databasePath":
                    settings.databasePath = null;
                    break;
                case "outputFilePath":
                    settings.outputFilePath = null;
                    break;
                default:
                    throw new ArgumentException($"Invalid key: {key}");
            }

            SaveSettings(settings);
        }
        protected virtual void OnConfigUpdated()
        {
            ConfigUpdated?.Invoke(this, EventArgs.Empty);
        }

    }
}
