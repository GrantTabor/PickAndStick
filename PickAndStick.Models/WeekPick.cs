using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PickAndStick.Models
{
    public class WeekPick
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