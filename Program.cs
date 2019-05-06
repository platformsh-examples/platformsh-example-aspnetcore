using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AspNetCore22Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = CreateWebHostBuilder(args);

            builder.UseKestrel(options =>
            {
                var port = Environment.GetEnvironmentVariable("PORT");
                if (port != null && Int16.TryParse(port, out var portNum))
                    options.ListenLocalhost(portNum);

                var socket = Environment.GetEnvironmentVariable("SOCKET");
                if (socket != null)
                    options.ListenUnixSocket(socket);
            });
            
            builder.Build().Run();
        }

        private static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
    }
}