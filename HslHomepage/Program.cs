using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HslHomepage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Utils.SoftUtils.NumericalOrder = new HslCommunication.BasicFramework.SoftNumericalOrder( "", "", 10, "123.txt" );
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
