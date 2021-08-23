using System;
using System.Collections.Generic;
using System.Text;

namespace WebScrapperStock
{
    class StockModel
    {
        public StockModel(string walor, string kurs, string zmiana)
        {
            Walor = walor;
            Kurs = kurs;
            Zmiana = zmiana;
        }
        public string Walor { get; set; }
        public string Kurs { get; set; }
        public string Zmiana { get; set; }
    }
}
