using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _7_RunWebAppLocaly
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new KestrelHostBuilder().CreateHostBuilder(args).Build().Run();
        }
    }
}
