﻿using System;
using System.Globalization;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin5Localization
{
    public partial class App : Application
    {
        public App()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InstalledUICulture; // new CultureInfo("de");
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
