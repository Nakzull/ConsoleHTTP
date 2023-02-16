using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ConsoleHTTP
{
    public class GoodController : ApiController
    {
        private static readonly HttpClient httpClient;

        static GoodController()
        {
            var socketsHandler = new SocketsHttpHandler
            {
                PooledConnectionLifetime = TimeSpan.FromMinutes(2)
            };

            httpClient = new HttpClient(socketsHandler);
        }
    }
}
