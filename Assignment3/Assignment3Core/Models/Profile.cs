using System;
using System.Collections.Generic;

namespace Assignment3Core.Models
{
    public class Profile
    {
        public string Name { get; set; }
        public List<string> Hobbies { get; set; }
        public string ImageUrl { get; set; }
        public string Major { get; set; }
        public string Occupation { get; set; }

        public Profile()
        {
        }
    }
}
