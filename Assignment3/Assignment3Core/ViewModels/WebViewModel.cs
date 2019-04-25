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
            url = "http://softdev.mstclab.com/oolson/webdesign_spring2018/COMPLETE_finalproject_olson/webpage_olson/resume.html";
            RaisePropertyChanged(nameof(url));
            return Task.Delay(0);
        }
    }
}
