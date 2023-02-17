using Microsoft.Extensions.Configuration;

namespace SecondApi
{
    public class SecondService
    {
        private readonly IConfiguration _configuration;

        public SecondService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string SecondMethod()
        {
            return _configuration.GetValue<string>("Key");
        }
    }
}
