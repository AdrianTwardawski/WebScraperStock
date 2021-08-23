using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebScrapperStock
{
    class StockScraper
    {
        private const string BaseUrl = "https://www.bankier.pl/gielda/notowania/akcje";

        public void GetStocks()
        {
            var web = new HtmlWeb();
            var document = web.Load(BaseUrl);
            var tableRows = document.QuerySelectorAll("table tr").Skip(1).Skip(11);

            foreach (var tableRow in tableRows)
            {
                var tds = tableRow.QuerySelectorAll("td");

                var walor = tds[0].QuerySelector("a").InnerText;          
                var kurs = tds[1].InnerText;
                var zmiana = tds[2].InnerText;
                
                Console.WriteLine($"Nazwa: {walor}, Kurs: {kurs}, Zmiana: {zmiana}");

                
            }
        }
    }
}
