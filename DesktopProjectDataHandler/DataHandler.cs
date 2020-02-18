using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            LoadDataFromFile();
        }

        private void LoadDataFromFile()
        {
            string dataFileContents = string.Empty;
            try {
                dataFileContents = File.ReadAllText(dataFile);
            } catch (Exception) {
                throw new Exception("Failed to read the data file.");
            }
            storedData = JsonConvert.DeserializeObject<StoredData>(dataFileContents);
            storedData.Loaded = File.GetLastWriteTime(dataFile);
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

        public Settings GetSettings()
        {
            if (storedData.Loaded != File.GetLastWriteTime(dataFile)) {
                LoadDataFromFile();
            }
            return storedData.Settings;
        }

        public void UpdateSettings(Settings settingsFromDialog)
        {
            storedData.Settings = settingsFromDialog;
            SaveDataFile();
        }

        public List<TrackedProject> GetTrackedProjects() => storedData.TrackedProjects.OrderBy(x => x.position).ToList();

        public void SaveTrackedProjects(List<TrackedProject> trackedProjects)
        {
            storedData.TrackedProjects = trackedProjects;
            SaveDataFile();
        }

        public TrackedProject GetTrackedProjectById(int pid) => storedData.TrackedProjects.Where(x => x.id == pid).FirstOrDefault();
    }
}
