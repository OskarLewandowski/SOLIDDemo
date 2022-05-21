using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Cannon : IPrinter
    {
        public void PrintGrey(string content)
        {
            Console.WriteLine("Cannon print gray");
        }
        public void PrintColor(string content)
        {
            Console.WriteLine("Cannon jet print color");
        }
        //in this printer we can't scan
        public void Scan(string content)
        {
            throw new NotImplementedException();
        }
        public void Fax(string content)
        {
            Console.WriteLine("Cannon print fax");
        }
    }
}
