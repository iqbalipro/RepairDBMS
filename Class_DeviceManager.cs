using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RepairDBMS
{
    // Public so it can be returned from a public method
    public class Class_DeviceManager
    {
        public string DeviceName { get; set; }
        public string SerialNumber { get; set; }
        public string IOSVersion { get; set; }
        public string IMEI { get; set; }
        public string ICCID { get; set; }
    }

    public static class IPhoneDeviceManager
    {
        private static string RunIdeviceInfo(string arguments = "")
        {
            string exePath = Class_ConfigManager.IDeviceExePath;

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = exePath,
                Arguments = arguments,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(psi))
            {
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                return output;
            }
        }

        private static string ExtractValue(string output, string key)
        {
            // Split by both \r\n and \n to handle all cases
            var lines = output.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                if (line.StartsWith(key))
                {
                    return line.Substring(key.Length + 1).Trim(); // Remove key and colon
                }
            }
            return string.Empty;
        }

        public static Class_DeviceManager GetDeviceInfo()
        {
            try
            {
                string output = RunIdeviceInfo();
                return new Class_DeviceManager
                {
                    DeviceName = ExtractValue(output, "DeviceName"),
                    SerialNumber = ExtractValue(output, "SerialNumber"),
                    IOSVersion = ExtractValue(output, "ProductVersion"),
                    IMEI = ExtractValue(output, "InternationalMobileEquipmentIdentity"),
                    ICCID = ExtractValue(output, "IntegratedCircuitCardIdentity")
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("No iPhone connected or error: " + ex.Message);
                return null;
            }
        }
    }
}
