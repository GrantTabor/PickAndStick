using System;
using System.Collections.Generic;

namespace PickAndStick.Models
{
    public class Season
    {
        public int Id { get; set; }
        public int LeagueId { get; set; }
        public List<PlayerSeason> PlayerSeasons { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate {get; set; }
    }
}
