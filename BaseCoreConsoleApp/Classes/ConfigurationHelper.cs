﻿using Microsoft.Extensions.Configuration;
using static BaseCoreConsoleApp.Classes.ConnectionsConfiguration;

namespace BaseCoreConsoleApp.Classes
{
    public class ConfigurationHelper
    {

        public static ConnectionsConfiguration CurrentEnvironment { get; private set; }
        /// <summary>
        /// Current connection string by 'ActiveEnvironment'
        /// </summary>
        /// <returns>Connection string</returns>
        public static string ConnectionString()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            var map = configuration.GetSection("ConnectionsConfiguration").Get<ConfigurationMap>();

            ConnectionsConfiguration environment = map.ActiveEnvironment
                .ToEnum(Development);

            CurrentEnvironment = environment;

            return environment switch
            {
                Development => map.Development,
                Stage => map.Stage,
                Production => map.Production,
                _ => map.Development
            };

        }
        /// <summary>
        /// Get all environment connection strings
        /// </summary>
        /// <returns><see cref="ConfigurationMap"/></returns>
        public static ConfigurationMap Connections()
        {
            var configuration = Builder();
            return configuration.GetSection("ConnectionsConfiguration").Get<ConfigurationMap>();
        }
        public static Settings ApplicationSettings()
        {
            var configuration = Builder();
            return configuration.GetSection("Settings").Get<Settings>();
        }

        private static IConfigurationRoot Builder()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            return configuration;
        }
    }
}
