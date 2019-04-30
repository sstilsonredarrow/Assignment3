using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Assignment3Core.Models;
using Newtonsoft.Json;

namespace Assignment3Core.Services
{
    public class ProfileGetter : IProfileGetter
    {
        public Profile GetProfile()
        {
            return new Profile
            {
                FirstName = "Nicholas",
                LastName = "Flaig",
                Education = "MSTC Student",
                Age = 20,
                BirthDate = "June 3, 1998",
                Gender = "Male"
            };
        }
    }
}
