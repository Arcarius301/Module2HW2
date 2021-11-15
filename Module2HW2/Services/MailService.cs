using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2.Services
{
    public class MailService
    {
        public void Notify(string address, string message)
        {
            Console.WriteLine($"{address}: You received a new email: {message}");
        }
    }
}
