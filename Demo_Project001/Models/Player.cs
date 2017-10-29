using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_Project001.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public string TeamName { get; set; }
        public Team Team { get; set; }

    }
}