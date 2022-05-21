using OpenClose.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class InvoicePersistence
    {
        private Invoice _invoice;
        private IInvoiceSaver _invoiceSaver;

        public InvoicePersistence(Invoice invoice, IInvoiceSaver invoiceSaver)
        {
            _invoice = invoice;
            _invoiceSaver = invoiceSaver;
        }

        public void Save()
        {
            _invoiceSaver.Save(_invoice);
        }

        //public void SaveToPdf()
        //{
        //    Console.WriteLine("Saving to pdf");
        //}

        ////not that
        //public void SaveToWord()
        //{
        //    Console.WriteLine("Saving to word");
        //}
    }
}
