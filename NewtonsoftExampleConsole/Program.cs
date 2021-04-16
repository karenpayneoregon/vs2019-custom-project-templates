using System;
using System.Collections.Generic;
using System.Linq;
using BaseNetCoreClassNewtonsoftProject.Examples;
using BaseNetCoreClassNewtonsoftProject.Examples.Containers;
using BaseNetCoreClassNewtonsoftProject.LanguageExtensions;

namespace NewtonsoftExampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "driversLicenses.json";
            var licenseList = FileOperations.ReadLicenses(fileName);
            
            Console.WriteLine("Licenses");
            foreach (var driversLicense in licenseList)
            {
                Console.WriteLine(driversLicense);
            }

            Separator();
            
            WhereConditionForBirthday(licenseList);

            Separator();

            Console.WriteLine("Is array");
            
            IsArray();
            
            Separator();

            Console.ReadLine();
        }
        /// <summary>
        /// Use LINQ/Lambda to get birthday after a specific year
        /// </summary>
        /// <param name="licenseList">list of <see cref="DriversLicense"/></param>
        private static void WhereConditionForBirthday(IEnumerable<DriversLicense> licenseList)
        {
            var birthYear = 1997;
            
            Console.WriteLine($"Birth year is >= {birthYear}");
            
            IEnumerable<DriversLicense> yearResult = licenseList
                .Where(license => license.Birthdate is not null && license.Birthdate.Value.Year >= birthYear);

            foreach (var driversLicense in yearResult)
            {
                if (driversLicense.Birthdate is not null)
                {
                    Console.WriteLine($"{driversLicense.FullName} was born {driversLicense.Birthdate.Value:d}");
                }
            }

            var fileName = $"driversLicensesBirthdays{birthYear}.json";
            
            FileOperations.DriversLicenseAsJson(yearResult.ToList(), fileName);

        }

        static void IsArray()
        {
            var fileName = "driversLicenses.json";
            Console.WriteLine(FileOperations.GetRawData(fileName).IsJsonArray());

            var json = JsonForIsArray();
            Console.WriteLine(json.IsJsonArray());
        }

        private static string JsonForIsArray() =>
 @"
   {
    ""Id"": 1,
    ""DriversLicenseNumber"": ""000000006"",
    ""Birthdate"": ""1983-07-12T00:00:00"",
    ""SsnLastFour"": ""1111"",
    ""LastName"": ""LEE"",
    ""FirstName"": ""JOE"",
    ""MiddleName"": ""PARUS"",
    ""NameSuffix"": ""(null)"",
    ""FullName"": ""Joe Maureen Parus Lee"",
    ""AddressLine1"": ""1295 WASHINGTON ST"",
    ""AddressCity"": ""PORTLAND"",
    ""AddressZipCode"": ""97211"",
    ""MailingAddressLine1"": """",
    ""MailingAddressCity"": """",
    ""ProcessDate"": ""2016-05-03T00:00:00"",
    ""DeceasedFlag"": false,
    ""WorkInLieuFlag"": false,
    ""ExpiredFlag"": false
  }";

        static void Separator() => Console.WriteLine(new string('-', 50));
    }
}
