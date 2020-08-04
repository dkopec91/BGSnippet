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
            Settings.Default.TargetFilePath = Config.TargetFilePath;
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

            Config.SourceFilePath = Settings.Default.SourceFilePath;
            Config.TargetFilePath = Settings.Default.TargetFilePath;
            Config.SnippetWitdth = Settings.Default.SnippetWitdth;
            Config.SnippetHeight = Settings.Default.SnippetHeight;
            Config.SnippetLeft = Settings.Default.SnippetLeft;
            Config.SnippetTop = Settings.Default.SnippetTop;
            Config.Delay = Settings.Default.Delay;

            if (string.IsNullOrEmpty(Config.SourceFilePath))
            {
                Config.SourceFilePath = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Microsoft\Windows\Themes\TranscodedWallpaper";
            }
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
