using DataCollectionAndAnalysis.MyUserControl;
using DataCollectionAndAnalysis.Service.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace DataCollectionAndAnalysis
{
    [DependsOn(typeof(AbpAutofacModule),
        typeof(DataCollectionAndAnalysisMyUserControlModule)
    )]
    public class DataCollectionAndAnalysisModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSingleton<MainWindow>();
        }
    }
}
