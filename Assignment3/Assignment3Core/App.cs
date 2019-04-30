using System;
using System.Reflection;
using Assignment3Core.Services;
using Assignment3Core.ViewModels;
using MvvmCross;
using MvvmCross.ViewModels;

namespace Assignment3Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();
            Mvx.IoCProvider.RegisterType<IAccomplishmentsGetter, AccomplishmentsGetter>();
            Mvx.IoCProvider.RegisterType<IProfileGetter, ProfileGetter>();
            Assembly assembly = typeof(App).Assembly;
            RegisterAppStart<MainViewModel>();
        }
    }
}
