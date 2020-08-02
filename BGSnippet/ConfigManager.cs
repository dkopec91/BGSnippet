using System;
using System.Windows.Forms;
using BGSnippet.Properties;
using Microsoft.Win32;

namespace BGSnippet
{
    static class ConfigManager
    {
        private static string BGSnippet = "BGSnippet";
        private static RegistryKey appKey;

        static public void SaveSettings()
        {
            Settings.Default.SourceFilePath = Config.SourceFilePath;
            Settings.Default.SourceFileName = Config.SourceFileName;
            Settings.Default.TargetFilePath = Config.TargetFilePath;
            Settings.Default.TargetFileName = Config.TargetFileName;
            Settings.Default.SnippetWitdth = Config.SnippetWitdth;
            Settings.Default.SnippetHeight = Config.SnippetHeight;
            Settings.Default.SnippetLeft = Config.SnippetLeft;
            Settings.Default.SnippetTop = Config.SnippetTop;
            Settings.Default.Delay = Config.Delay;
            Settings.Default.Save();
        }

        static public void LoadSettings()
        {
            appKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            Config.Autostart = RunsOnSystemStartup;

            if (Settings.Default.SourceFilePath == string.Empty)
            {
                SetDefaults();
            }
            else
            {
                LoadUserSettings();
            }
        }

        public static void LoadUserSettings()
        {
            Config.SourceFilePath = Settings.Default.SourceFilePath;
            Config.SourceFileName = Settings.Default.SourceFileName;
            Config.TargetFilePath = Settings.Default.TargetFilePath;
            Config.TargetFileName = Settings.Default.TargetFileName;
            Config.SnippetWitdth = Settings.Default.SnippetWitdth;
            Config.SnippetHeight = Settings.Default.SnippetHeight;
            Config.SnippetLeft = Settings.Default.SnippetLeft;
            Config.SnippetTop = Settings.Default.SnippetTop;
            Config.Delay = Settings.Default.Delay;
        }

        public static void SetDefaults()
        {
            Config.SourceFilePath = String.Format(@"C:\Users\{0}\AppData\Roaming\Microsoft\Windows\Themes", Environment.UserName);
            Config.SourceFileName = "TranscodedWallpaper";
            Config.TargetFilePath = "C:\\Aida";
            Config.TargetFileName = "bg.png";
            Config.SnippetWitdth = 500;
            Config.SnippetHeight = 600;
            Config.SnippetLeft = 0;
            Config.SnippetTop = 0;
            Config.Delay = 300;
        }

        public static string GetFileNameFromFullPath(string FullPath)
        {
            string[] split = FullPath.Split('\\');
            return split[split.Length - 1];
        }

        public static string GetFilePathFromFullPath(string FullPath)
        {
            string[] split = FullPath.Split('\\');
            return FullPath.Substring(0, FullPath.Length - split[split.Length - 1].Length - 1);
        }

        public static bool RunsOnSystemStartup => appKey.GetValue(BGSnippet) != null;

        public static void SetRunOnSystemStartup(bool runOnSystemStartup)
        {
            var currentRegistryKeyValue = appKey.GetValue(BGSnippet)?.ToString();
            var currentExecutablePath = Application.ExecutablePath;

            if (runOnSystemStartup)
            {
                appKey.SetValue(BGSnippet, currentExecutablePath);
                MessageBox.Show(
                    string.Format(Resources.AutostartOnMessage, currentExecutablePath),
                    Resources.AutostartOnTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            else if (RunsOnSystemStartup)
            {
                appKey.DeleteValue(BGSnippet);
                MessageBox.Show(
                    string.Format(Resources.AutostartOffMessage, currentRegistryKeyValue),
                    Resources.AutostartOffTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }

}
