using Microsoft.Extensions.Configuration;

namespace FirstApi
{
    public class FirstService
    {
        private readonly IConfiguration _configuration;

        public FirstService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string FirstMethod()
        {
            return _configuration.GetValue<string>("Key");
        }
    }
}
