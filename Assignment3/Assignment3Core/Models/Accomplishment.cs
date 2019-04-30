using System;
using System.Collections.ObjectModel;

namespace Assignment3Core.Models
{
    public class Accomplishment
    {
        public string AccomplishmentDescription { get; set; }

        public Accomplishment()
        {
        }
    }


    public class AccomplishmentList
    {
        public ObservableCollection<Accomplishment> accomplishments { get; set; }
    }
}
