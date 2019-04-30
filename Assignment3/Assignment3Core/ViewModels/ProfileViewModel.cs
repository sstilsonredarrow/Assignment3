using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment3Core.Models;
using Assignment3Core.Services;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Assignment3Core.ViewModels
{
    public class ProfileViewModel : MvxViewModel
    {
        public string Name { get; set; }
        public List<string> Hobbies { get; set; }
        public string ImageUrl { get; set; }
        public string Major { get; set; }
        public string Occupation { get; set; }
        private readonly IMvxNavigationService _navigationService;
        private IProfileGetter _profileGetter;

        public ProfileViewModel(IMvxNavigationService navService, IProfileGetter profileGetter)
        {
            _navigationService = navService;
            _profileGetter = profileGetter;
        }

        public override Task Initialize()
        {
            base.Initialize();
            Profile profile = _profileGetter.GetProfile();
            ImageUrl = profile.ImageUrl;
            Name = profile.Name;
            Hobbies = profile.Hobbies;
            Major = profile.Major;
            Occupation = profile.Occupation;
            return Task.Delay(0);
        }
    }
}
