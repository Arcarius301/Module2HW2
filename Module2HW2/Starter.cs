using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW2.Services;
using Module2HW2.Providers;
using Module2HW2.Models;

namespace Module2HW2
{
    public class Starter
    {
        private readonly ConfigurationService _configurationService;
        private readonly CartService _cartService;
        private readonly OrderService _orderService;
        private readonly UserService _userService;
        private readonly ProductService _productService;
        private readonly UserProvider _userProvider;
        private readonly ProductProvider _productProvider;
        private readonly int _capacity;
        private UserModel _user;
        private ProductModel[] _products;

        public Starter()
        {
            _configurationService = ConfigurationService.Instance;
            _cartService = CartService.Instance;
            _orderService = new OrderService();
            _userService = new UserService();
            _productService = new ProductService();
            _userProvider = new UserProvider();
            _productProvider = new ProductProvider();
            _capacity = _configurationService.Config.CartConfig.Capacity;
            _products = new ProductModel[_capacity];
        }

        public void Run()
        {
            _productService.SetProducts(_productProvider.Products);
            _products = _productService.GetProducts();

            _userService.SetUser(_userProvider.User);
            _user = _userService.GetUser();

            for (var i = 0; i < _capacity; i++)
            {
                _cartService.Add(_products[i]);
            }

            _orderService.SetUser(_user);
            _orderService.MakeOrder();
        }
    }
}
