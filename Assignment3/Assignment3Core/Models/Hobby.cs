using System;
using System.Collections.ObjectModel;

namespace Assignment3Core.Models
{
    public class Hobby
    {
        public string HobbyTitle { get; set; }
        public string HobbyDescription { get; set; }

        public Hobby()
        {
        }
    }


    public class HobbiesList
    {
        public ObservableCollection<Hobby> hobbies { get; set; }
    }
}
