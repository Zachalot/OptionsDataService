using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OptionsDataService.Models
{
    public class Equity
    {
        [Required]
        public int EquityId { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }

        public float Close { get; set; }
        public DateTime QuoteTime { get; set; }

        public float Bid { get; set; }
        public float Ask { get; set; }
        public float Last { get; set; }
        public float Mark { get; set; }

        public int BidSize { get; set; }
        public int AskSize { get; set; }

        public float HighPrice { get; set; }
        public float LowPrice { get; set; }
        public float OpenPrice { get; set; }

        public int TotalVolume { get; set; }

        public float High52Wk { get; set; }
        public float Low52Wk { get; set; }
    }
}
