using Microsoft.Extensions.Logging;
using MvvmCross.Forms.Platforms.Uap.Core;
using Xamarin.Forms.Internals;
using Serilog;
using Serilog.Events;
using Serilog.Extensions.Logging;

namespace MvxFormsMasterDetailDemo.UWP
{
    public class Setup : MvxFormsWindowsSetup<Core.App, UI.App>
    {
        protected override ILoggerProvider CreateLogProvider()
        {
            return new SerilogLoggerProvider();
        }

        protected override ILoggerFactory CreateLogFactory()
        {
            // serilog configuration
            Serilog.Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .Enrich.FromLogContext()
                .WriteTo.Debug(
                    outputTemplate:
                    "{Timestamp:HH:mm:ss} [{Level:u3}] ({SourceContext}) {Message:lj} {NewLine} {Exception} {NewLine}")
                //.WriteTo.AppCenter(LogEventLevel.Information)
                .CreateLogger();

            return new SerilogLoggerFactory();
        }
    }
}
