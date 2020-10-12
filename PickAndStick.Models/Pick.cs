using System;
using System.Collections.Generic;

namespace PickAndStick.Models
{
    public class Pick
    {
        public int Id { get; set; }
        public List<Choice> Choices { get; set; }
        public int Confidence { get; set; }
        public int WeekPickId { get; set; }
    }
}