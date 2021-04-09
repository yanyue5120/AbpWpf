using DataCollectionAndAnalysis.Service.Contracts.IService;
using Volo.Abp.Application.Services;

namespace DataCollectionAndAnalysis.Service
{
    public class HellowWorldService : ApplicationService, IHellowWorldService
    {
        public string Run()
        {
            return "Hellow World!";
        }
    }
}
