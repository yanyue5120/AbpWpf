using Autofac;
using Autofac.Extensions.DependencyInjection;
using DataCollectionAndAnalysis.Service;
using DataCollectionAndAnalysis.Service.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace DataCollectionAndAnalysis
{
    [DependsOn(typeof(AbpAutofacModule),
        typeof(DataCollectionAndAnalysisServiceModule)
    )]
    public class DataCollectionAndAnalysisModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSingleton<MainWindow>();
        }
    }
}
