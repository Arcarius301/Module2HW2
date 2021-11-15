using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW2.Enumerations;
using Module2HW2.Models;

namespace Module2HW2.Services
{
    public class OrderService
    {
        private readonly NotifyService _notifyService;
        private UserModel _user;

        public OrderService()
        {
            _notifyService = new NotifyService();
        }

        public void SetUser(UserModel value)
        {
            _user = value;
        }

        public void MakeOrder()
        {
            var random = new Random();
            _notifyService.Notify(_user, random.Next(9999).ToString("D4"), NotifyType.All);
        }
    }
}
