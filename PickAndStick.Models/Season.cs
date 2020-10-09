using System;

namespace PickAndStick.Models
{
    public class Class1
    {
        public int Id { get; set; }
        public int LeagueId { get; set; }
        public List<int> PlayerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate {get; set; }
    }
}
