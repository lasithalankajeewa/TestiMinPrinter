using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestiMinPrinter.Models;
using TestiMinPrinter.Shared;

namespace TestiMinPrinter.Data
{
    public interface IJNIPrinter
    {
        int getId();
        bool InitializePrinter(int model);
        bool ConnectPrinter(CommunicationChannels channel, string connectionString);
        bool DisconnectPrinter();
        bool ProcessDocumentAndPrint(IList<PrintSDKDataObject> dataset);
        bool PrintTelerikReport(string content);


    }
}
