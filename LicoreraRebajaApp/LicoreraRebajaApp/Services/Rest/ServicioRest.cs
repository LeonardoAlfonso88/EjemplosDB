using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LicoreraRebajaApp.Services.Rest
{
    public class ServicioRest
    {
        private readonly HttpClient client;
        private const string URL = "http://jsonplaceholder.typicode.com/posts/1";

        public ServicioRest()
        {
            client = new HttpClient();
            //client.DefaultRequestHeaders.Authorization
            //             = new AuthenticationHeaderValue("Bearer", "Your Oauth token");
        }

        public async Task<string> testCall()
        {
            string content = await client.GetStringAsync(URL);
            return content;
        }

    }
}
