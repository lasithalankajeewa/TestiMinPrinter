using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestiMinPrinter.Data;
using TestiMinPrinter.Models;
using TestiMinPrinter.Shared;

namespace TestiMinPrinter.Platforms
{
    public class IminPrinterHandler : IJNIPrinter
    {
        public bool ConnectPrinter(CommunicationChannels channel, string connectionString)
        {
            throw new NotImplementedException();
        }

        public bool DisconnectPrinter()
        {
            throw new NotImplementedException();
        }

        public int getId()
        {
            throw new NotImplementedException();
        }

        public bool InitializePrinter(int model)
        {
            throw new NotImplementedException();
        }

        public bool ProcessDocumentAndPrint(IList<PrintSDKDataObject> dataset)
        {
            throw new NotImplementedException();
        }

        public bool PrintTelerikReport(string content)
        {
            throw new NotImplementedException();
        }
    }
}
