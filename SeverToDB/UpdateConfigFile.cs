using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeverToDB
{
    public class UpdateConfigFile
    {
        public string GetConnStr()
        {
            Configuration config = GetConfig();
            var connectionString =
                config.ConnectionStrings.ConnectionStrings["Entities2"].ConnectionString.ToString();
            return connectionString;
        }

        private static Configuration GetConfig()
        {
            var stringPath = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(stringPath);
            return config;
        }

        public void UpdateStr(string connStr, string providerName)
        {
            var config = GetConfig();
            config.ConnectionStrings.ConnectionStrings.Remove("Entities2");
            ConnectionStringSettings mySettings =
                new ConnectionStringSettings("Entities2", connStr, providerName);
            config.ConnectionStrings.ConnectionStrings.Add(mySettings);
            // 保存对配置文件所作的更改  
            config.Save(ConfigurationSaveMode.Modified);
            // 强制重新载入配置文件的ConnectionStrings配置节  
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        //private void UpdateSeverToDBConfig(string connStr, string providerName)
        //{
        //    var stringPath = System.Windows.Forms.Application.ExecutablePath;
        //}
    }
}
