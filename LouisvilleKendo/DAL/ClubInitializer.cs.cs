using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LouisvilleKendo.Models;

namespace LouisvilleKendo.DAL
{
    public class ClubInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ClubContext>
    {
        protected override void Seed(ClubContext context)
        {
            var students = new List<ClubMember>
            {
            new ClubMember{AuskfId=717,LastName="Hahn",FirstName="Elizabeth",StartDate=DateTime.Parse("2004-04-15"),Rank="3 Dan",FederationMember=true,CurrentMember=true},
            new ClubMember{AuskfId=10612,LastName="Floro",FirstName="Mariano",StartDate=DateTime.Parse("2004-04-15"),Rank="2 Dan",FederationMember=true,CurrentMember=true},
            new ClubMember{AuskfId=13615,LastName="Goldschmidt",FirstName="Eric",StartDate=DateTime.Parse("2004-04-15"),Rank="1 Dan",FederationMember=false,CurrentMember=false},
            new ClubMember{AuskfId=15607,LastName="West",FirstName="Adam",StartDate=DateTime.Parse("2004-04-15"),Rank="2 Dan",FederationMember=true,CurrentMember=true},
            new ClubMember{AuskfId=17312,LastName="Brown",FirstName="Steven",StartDate=DateTime.Parse("2004-04-15"),Rank="4 Kyu",FederationMember=true,CurrentMember=true},
            new ClubMember{AuskfId=17313,LastName="Brown",FirstName="Faith",StartDate=DateTime.Parse("2004-04-15"),Rank="none",FederationMember=false,CurrentMember=false},
            };

            students.ForEach(s => context.ClubMembers.Add(s));
            context.SaveChanges();
        }
    }
}