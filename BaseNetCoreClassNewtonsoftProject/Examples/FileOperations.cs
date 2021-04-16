using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseNetCoreClassNewtonsoftProject.Examples.Containers;
using Newtonsoft.Json;

namespace BaseNetCoreClassNewtonsoftProject.Examples
{
    public class FileOperations
    {
        public static List<DriversLicense> ReadLicenses(string fileName)
        {
            List<DriversLicense> driversLicenses = new();

            if (!File.Exists(fileName)) return driversLicenses;

            var json = File.ReadAllText(fileName);
            driversLicenses = JsonConvert.DeserializeObject<List<DriversLicense>>(json);

            return driversLicenses;
        }

        public static string GetRawData(string fileName) => File.ReadAllText(fileName);

        public static void DriversLicenseAsJson(List<DriversLicense> driversLicenseList, string fileName)
        {
            var json = JsonConvert.SerializeObject(driversLicenseList, Formatting.Indented,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });

            File.WriteAllText(fileName, json);
        }
    }
}
