namespace Demo_Project001.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Demo_Project001.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Demo_Project001.Models.AppDbContext context)
        {
            context.Teams.AddOrUpdate(t => t.TeamName, DummyData.getTeams().ToArray());
            context.SaveChanges();

            context.Players.AddOrUpdate(p => new { p.FirstName, p.LastName }, DummyData.getPlayers(context).ToArray());
            context.SaveChanges();
        }
    }
}
