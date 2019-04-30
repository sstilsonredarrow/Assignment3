using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Assignment3Core.Models;
using Assignment3Core.Services;
using MvvmCross.ViewModels;

namespace Assignment3Core.ViewModels
{
    public class AboutMeViewModel : MvxViewModel
    {
        public ObservableCollection<Accomplishment> Accomplishments { get; set; }
        public Profile Profile { get; set; }
        private IAccomplishmentsGetter _accomplishmentsGetter;
        private IProfileGetter _profileGetter;


        public AboutMeViewModel(IAccomplishmentsGetter accomplishmentsGetter, IProfileGetter profileGetter)
        {
            _accomplishmentsGetter = accomplishmentsGetter;
            _profileGetter = profileGetter;
        }

        public override Task Initialize()
        {
            base.Initialize();

            Accomplishments = _accomplishmentsGetter.GetAccomplishments().Result;

            Profile = _profileGetter.GetProfile();

            return Task.Delay(0);
        }
    }
}
