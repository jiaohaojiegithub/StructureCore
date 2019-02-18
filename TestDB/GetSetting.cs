using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDB
{
    public static class GetSetting
    {
        /// <summary>
        /// json配置文件读取
        /// </summary>
        /// <param name="configFileName"></param>
        /// <param name="basePath"></param>
        /// <returns></returns>
        public static IConfigurationRoot GetJsonConfig(
         string configFileName = "appsettings.json",
         string basePath = "")
        {
            basePath = string.IsNullOrWhiteSpace(basePath) ? AppContext.BaseDirectory : basePath;//Directory.GetCurrentDirectory()
            var builder = new ConfigurationBuilder().
             SetBasePath(basePath).
             AddJsonFile(configFileName,true,true);
            return builder.Build();
        }
        /// <summary>
        /// xml配置文件读取
        /// </summary>
        /// <param name="configFileName"></param>
        /// <param name="basePath"></param>
        /// <returns></returns>
        public static IConfigurationRoot GetXmlConfig(
         string configFileName = "appsettings.xml",
         string basePath = "")
        {
            basePath = string.IsNullOrWhiteSpace(basePath) ? AppContext.BaseDirectory : basePath;//Directory.GetCurrentDirectory()
            var builder = new ConfigurationBuilder().
             //SetBasePath(basePath).
             AddXmlFile(b =>
             {
                 b.Path = configFileName;
                 b.FileProvider = new PhysicalFileProvider(basePath);
             });
            return builder.Build();
        }

    }
}
