using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2.Services
{
    public class SmsService
    {
        public void Notify(string phoneNumber, string message)
        {
            Console.WriteLine($"{phoneNumber}: You received a new SMS: {message}");
        }
    }
}
