using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public static class InvoiceFactory
    {
        public static IInvoice GetInvoice(int invoiceType)
        {
            switch (invoiceType)
            {
                case 1:
                    return new InvoiceWithHeader();

                case 2:
                    return new InvoiceWithoutHeader();

                default:
                    throw new Exception("Invalid invoice type");
            }
        }
    }
}