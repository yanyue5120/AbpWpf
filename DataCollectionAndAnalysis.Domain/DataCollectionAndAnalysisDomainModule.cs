using DataCollectionAndAnalysis.Domain.Shared;
using System;
using Volo.Abp.Modularity;

namespace DataCollectionAndAnalysis.Domain
{
    /// <summary>
    /// 解决方案领域层，主要包含实体，集合跟，领域服务，值类型，仓储接口和解决方案其他领域对象
    /// 例如 实体和 IEntityRepository接口都适合放在这个项目中
    /// 它依赖 Domain.Shared
    /// </summary>
    [DependsOn(
        typeof(DataCollectionAndAnalysisDomainSharedModule)    
    )]
    public class DataCollectionAndAnalysisDomainModule:AbpModule
    {

    }
}
