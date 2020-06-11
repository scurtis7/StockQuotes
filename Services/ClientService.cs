using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

        public async Task<Stock> GetQuote(string symbol)
        {

            var uri = new Uri($"{FinnHubBaseUrl}/quote?symbol={symbol}&token={FinnHubToken}");
            var client = _clientFactory.CreateClient();
            var msg = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = uri
            };

            var result = await client.SendAsync(msg);
            // var retVal = await result.Content.ReadAsStringAsync();
            if (result.StatusCode == HttpStatusCode.OK)
            {
                return await result.Content.ReadAsAsync<Stock>(new[] { new JsonMediaTypeFormatter() });
            }
            else
            {
                return null;
            }
        }

    }
}