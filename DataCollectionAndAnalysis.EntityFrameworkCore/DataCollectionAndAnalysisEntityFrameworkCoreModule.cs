using DataCollectionAndAnalysis.Domain;
using Volo.Abp.Modularity;

namespace DataCollectionAndAnalysis.EntityFrameworkCore
{
    /// <summary>
    /// 集成 EFCore 的项目，它定义了dbcontext并实现了domaoin 定义的仓储接口
    /// 它依赖 doamin
    /// </summary>
    [DependsOn(
        typeof(DataCollectionAndAnalysisDomainModule)
    )]
    public class DataCollectionAndAnalysisEntityFrameworkCoreModule : AbpModule
    {
    }
}
