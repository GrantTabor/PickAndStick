using System;
using System.Collections.Generic;

namespace PickAndStick.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<LeaguePlayer> LeaguePlayers { get; set; }
        public List<PlayerSeason> PlayerSeasons { get; set; }
    }
}
