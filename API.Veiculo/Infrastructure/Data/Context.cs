using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data
{

    public class Context : IDisposable
    {
        private readonly IConfiguration _configuration;

        public Context(IConfiguration configuration)
        {
            _configuration = configuration;

        }
        public string GetConnection()
        {

            {
                var connection = _configuration.GetConnectionString("DefaultConnection");
                return connection;
            }

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
