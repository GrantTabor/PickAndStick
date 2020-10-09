using System;

namespace PickAndStick.Models
{
    public class Choice
    {
        public int Id { get; set; }
        public string OptionName { get; set; }
        public bool IsSelected { get; set; }
    }
}