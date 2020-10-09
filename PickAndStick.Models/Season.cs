using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PickAndStick.Models
{
    public class Class1
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("League")]
        public int LeagueId { get; set; }
        [ForeignKey("Player")]
        public List<int> PlayerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate {get; set; }
    }
}
