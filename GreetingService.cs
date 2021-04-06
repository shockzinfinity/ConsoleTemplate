using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace ConsoleTemplate
{
  public class GreetingService : IGreetingService
  {
    private readonly ILogger<GreetingService> _logger;
    private readonly IConfiguration _configuration;

    public GreetingService(ILogger<GreetingService> logger, IConfiguration configuration)
    {
      _logger = logger ?? throw new ArgumentNullException(nameof(logger));
      _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
    }

    public void Run()
    {
      for (int i = 0; i < _configuration.GetValue<int>("LoopTimes"); i++)
      {
        _logger.LogInformation("Run number {runNumber}", i);
      }
    }
  }
}