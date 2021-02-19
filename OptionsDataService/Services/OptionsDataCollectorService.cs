using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OptionsDataService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OptionsDataService
{
    public class OptionsDataCollectorService: IHostedService
    {
        private ILogger<OptionsDataCollectorService> _logger;

        private IDataCollectionWorker _worker;
        public OptionsDataCollectorService(ILogger<OptionsDataCollectorService> logger, IDataCollectionWorker worker)
        {
            _logger = logger;
            _worker = worker;
        }

        public async Task StartAsync(CancellationToken cancelationToken)
        {

            await _worker.CollectData(cancelationToken);
        }

        public Task StopAsync(CancellationToken cancelationToken)
        {
            _logger.LogInformation($"Stopping BackgroundOptionsDataCollector ");
            return Task.CompletedTask;
        }


    }

}
