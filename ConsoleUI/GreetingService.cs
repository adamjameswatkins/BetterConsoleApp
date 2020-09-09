using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ConsoleUI
{
    public class GreetingService : IGreetingService
    {
        private readonly ILogger<GreetingService> log;
        private readonly IConfiguration config;

        public GreetingService(ILogger<GreetingService> log, IConfiguration config)
        {
            this.log = log ?? throw new System.ArgumentNullException(nameof(log));
            this.config = config ?? throw new System.ArgumentNullException(nameof(config));
        }

        public void Run()
        {
            for (var i = 0; i < config.GetValue<int>("LoopTimes"); i++)
            {
                this.log.LogInformation("Run number {runNumber}", i);
            }
        }
    }
}
