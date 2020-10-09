using System;

namespace PickAndStick.Models
{
    public class League
    {
        [key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Player")]
        public List<Player> Players { get; set; }
        
    }
}
