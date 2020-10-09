using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PickAndStick.Models
{
    public class Pick
    {
        [key]
        public int Id { get; set; }
        [ForeignKey("Choice")]
        public List<Choice> Choices { get; set; }
        public int Confidence { get; set; }
        [ForeignKey("WeekPick")]
        public int WeekPickId { get; set; }
    }
}