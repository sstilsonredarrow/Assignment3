using System;
using System.Threading.Tasks;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Assignment3Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MainViewModel(IMvxNavigationService service)
        {
            _navigationService = service;
        }

        public override Task Initialize()
        {
            return base.Initialize();
        }
    }
}
