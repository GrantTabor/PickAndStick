using System;

namespace PickAndStick.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        
    }
}
