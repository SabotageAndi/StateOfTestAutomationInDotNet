using _7_RunWebAppLocaly;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace UseKestrel
{
    public class UnitTest1
    {
        private IHost _host;
        public string Hostname { get; private set; }

        public void Start()
        {
            Hostname = $"http://localhost:{GeneratePort()}";

            var hostBuilder = new KestrelHostBuilder();
            string webRoot = Path.Combine(Path.GetDirectoryName(typeof(KestrelHostBuilder).Assembly.Location), "..", "..", "..", "..", "7_RunWebAppLocaly", "wwwroot");
            var builder = hostBuilder.CreateHostBuilder(new string[] { }, Hostname, webRoot);
            _host = builder.Build();
            _host.StartAsync().ConfigureAwait(false);
        }


        public async Task Stop()
        {
            if (_host != null) await _host.StopAsync();
        }

        private int GeneratePort()
        {
            return new Random().Next(5000, 32000);
        }

        [Fact]
        public void Test1()
        {
            Start();

            Thread.Sleep(TimeSpan.FromMinutes(1));

            Stop();
        }
    }
}