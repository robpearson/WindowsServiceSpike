using System;
using System.Globalization;
using System.Reactive.Linq;
using System.ServiceProcess;
using Serilog;

namespace RobPearson.WindowsServiceSpike
{
    public partial class SpikeService : ServiceBase
    {
        private IDisposable _logger;

        public SpikeService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Log.Logger.Information("Spike Service started at:{TimeStamp}", DateTime.Now.ToString(CultureInfo.InvariantCulture));

            _logger =
                Observable.Interval(TimeSpan.FromSeconds(60))
                    .Subscribe(x => { Log.Logger.Information("Spike Service Interval:{TimeStamp}", DateTime.Now.ToString(CultureInfo.InvariantCulture)); });
        }

        protected override void OnStop()
        {
            Log.Logger.Information("Spike Service stopped at:{TimeStamp}", DateTime.Now.ToString(CultureInfo.InvariantCulture));

            _logger.Dispose();
        }
    }
}