using System;

namespace PickAndStick.Models
{
    public class Player
    {
        [key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [ForeignKey("League")]
        public List<League> Leagues { get; set; }
    }
}
