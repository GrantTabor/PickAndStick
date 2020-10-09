using System;

namespace PickAndStick.Models
{
    public class Player
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public List<Pick> PicksByConfidence { get; set; }
        public int TotalPoints { get; set; }
        public int SeasonId { get; set; }
    }
}