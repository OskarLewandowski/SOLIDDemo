using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IPrinter
    {
        //IS in this rule we should have a few small interface
        //not one big
        void PrintGrey(string content);
        void PrintColor(string content);
        void Scan(string content);
        void Fax(string content);
    }
}
