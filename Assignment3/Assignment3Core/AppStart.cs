using System;
using System.Threading.Tasks;
using Assignment3Core.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Assignment3Core
{
    public class AppStart : MvxAppStart
    {
        public AppStart(IMvxApplication application,
            IMvxNavigationService navigationService) : base(application, navigationService)
        {
        }

        protected override Task NavigateToFirstViewModel(object hint = null)
        {
            return NavigationService.Navigate<ProfileViewModel>();
        }
    }
}
