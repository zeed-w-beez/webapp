using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace WebApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            // CreateDefaultBuilder: https://github.com/aspnet/MetaPackages/blob/dev/src/Microsoft.AspNetCore/WebHost.cs
            WebHost.CreateDefaultBuilder(args)
                // 添加自己的配置文件
                //.ConfigureAppConfiguration((config) =>
                //{
                //    config.AddJsonFile("config.json", optional: true, reloadOnChange: true);
                //})
                .UseStartup<Startup>()
                .UseNLog()
                .Build();
    }
}
