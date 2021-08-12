﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using NorthWindCoreLibrary.Models;
using System;

#nullable disable

namespace NorthWindCoreLibrary.Data
{
    public class ShippersConfiguration : IEntityTypeConfiguration<Shippers>
    {
        public void Configure(EntityTypeBuilder<Shippers> entity)
        {
            entity.HasKey(e => e.ShipperId);

            entity.Property(e => e.ShipperId)
                .ValueGeneratedNever()
                .HasColumnName("ShipperID");

            entity.Property(e => e.CompanyName)
                .IsRequired()
                .HasMaxLength(40);

            entity.Property(e => e.Phone).HasMaxLength(24);
        }
    }
}
