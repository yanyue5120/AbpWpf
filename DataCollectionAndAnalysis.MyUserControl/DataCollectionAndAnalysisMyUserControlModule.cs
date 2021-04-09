using DataCollectionAndAnalysis.Service;
using DataCollectionAndAnalysis.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Modularity;

namespace DataCollectionAndAnalysis.MyUserControl
{
    [DependsOn(
        typeof(DataCollectionAndAnalysisServiceModule)
    )]
    public class DataCollectionAndAnalysisMyUserControlModule: AbpModule
    {
    }
}
