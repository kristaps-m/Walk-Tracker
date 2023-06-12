using System;
using WalkTracker.Services;
using WalkTracker.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalkTracker
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
