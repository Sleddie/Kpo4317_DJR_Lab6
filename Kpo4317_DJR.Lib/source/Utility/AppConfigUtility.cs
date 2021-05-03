using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Kpo4317_DJR.Utility
{
    public class AppConfigUtility
    {
        public string AppSettings(string name)
        {
            string appSettings = ConfigurationManager.AppSettings[name];
            return (appSettings != null ? appSettings : "");
        }
    }
}
