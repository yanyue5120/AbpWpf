using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using System;
using System.Windows;
using Volo.Abp;

namespace DataCollectionAndAnalysis
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host;
        private readonly IAbpApplicationWithExternalServiceProvider _application;

        public App()
        {
            _host = Host
                .CreateDefaultBuilder(null)
                .UseAutofac()
                .UseSerilog()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddApplication<DataCollectionAndAnalysisModule>();
                }).Build();
            _application = _host.Services.GetService<IAbpApplicationWithExternalServiceProvider>();
        }

        protected async override void OnStartup(StartupEventArgs e)
        {
            Log.Logger = new LoggerConfiguration()
#if DEBUG
                .MinimumLevel.Debug()       //设置为error 或更高级别时，可过滤debug、information低级别的日志信息
#else
                .MinimumLevel.Information()
#endif
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.Async(c => c.File("Logs/logs.txt"))
                .CreateLogger();

            try
            {
                Log.Information("Starting WPF host.");
                await _host.StartAsync();
                Initialize(_host.Services);

                _host.Services.GetService<MainWindow>()?.Show();

            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly!");
            }
            finally
            {
                //Log.CloseAndFlush();  此处应移动到程序关闭处
            }
        }

        protected async override void OnExit(ExitEventArgs e)
        {
            _application.Shutdown();
            await _host.StopAsync();
            _host.Dispose();
        }

        private void Initialize(IServiceProvider serviceProvider)
        {
            _application.Initialize(serviceProvider);
        }
    }
}
