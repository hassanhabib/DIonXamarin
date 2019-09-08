using DPI.Brokers;
using DPI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DPI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private IDataService dataService;

        public MainPage(IDataService dataService)
        {
            this.dataService = dataService;
            InitializeComponent();
            this.Label.Text = this.dataService.RetrieveData();
        }
    }
}
