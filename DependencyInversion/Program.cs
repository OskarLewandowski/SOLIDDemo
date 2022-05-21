using System;

namespace DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                Name = "Oskar",
                Email = "test@test",
                Password = "test",
                PhoneNumber = "12345"
            };

            INotyficationSender notyficationSender = new SmsNotyfication();
            AuthenticationManager authentication = new AuthenticationManager(notyficationSender);
            authentication.Authentication(user, "test@test", "test");

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
