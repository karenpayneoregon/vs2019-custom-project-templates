﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

#nullable disable

namespace NorthWindCoreLibrary.Models
{
    public partial class Contacts
    {
        public Contacts()
        {
            ContactDevices = new HashSet<ContactDevices>();
            Customers = new HashSet<Customers>();
        }

        /// <summary>
        /// Id
        /// </summary>
        public int ContactId { get; set; }
        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Contact Type Id
        /// </summary>
        [JsonIgnore]
        public int? ContactTypeIdentifier { get; set; }
        [JsonIgnore]
        public virtual ContactType ContactTypeIdentifierNavigation { get; set; }
        public virtual ICollection<ContactDevices> ContactDevices { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }
    }
}