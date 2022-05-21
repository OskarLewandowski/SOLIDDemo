using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class EmailNotyfication : INotyficationSender
    {
        public void SendNotyfication(User user)
        {
            Console.WriteLine($"Sending email notification to user: {user.Name}");
        }
    }
}
