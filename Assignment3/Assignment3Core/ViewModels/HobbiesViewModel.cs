using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Assignment3Core.Models;
using Assignment3Core.Services;
using MvvmCross.ViewModels;

namespace Assignment3Core.ViewModels
{
    public class HobbiesViewModel : MvxViewModel
    {
        public ObservableCollection<Hobby> Hobbies { get; set; }
        private IHobbiesGetter _hobbiesGetter;


        public HobbiesViewModel(IHobbiesGetter hobbiesGetter)
        {
            _hobbiesGetter = hobbiesGetter;
        }

        public override Task Initialize()
        {
            base.Initialize();

            Hobbies = _hobbiesGetter.GetHobbies().Result;

            return Task.Delay(0);
        }
    }
}
