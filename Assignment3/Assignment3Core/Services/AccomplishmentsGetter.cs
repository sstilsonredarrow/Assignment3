using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Assignment3Core.Models;
using Newtonsoft.Json;

namespace Assignment3Core.Services
{
    public class AccomplishmentsGetter : IAccomplishmentsGetter
    {
        public AccomplishmentsGetter()
        {
        }

        public Task<ObservableCollection<Accomplishment>> GetAccomplishments()
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(AccomplishmentsGetter)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("Assignment3Core.accomplishments.json");
            string text = string.Empty;
            using (var reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            AccomplishmentList AccomplishmentList = JsonConvert.DeserializeObject<AccomplishmentList>(text);
            return Task.FromResult(AccomplishmentList.accomplishments);
        }
    }
}
