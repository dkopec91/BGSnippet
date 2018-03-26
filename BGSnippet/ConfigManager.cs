using System;
using System.IO;
using System.Xml.Serialization;

namespace BGSnippet
{
    static class ConfigManager
    {
        static public void SerializeSettings()
        {
            XmlSerializer SettingsSerializer = new XmlSerializer(typeof(SerializableConfig));
            SerializableConfig CurrentAppConfig = new SerializableConfig
            {
                SourceFilePath = Config.SourceFilePath,
                SourceFileName = Config.SourceFileName,
                TargetFileName = Config.TargetFileName,
                TargetFilePath = Config.TargetFilePath,
                SnippetHeight = Config.SnippetHeight,
                SnippetWitdth = Config.SnippetWitdth,
                SnippetLeft = Config.SnippetLeft,
                SnippetTop = Config.SnippetTop,
                Delay = Config.Delay
            };

            using (FileStream fs = new FileStream(AppContext.BaseDirectory + "\\config.xml", FileMode.Create))
            {
                SettingsSerializer.Serialize(fs, CurrentAppConfig);
            }
        }

        static public void DeserializeSettings()
        {
            XmlSerializer SettingsSerializer = new XmlSerializer(typeof(SerializableConfig));
            SerializableConfig CurrentAppConfig = new SerializableConfig();
            try
            {
                using (FileStream fs = new FileStream(AppContext.BaseDirectory + "\\config.xml", FileMode.Open))
                {
                    CurrentAppConfig = (SerializableConfig)SettingsSerializer.Deserialize(fs);
                }
                Config.SourceFilePath = CurrentAppConfig.SourceFilePath;
                Config.SourceFileName = CurrentAppConfig.SourceFileName;
                Config.TargetFileName = CurrentAppConfig.TargetFileName;
                Config.TargetFilePath = CurrentAppConfig.TargetFilePath;
                Config.SnippetHeight = CurrentAppConfig.SnippetHeight;
                Config.SnippetWitdth = CurrentAppConfig.SnippetWitdth;
                Config.SnippetLeft = CurrentAppConfig.SnippetLeft;
                Config.SnippetTop = CurrentAppConfig.SnippetTop;
                Config.Delay = CurrentAppConfig.Delay;
            }

            catch (Exception ex)
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
        }

        public static string GetFileNameFromFullPath(string FullPath)
        {
            string[] split = FullPath.Split('\\');
            return split[split.Length-1];
        }

        public static string GetFilePathFromFullPath(string FullPath)
        {
            string[] split = FullPath.Split('\\');
            return FullPath.Substring(0,FullPath.Length - split[split.Length - 1].Length -1);
        }
    }

}
