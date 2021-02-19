using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OptionsDataService.Models
{
    public class Option
    {
        [Required]
        public int OptionId { get; set; }

        [Required]
        public int OptionableEquityId { get; set; }
        public string SymbolUnderlying { get; set; }
        public DateTime QuoteTimeUnderlying { get; set; }
        public float MarkUnderlying { get; set; }

        public string ContractType { get; set; }
        public float Bid { get; set; }
        public float Ask { get; set; }
        public float Mark { get; set; }

        public int BidSize { get; set; }
        public int AskSize { get; set; }

        public float HighPrice { get; set; }
        public float LowPrice { get; set; }
        public float OpenPrice { get; set; }
        public float ClosePrice { get; set; }

        public int TotalVolume { get; set; }
        public DateTime QuoteTime { get; set; }

        public float Volatility { get; set; }
        public float Delta { get; set; }
        public float Gamma { get; set; }
        public float Theta { get; set; }
        public float Vega { get; set; }
        public float Rho { get; set; }

        public int OpenInterest { get; set; }

        public float TheoValue { get; set; }
        public int TheoVolatility { get; set; }

        public int Strike { get; set; }
        public DateTime Expiration { get; set; }
        public int Dte { get; set; }
        public float PercentChange { get; set; }
        public bool Itm { get; set; }



    }
}
