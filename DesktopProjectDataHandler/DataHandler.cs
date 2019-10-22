using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DesktopProjectDataHandler
{
    public class DataHandler
    {
        private const string AppName = "AutoToggl";
        private string appdata = Environment.GetEnvironmentVariable("AppData");
        private StoredData storedData = StoredData.GetInstance();
        private static DataHandler instance = new DataHandler();
        public bool instanceLoaded = false;
        private string projectDir => Path.Combine(appdata, AppName);
        private string dataFile => Path.Combine(appdata, $@"{AppName}\{AppName.ToLower()}.json");
        private string settingsFile => Path.Combine(appdata, $@"{AppName}\settings.json");

        private DataHandler()
        {
            instanceLoaded = true;
            if (!Directory.Exists(projectDir)) {
                try {
                    Directory.CreateDirectory(projectDir);
                } catch {
                    throw new Exception("Failed to create the project directory.");
                }
            }
            if (!File.Exists(dataFile)) {
                try {
                    using (File.Create(dataFile)) { }
                } catch {
                    throw new Exception("Failed to create data file.");
                }
            }
            string dataFileContents = string.Empty;
            try {
                dataFileContents = File.ReadAllText(dataFile);
            } catch (Exception) {
                throw new Exception("Failed to read the data file.");
            }
            storedData = JsonConvert.DeserializeObject<StoredData>(dataFileContents);
            if (storedData == null) {
                storedData = StoredData.GetInstance();
            }
        }

        public static DataHandler GetInstance()
        {
            return instance;
        }

        public bool ShowMainForm() => storedData.Settings.ShowOnStart;

        public bool CloseToTray() => storedData.Settings.CloseToTray;

        private void SaveDataFile()
        {
            string jsonData = JsonConvert.SerializeObject(storedData, Formatting.Indented);
            File.WriteAllText(dataFile, jsonData);
        }

        public string GenerateNewId()
        {
            return Guid.NewGuid().ToString();
        }

        public Settings GetSettings() => storedData.Settings;

        public void UpdateSettings(Settings settingsFromDialog)
        {
            storedData.Settings = settingsFromDialog;
            SaveDataFile();
        }
    }
}
