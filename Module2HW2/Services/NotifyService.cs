using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW2.Enumerations;
using Module2HW2.Models;

namespace Module2HW2.Services
{
    public class NotifyService
    {
        private readonly SmsService _smsService;
        private readonly MailService _mailService;

        public NotifyService()
        {
            _smsService = new SmsService();
            _mailService = new MailService();
        }

        public void Notify(UserModel user, string orderId, NotifyType notifyType)
        {
            var message = $"Thank you for your purchase! Order Id: {orderId}";

            switch (notifyType)
            {
                case NotifyType.Sms:
                    _smsService.Notify(user.PhoneNumber, message);
                    break;
                case NotifyType.Email:
                    _mailService.Notify(user.Email, message);
                    break;
                case NotifyType.All:
                    _smsService.Notify(user.PhoneNumber, message);
                    _mailService.Notify(user.Email, message);
                    break;
            }
        }
    }
}