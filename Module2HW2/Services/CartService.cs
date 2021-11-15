using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW2.Models;

namespace Module2HW2.Services
{
    public class CartService
    {
        private static readonly CartService _instance = new CartService();
        private readonly ConfigurationService _configurationService;
        private readonly ProductModel[] _products;
        private readonly int _capacity;
        private UserModel _user;

        static CartService()
        {
        }

        private CartService()
        {
            _configurationService = ConfigurationService.Instance;
            _capacity = _configurationService.Config.CartConfig.Capacity;
            _products = new ProductModel[_capacity];
        }

        public static CartService Instance => _instance;
        public ProductModel[] Products => _products;
        public UserModel User => _user;
        public void SetUser(UserModel user)
        {
            _user = user;
        }

        public void Add(ProductModel product)
        {
            for (int i = 0; i < _capacity; i++)
            {
                if (_products[i] == null)
                {
                    _products[i] = product;
                    break;
                }
            }
        }
    }
}
