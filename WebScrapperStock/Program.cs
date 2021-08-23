using System;

namespace WebScrapperStock
{
    class Program
    {
        static void Main(string[] args)
        {
            var stockScraper = new StockScraper();

            var stocks = stockScraper.GetStocks();

            foreach (var stock in stocks)
            {
                Console.WriteLine($"Nazwa: {stock.Walor}, Kurs: {stock.Kurs}, Zmiana: {stock.Zmiana}");
            }
        }
    }
}
