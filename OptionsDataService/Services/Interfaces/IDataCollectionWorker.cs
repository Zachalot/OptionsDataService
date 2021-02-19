using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OptionsDataService.Services.Interfaces
{
    public interface IDataCollectionWorker
    {
        /// <summary>
        /// Start the job to collect data from TD Ameritrade every 5 seconds
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task CollectData(CancellationToken cancellationToken);
    }
}
