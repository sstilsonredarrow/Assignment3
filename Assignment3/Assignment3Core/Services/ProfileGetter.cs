using System;
using System.Collections.Generic;
using Assignment3Core.Models;

namespace Assignment3Core.Services
{
    public class ProfileGetter : IProfileGetter
    {
        public ProfileGetter()
        {
        }

        public Profile GetProfile()
        {
            Profile profile = new Profile
            {
                Name = "Josh White",
                Hobbies = new List<string>
        {
            "Ultimate Frisbee",
            "Disc Golf",
            "Hiking"
        },
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51ZvOJci6+L.jpg",
                Major = "Software Development",
                Occupation = "Custom Arcade Technician"
            };

            return profile;
        }
    }
}
