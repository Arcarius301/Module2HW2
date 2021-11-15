using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW2.Models;

namespace Module2HW2.Providers
{
    public class UserProvider
    {
        private UserModel _user = new UserModel() { Id = 1, FirstName = "Vasya", LastName = "Pupkin", PhoneNumber = "+380661111111", Email = "sample@gmail.com" };
        public UserModel User => _user;
    }
}
