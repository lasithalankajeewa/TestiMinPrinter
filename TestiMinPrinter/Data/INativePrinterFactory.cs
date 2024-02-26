using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestiMinPrinter.Data
{
    public interface INativePrinterFactory
    {
        IJNIPrinter LoadPrinter(string printerName);
        IJNIPrinter DisconnectPrinter(string printerName);
    }
}
