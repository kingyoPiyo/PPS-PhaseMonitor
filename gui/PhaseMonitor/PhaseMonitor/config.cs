using System.Configuration;

namespace PhaseMonitor
{
	public class DataMod
	{
        public string FileName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Class { get; set; }
        public string Code { get; set; }
        public string Reason { get; set; }
        public string Approver { get; set; }

        public void LogLoad()
        {
            var configFile = @"setup.conf";
            var exeFileMap = new ExeConfigurationFileMap { ExeConfigFilename = configFile };
            var config = ConfigurationManager.OpenMappedExeConfiguration(exeFileMap, ConfigurationUserLevel.None);

            // config読みだし
            FileName = config.AppSettings.Settings["FileName"].Value;
            StartTime = config.AppSettings.Settings["StartTime"].Value;
            EndTime = config.AppSettings.Settings["EndTime"].Value;
            Class = config.AppSettings.Settings["Class"].Value;
            Code = config.AppSettings.Settings["Code"].Value;
            Reason = config.AppSettings.Settings["Reason"].Value;
            Approver = config.AppSettings.Settings["Approver"].Value;
        }

        public void LogSave()
        {
            var configFile = @"setup.conf";
            var exeFileMap = new ExeConfigurationFileMap { ExeConfigFilename = configFile };
            var config = ConfigurationManager.OpenMappedExeConfiguration(exeFileMap, ConfigurationUserLevel.None);

            // config書き込み
            config.AppSettings.Settings["FileName"].Value = FileName;
            config.AppSettings.Settings["StartTime"].Value = StartTime;
            config.AppSettings.Settings["EndTime"].Value = EndTime;
            config.AppSettings.Settings["Class"].Value = Class;
            config.AppSettings.Settings["Code"].Value = Code;
            config.AppSettings.Settings["Reason"].Value = Reason;
            config.AppSettings.Settings["Approver"].Value = Approver;

            config.Save();

        }
    }
}
