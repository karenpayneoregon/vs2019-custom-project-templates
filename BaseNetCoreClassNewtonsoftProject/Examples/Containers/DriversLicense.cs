using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseNetCoreClassNewtonsoftProject.LanguageExtensions;

namespace BaseNetCoreClassNewtonsoftProject.Examples.Containers
{
    public class DriversLicense
    {
        public int Id { get; set; }
        public string? DriversLicenseNumber { get; set; }
        public DateTime? Birthdate { get; set; }
        public string? SsnLastFour { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? NameSuffix { get; set; }
        /// <summary>
        /// Read-only property to show name in proper/title case
        /// </summary>
        public string? FullName => $"{FirstName.ToTitleCase()} {MiddleName.ToTitleCase()} {LastName.ToTitleCase()}";
        public string? AddressLine1 { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressZipCode { get; set; }
        public string? MailingAddressLine1 { get; set; }
        public string? MailingAddressCity { get; set; }
        public string? MailingAddressZipCode { get; set; }
        public DateTime? ProcessDate { get; set; }
        public bool? DeceasedFlag { get; set; }
        public bool? WorkInLieuFlag { get; set; }
        public bool? ExpiredFlag { get; set; }
        /// <summary>
        /// Useful for debugging (we will talk about this and use
        /// many times while learning C# and VB.NET. Note when doing
        /// this in VB.NET a different syntax will be used.
        /// </summary>
        /// <returns>It depends</returns>
        public override string ToString() => $"{Id}, {DriversLicenseNumber}";

    }
}
