using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OptionsDataService.Services
{
    public class TDClient
    {
        public HttpClient _client;
        private IConfiguration _config;
        public TDClient(HttpClient client, IConfiguration config)
        {
            _client = client;
            _config = config;
        }

        //public GetTDOptionsData(string ticker)
        //{ 
        //    _client.GetAsync()
        //}


    }
}
