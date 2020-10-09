using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace PickAndStick.Models
{
    public class Choice
    {
        [key]
        public int Id { get; set; }
        public string OptionName { get; set; }
        public bool IsSelected { get; set; }
    }
}