using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Services
{
    public class ClientService
    {

        private const string FinnHubBaseUrl = "https://finnhub.io/api/v1";
        private const string FinnHubToken = "bq4hh0nrh5rbnj6k5e8g";

        private readonly IHttpClientFactory _clientFactory;

        public ClientService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<ActionResult<string>> GetQuote(string symbol)
        {
            var uri = new Uri($"{FinnHubBaseUrl}/quote?symbol={symbol}&token={FinnHubToken}");
            var client = _clientFactory.CreateClient();
            var msg = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = uri
            };

            var result = await client.SendAsync(msg);
            var retVal = await result.Content.ReadAsStringAsync();

            return retVal;
        }


    }
}