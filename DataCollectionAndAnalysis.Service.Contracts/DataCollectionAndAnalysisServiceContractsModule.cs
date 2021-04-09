using DataCollectionAndAnalysis.Domain.Shared;
using Volo.Abp.Modularity;

namespace DataCollectionAndAnalysis.Service.Contracts
{
    /// <summary>
    /// 主要包含应用服务接口和应用层数据传输对象（DTO），用于分离接口层和实现，这种方式可以将接口项目作为约定包共享给客户端
    /// 例如 IEntityService和EntityDTO都适合放在这个项目
    /// 依赖Domain.Shared,因为使用到使用常量，枚举和其他共享对象
    /// </summary>
    [DependsOn(
        typeof(DataCollectionAndAnalysisDomainSharedModule)
    )]
    public class DataCollectionAndAnalysisServiceContractsModule : AbpModule
    {
    }
}
