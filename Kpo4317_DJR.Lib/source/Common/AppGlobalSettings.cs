using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo4317_DJR.Utility;

namespace Kpo4317_DJR.Lib
{
    public static class AppGlobalSettings
    {
        private static string _logPath;
        private static string _dataFileName;
        private static string _importSetting;

        public static void Initialize()
        {
            AppConfigUtility appConfig = new AppConfigUtility();
            _logPath = appConfig.AppSettings("logPath");
            _dataFileName = appConfig.AppSettings("dataFileName");
            _importSetting = appConfig.AppSettings("importSetting");
        }

        public static string LogPath { get { return _logPath; } }
        public static string DataFileName { get { return _dataFileName; } }
        public static string ImportSetting { get { return _importSetting; } }
    }
}
