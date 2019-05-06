using System;
using System.Collections.Generic;
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
        public ProfileGetter()
        {
        }

        public Task<ObservableCollection<Profile>> GetProfile()
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(ProfileGetter)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("Assignment3Core.profile.json");
            string text = string.Empty;
            using (var reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            ProfileList profileList = JsonConvert.DeserializeObject<ProfileList>(text);
            return Task.FromResult(profileList.profile);
        }
    }
}
