﻿using System;
using System.Threading.Tasks;
using MvvmCross.ViewModels;

namespace Assignment3Core.ViewModels
{
    public class WebsiteViewModel : MvxViewModel
    { 
        public string url { get; set; }

        public WebsiteViewModel()
        {
        }

        public override Task Initialize()
        {
            base.Initialize();
            url = "https://youtu.be/bZ2oWNsVt38";
            RaisePropertyChanged(nameof(url));
            return Task.Delay(0);
        }
    }
}
