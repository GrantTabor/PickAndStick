using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PickAndStick.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<LeaguePlayer> LeaguePlayers { get; set; }
        
    }
}
