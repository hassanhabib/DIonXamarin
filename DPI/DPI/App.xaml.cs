using DPI.Brokers;
using DPI.Services;
using Microsoft.Extensions.DependencyInjection;
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

            IServiceCollection collection = new ServiceCollection();
            collection.AddTransient<IDataBroker, DataBroker>();
            collection.AddTransient<IDataService, DataService>();

            collection.AddSingleton<MainPage>();
            var serviceProvider = collection.BuildServiceProvider();

            MainPage = serviceProvider.GetRequiredService<MainPage>();
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
