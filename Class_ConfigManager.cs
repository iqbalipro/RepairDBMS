using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairDBMS
{
    internal class Class_ConfigManager
    {
        private static readonly Dictionary<string, string> _settings = new Dictionary<string, string>();
        private static readonly string configFile = @"C:\Users\iqbal\OneDrive\VisualStudio\connection.txt";

        static Class_ConfigManager()
        {
            LoadConfig();
        }

        private static void LoadConfig()
        {
            if (!File.Exists(configFile))
            {
                // Optional: create default file if missing
                File.WriteAllLines(configFile, new string[]
                {
                    "DBConnection=Data Source=.;Initial Catalog=RepairDB;Integrated Security=True",
                    "LibMobileDevice=C:\\Users\\iqbal\\OneDrive\\VisualStudio\\RepairDBMS\\libmobiledevice\\",
                    "Logs=C:\\Users\\iqbal\\OneDrive\\VisualStudio\\RepairDBMS\\Logs\\"
                });
            }

            foreach (var line in File.ReadAllLines(configFile))
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                    continue;

                var parts = line.Split(new char[] { '=' }, 2);
                if (parts.Length == 2)
                    _settings[parts[0].Trim()] = parts[1].Trim();
            }
        }

        public static string Get(string key, string defaultValue = "")
        {
            return _settings.ContainsKey(key) ? _settings[key] : defaultValue;
        }

        public static void Set(string key, string value)
        {
            _settings[key] = value;
            SaveConfig();
        }

        private static void SaveConfig()
        {
            List<string> lines = new List<string>();
            foreach (var kvp in _settings)
                lines.Add($"{kvp.Key}={kvp.Value}");
            File.WriteAllLines(configFile, lines);
        }

        // Convenient properties
        public static string DBConnection => Get("DBConnection");
        public static string LibMobileDevice => Get("LibMobileDevice");
        public static string LogsFolder => Get("Logs");

        public static string IDeviceExePath => Path.Combine(LibMobileDevice, "ideviceinfo.exe");
    }
}


                //// Database connection
                //string conn = ConfigManager.DBConnection;

                //// Path to ideviceinfo.exe
                //string idevicePath = ConfigManager.IDeviceExePath;

                //// Logs folder
                //string logs = ConfigManager.LogsFolder;

                //// Update a setting dynamically
                //ConfigManager.Set("DBConnection", "Data Source=.;Initial Catalog=RepairDB_New;Integrated Security=True");


