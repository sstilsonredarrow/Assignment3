using System;
using System.Collections.Generic;
using MvvmCross.Forms.Presenters.Attributes;
using Xamarin.Forms;

namespace Assignment3.Views
{
    [MvxTabbedPagePresentation(TabbedPosition.Tab, NoHistory = true)]
    public partial class ProfilePage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }
    }
}
