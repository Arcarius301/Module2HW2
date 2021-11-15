using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW2.Models;
using Module2HW2.Providers;

namespace Module2HW2.Services
{
    public class UserService
    {
        private UserModel _user;

        public UserModel GetUser()
        {
            return _user;
        }

        public void SetUser(UserModel value)
        {
            _user = value;
        }
    }
}
