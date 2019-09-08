using DPI.Brokers;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DPI.Services
{
    public class DataService : IDataService
    {
        private readonly IDataBroker dataBroker;

        public DataService()
        {
            this.dataBroker = DependencyService.Get<IDataBroker>();
        }

        public DataService(IDataBroker dataBroker)
        {
            this.dataBroker = dataBroker;
        }

        public string RetrieveData()
        {
            return this.dataBroker.GetData();
        }
    }
}
