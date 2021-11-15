using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW2.Models;
using Module2HW2.Services;
using Module2HW2.Enumerations;

namespace Module2HW2.Providers
{
    public class ProductProvider
    {
        private readonly ConfigurationService _configurationService;
        private ProductModel[] _products;

        public ProductProvider()
        {
            _configurationService = ConfigurationService.Instance;
            _products = new ProductModel[100];
            var random = new Random();
            for (var i = 0; i < 100; i++)
            {
                _products[i] = new ProductModel { Id = i + 1, Name = $"Product{i + 1}", Price = random.Next(10, 1001), Currency = _configurationService.Config.Currency };
            }
        }

        public ProductModel[] Products => _products;
    }
}
