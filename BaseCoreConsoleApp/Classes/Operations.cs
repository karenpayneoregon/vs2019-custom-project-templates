﻿namespace BaseCoreConsoleApp.Classes
{
    public class Operations
    {
        public static string ConnectionString() => ConfigurationHelper.ConnectionString();

        public static Settings ApplicationSettings() => ConfigurationHelper.ApplicationSettings();
    }
}
