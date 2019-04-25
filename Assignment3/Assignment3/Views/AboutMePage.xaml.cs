using System;
using System.Collections.Generic;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Xamarin.Forms;

namespace Assignment3.Views
{
    [MvxTabbedPagePresentation(TabbedPosition.Tab, NoHistory = true)]
    public partial class AboutMePage
    {
        public AboutMePage()
        {
            InitializeComponent();
        }
    }
}
