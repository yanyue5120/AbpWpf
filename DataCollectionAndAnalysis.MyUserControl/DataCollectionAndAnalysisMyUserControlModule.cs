using DataCollectionAndAnalysis.Service;
using Volo.Abp.Modularity;

namespace DataCollectionAndAnalysis.MyUserControl
{
    [DependsOn(
        typeof(DataCollectionAndAnalysisServiceModule)
    )]
    public class DataCollectionAndAnalysisMyUserControlModule : AbpModule
    {
    }
}
