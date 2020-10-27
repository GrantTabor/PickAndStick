using PickAndStick.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PickAndStick.Domain.PickInputs
{
    public class PickInput
    {
        public List<Choice> Choices { get; set; }
        public int Confidence { get; set; }
        public int WeekPickId { get; set; }
    }
}
