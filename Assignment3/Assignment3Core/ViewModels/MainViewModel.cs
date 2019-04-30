using System;
using System.Collections.Generic;
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

        public override async void ViewAppearing()
        {
            await ShowInitialViewModels();
            base.ViewAppearing();
        }

        private async Task ShowInitialViewModels()
        {
            var tasks = new List<Task>();
            //tasks.Add(_navigationService.Navigate<HobbiesViewModel>());
            await Task.WhenAll(tasks);
        }
    }
}
