using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHTTP
{
    public class HttpClient : System.Net.Http.HttpMessageInvoker
    {
        public HttpClient(HttpMessageHandler handler) : base(handler)
        {
        }

        public HttpClient(HttpMessageHandler handler, bool disposeHandler) : base(handler, disposeHandler)
        {
        }
    }
}
