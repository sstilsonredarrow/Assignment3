using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Assignment3Core.Models;
using Newtonsoft.Json;

namespace Assignment3Core.Services
{
    public class JobGetter : IJobGetter
    {
        public JobGetter()
        {
        }

        public ObservableCollection<Job> GetJobs()
        {
            return new ObservableCollection<Job>()
            {
                new Job
                {
                    JobTitle = "Kitchen/Dishroom Worker",
                    JobLocation = "Camp Fairwood"
                },
                new Job
                {
                    JobTitle = "Print Specialist",
                    JobLocation = "The UPS Store"
                },
                new Job
                {
                    JobTitle = "Camp Counselor",
                    JobLocation = "Camp Fairwood"
                }
            };
        }
    }
}
