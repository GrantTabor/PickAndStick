using System;

namespace PickAndStick.Models
{
    public class Player
    {
        [key]
        public int Id { get; set; }
        [ForeignKey("Player")]
        public int PlayerId { get; set; }
        [ForeignKey("Pick")]
        public List<Pick> PicksByConfidence { get; set; }

        public int TotalPoints { get; set; }
        [ForeignKey("Season")]
        public int SeasonId { get; set; }
    }
}