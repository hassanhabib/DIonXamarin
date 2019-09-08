using DPI.Brokers;
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
        private IDataBroker dataBroker;

        public MainPage(IDataBroker dataBroker)
        {
            this.dataBroker = dataBroker;
            InitializeComponent();
            this.Label.Text = this.dataBroker.GetData();
        }
    }
}
