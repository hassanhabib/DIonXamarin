using DPI.Brokers;
using DPI.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DPI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<IDataService, DataService>();
            DependencyService.Register<IDataBroker, DataBroker>();

            MainPage = new MainPage(DependencyService.Get<IDataService>());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
