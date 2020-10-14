using System;
using System.Collections.Generic;
using System.Text;

namespace PickAndStick.Models
{
    public class PlayerSeason
    {
        public int PlayerId { get; set; }
        public int SeasonId { get; set; }
        public Player Player { get; set; }
        public Season Season { get; set; }
    }
}
