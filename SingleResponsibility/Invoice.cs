using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class Invoice
    {
        //responsibility 1
        //In "S" we need to make 1 responsibility per class
        public IEnumerable<LineItem> LineItems { get; set; }
        public string Vendor { get; set; }
        public string Vendee { get; set; }
        public float Total { get; set; }

        public Invoice(IEnumerable<LineItem> lineItems, string vendor, string vendee)
        {
            LineItems = lineItems;
            Vendor = vendor;
            Vendee = vendee;
            Total = this.CalculateToatal();
        }

        public float CalculateToatal()
        {
            float total = 0;

            foreach (var lineItem in LineItems)
            {
                total += lineItem.Price * lineItem.Count * (1 + lineItem.TaxRate);
            }

            return total;
        }

        //we need to move this for another class, for example in InvoiceLogger.cs
        //responsibility 2
        //public void Display()
        //{
        //    Console.WriteLine($"Vendor: {Vendor}");
        //    Console.WriteLine($"Vendee: {Vendee}");
        //    Console.WriteLine($"Total: {Total}");
        //}

        //we need to move this for another class, for example in InvoicePersistence.cs
        //responsibility 3
        //public void SaveToPdf()
        //{
        //    Console.WriteLine("Saving to pdf");
        //}
    }
}
