using System;
using System.Collections.ObjectModel;

namespace Assignment3Core.Models
{
    public class Job
    {
        public string JobTitle { get; set; }
        public string JobLocation { get; set; }

        public Job()
        {
        }
    }

    public class JobList
    {
        public ObservableCollection<Job> jobs { get; set; }
    }
}
