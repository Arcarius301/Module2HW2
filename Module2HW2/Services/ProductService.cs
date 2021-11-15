using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW2.Models;
using Module2HW2.Providers;

namespace Module2HW2.Services
{
    public class ProductService
    {
        private ProductModel[] _products;

        public ProductModel[] GetProducts()
        {
            return _products;
        }

        public void SetProducts(ProductModel[] value)
        {
            _products = value;
        }
    }
}
