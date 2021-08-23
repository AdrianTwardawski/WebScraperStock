using System;

namespace WebScrapperStock
{
    class Program
    {
        static void Main(string[] args)
        {
            var stockScraper = new StockScraper();

            stockScraper.GetStocks();
        }
    }
}
