using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionDefaults()
    .Build();

host.Run();
