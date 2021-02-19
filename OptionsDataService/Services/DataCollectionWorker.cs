using Microsoft.Extensions.Logging;
using OptionsDataService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OptionsDataService
{
    public class DataCollectionWorker: IDataCollectionWorker
    {
        private ILogger<IDataCollectionWorker> _logger;
        private int _workerId = 0;

        public DataCollectionWorker(ILogger<IDataCollectionWorker> logger)
        {
            _logger = logger;
        }

        public async Task CollectData(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Starting DataCollectionWorker: {_workerId}");

            while (!cancellationToken.IsCancellationRequested)
            {
                Interlocked.Increment(ref _workerId);
                _logger.LogInformation($"Collecting Data from worker: {_workerId}");
                await Task.Delay(1000 * 5);
            }

            _logger.LogInformation($"Cancelling DataCollectionWorker: {_workerId}");
        }
    }
}
