using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class AuthenticationManager
    {
        public void Authentication(User user, string email, string password)
        {
            if (user.Email == email && user.Password == password)
            {
                EmailNotyfication emailNotyfication = new EmailNotyfication();
                emailNotyfication.SendNotyfication(user);
            }
        }
    }
}
