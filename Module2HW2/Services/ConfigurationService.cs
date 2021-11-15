using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW2.Configs;
using Module2HW2.Enumerations;

namespace Module2HW2.Services
{
    public class ConfigurationService
    {
        private static readonly ConfigurationService _instance = new ConfigurationService();
        private readonly Config _config;

        static ConfigurationService()
        {
        }

        private ConfigurationService()
        {
            _config = new Config();
            _config.CartConfig = new CartConfig { Capacity = 10 };
            _config.Currency = Currency.USD;
        }

        public static ConfigurationService Instance => _instance;
        public Config Config => _config;
    }
}
