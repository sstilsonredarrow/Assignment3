using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Assignment3Core.Models;
using Newtonsoft.Json;

namespace Assignment3Core.Services
{
    public class HobbiesGetter : IHobbiesGetter
    {
        public HobbiesGetter()
        {
        }

        public Task<ObservableCollection<Hobby>> GetHobbies()
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(HobbiesGetter)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("Assignment3Core.hobbies.json");
            string text = string.Empty;
            using (var reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            HobbiesList hobbiesList = JsonConvert.DeserializeObject<HobbiesList>(text);
            return Task.FromResult(hobbiesList.hobbies);
        }
    }
}
