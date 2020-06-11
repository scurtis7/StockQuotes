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
        private readonly ILogger _logger;
        private readonly ClientService _clientService;

        public StockQuoteController(ILogger<StockQuoteController> logger, ClientService clientService)
        {
            _logger = logger;
            _clientService = clientService;
        }

        [HttpGet("{symbol}")]
        public async Task<Stock> GetQuote(string symbol)
        {
            _logger.LogInformation($"GetQuote for symbol: {symbol}");
            var result = await _clientService.GetQuote(symbol);
            return result;
        }
        
    }
}