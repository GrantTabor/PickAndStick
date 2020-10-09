using System;

namespace PickAndStick.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<League> Leagues { get; set; }
    }
}
