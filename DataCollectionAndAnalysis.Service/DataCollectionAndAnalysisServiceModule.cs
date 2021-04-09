using DataCollectionAndAnalysis.Domain;
using DataCollectionAndAnalysis.Service.Contracts;
using Volo.Abp.Modularity;

namespace DataCollectionAndAnalysis.Service
{
    /// <summary>
    /// 项目应用服务 Contract层 接口实现，xxxService适合放在这一层
    /// 它依赖 Service.Contract,因为需要实现接口，使用DTO
    /// ta依赖 Doamin，因为它需要使用领域对象（实体，仓储接口等）执行程序逻辑
    /// </summary>
    [DependsOn(
        typeof(DataCollectionAndAnalysisServiceContractsModule),
        typeof(DataCollectionAndAnalysisDomainModule)
    )]
    public class DataCollectionAndAnalysisServiceModule : AbpModule
    {

    }
}
