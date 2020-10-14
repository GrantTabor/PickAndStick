using System;
using System.Collections.Generic;
using System.Text;

namespace PickAndStick.Models
{
    public class LeaguePlayer
    {
        public int PlayerId { get; set; }
        public int LeagueId { get; set; }
        public Player Player { get; set; }
        public League League { get; set; }
    }
}
