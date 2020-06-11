using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;

namespace Controllers
{
    [ApiController]
    [Route("api/quote")]
    public class StockQuoteController : ControllerBase
    {
        private readonly ClientService _clientService;

        public StockQuoteController(ClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("{symbol}")]
        public async Task<Stock> GetQuote(string symbol)
        {
            var result = await _clientService.GetQuote(symbol);
            return result;
        }
        
    }
}