using System;
using System.IO;
using System.ServiceProcess;
using Serilog;

namespace RobPearson.WindowsServiceSpike
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        private static void Main()
        {
            // Init Serilog
            Log.Logger = new LoggerConfiguration()
                .WriteTo.RollingFile(Path.Combine(@"C:\Temp\Log-{Date}.txt"))
                .CreateLogger();

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new SpikeService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}