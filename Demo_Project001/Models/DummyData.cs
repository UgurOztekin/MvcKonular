using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_Project001.Models
{
    public class DummyData
    {
        public static List<Player> getPlayers(AppDbContext context)
        {
            List<Player> players = new List<Player>()
            {
                new Player
                {
                    FirstName="Murat",
                    LastName="Ali",
                    TeamName = context.Teams.Find("Besiktas").TeamName,
                    Position="Back"
                },
                new Player
                {
                    FirstName="Hasan",
                    LastName="Ali",
                    TeamName = context.Teams.Find("Trabzonspor").TeamName,
                    Position="Forwad"
                }
            };

            return players;
        }

        public static List<Team> getTeams()
        {
            List<Team> teams = new List<Team>()
            {
                new Team
                {
                 City="İstanbul" ,
                 TeamName="Beşiktaş",
                },
                new Team
                {
                 City="Trabzon" ,
                 TeamName="Trabzon",
                }
            };
            return teams;
        }


    }
}