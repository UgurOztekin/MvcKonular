using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Demo_Project001.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("TakimlarDB")
        {

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}