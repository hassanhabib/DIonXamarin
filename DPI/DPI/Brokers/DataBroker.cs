using System;
using System.Collections.Generic;
using System.Text;

namespace DPI.Brokers
{
    public class DataBroker : IDataBroker
    {
        public string GetData()
        {
            return "Some Data!";
        }
    }
}
