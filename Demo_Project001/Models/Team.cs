using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo_Project001.Models
{
    public class Team
    {
        [Key]
        [MaxLength(30)]
        public string TeamName { get; set; }

        [MaxLength(100)]
        public string City { get; set; }


        public List<Player> Players { get; set; }

    }
}