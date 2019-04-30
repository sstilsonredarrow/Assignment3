using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Assignment3Core.Models;
using Assignment3Core.Services;
using MvvmCross.ViewModels;

namespace Assignment3Core.ViewModels
{
    public class AboutViewModel : MvxViewModel
    {
        public ObservableCollection<Job> Jobs { get; set; }
        private IJobGetter _jobGetter;

        public AboutViewModel(IJobGetter jobGetter)
        {
            _jobGetter = jobGetter;
        }

        public override Task Initialize()
        {
            base.Initialize();

            Jobs = _jobGetter.GetJobs();

            return Task.Delay(0);
        }
    }
}
