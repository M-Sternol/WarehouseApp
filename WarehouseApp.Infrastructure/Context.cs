﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Emit;
using WarehouseApp.Domain.Model;

namespace WarehouseApp.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<ContactDetailType> ContactDetailTypes { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerContactInformation> CustomerContactInformation { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemTag> ItemTag { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<WarehouseApp.Domain.Model.Type> Types { get; set; }

        public Context(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Customer>()
                .HasOne(a => a.CustomerContactInformation).WithOne(b => b.Cusomters)
                .HasForeignKey<CustomerContactInformation>(e => e.CustomerRef);

            builder.Entity<ItemTag>()
                .HasKey(it => new { it.ItemId, it.TagId });

            builder.Entity<ItemTag>()
                   .HasOne<Item>(it => it.Item)
                   .WithMany(i => i.ItemTags)
                   .HasForeignKey(it => it.ItemId);

            builder.Entity<ItemTag>()
                .HasOne<Tag>(it => it.Tag)
                .WithMany(t => t.ItemTags)
                .HasForeignKey(it => it.TagId);
            

        }
    }
}