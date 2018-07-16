using LouisvilleKendo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace LouisvilleKendo.DAL
{
    public class ClubContext : DbContext
    {
        public ClubContext() : base("ClubContext")
        { 
        }

        public DbSet<ClubMember> ClubMembers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}