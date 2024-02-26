using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestiMinPrinter.Platforms;


namespace TestiMinPrinter.Data
{
    public class NativePrinterFactory : INativePrinterFactory
    {
        private IJNIPrinter printer = null;
        //id 1 reserved for epson brand
        public IJNIPrinter LoadPrinter(string printerName)
        {
            if (printerName != null)
            {
                if (printerName.Equals("Imin"))
                {
                    if (printer != null && printer.getId() == 3)
                    {
                        //Already in epson printer instance
                    }
                    else if (printer == null)
                    {
                        printer = new IminPrinterHandler();
                    }
                    else
                    {
                        printer.DisconnectPrinter();
                        printer = new IminPrinterHandler();
                    }
                }
               
            }

            return printer;
        }

        public IJNIPrinter DisconnectPrinter(string printerName)
        {
            printer = null;

            return printer;
        }
    }
}
