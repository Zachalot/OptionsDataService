using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OptionsDataService.Models
{
    public class OptionableEquity
    {
        [Required]
        public int OptionableEquityId { get; set; }
        public string AssetType { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }

        public float Bid { get; set; }
        public int BidSize { get; set; }
        public float Ask { get; set; }
        public int AskSize { get; set; }
        public float Last { get; set; }
        public int LastSize { get; set; }

        public float OpenPrice { get; set; }
        public float HighPrice { get; set; }
        public float LowPrice { get; set; }
        public float ClosePrice { get; set; }

        public int TotalVolume { get; set; }

        public DateTime QuoteTime { get; set; }

        public float Mark { get; set; }
        public float Volatility { get; set; }

        public float High52Wk { get; set; }
        public float Low52Wk { get; set; }

        public float DivAmt { get; set; }
        public float DivYield { get; set; }
        public DateTime DivDate { get; set; }


    }
}
