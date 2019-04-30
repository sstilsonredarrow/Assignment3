using System;
using System.Threading.Tasks;
using MvvmCross.ViewModels;

namespace Assignment3Core.ViewModels
{
    public class WebViewModel : MvxViewModel
    {
        public string url { get; set; }
        public WebViewModel()
        {
        }

        public override Task Initialize()
        {
            base.Initialize();
            url = "http://www.cutestpaw.com/tag/cats/";
            RaisePropertyChanged(nameof(url));
            return Task.Delay(0);
        }
    }
}
