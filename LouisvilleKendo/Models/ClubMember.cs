using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LouisvilleKendo.Models
{
    public class ClubMember
    {
        public int ID { get; set; }
        public int AuskfId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime StartDate { get; set; }
        public string Rank { get; set; }
        public bool FederationMember { get; set; }
        public bool CurrentMember { get; set; }
    }
}