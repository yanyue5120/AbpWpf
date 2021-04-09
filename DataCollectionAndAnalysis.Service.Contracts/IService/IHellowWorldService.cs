using Volo.Abp.Application.Services;

namespace DataCollectionAndAnalysis.Service.Contracts.IService
{
    public interface IHellowWorldService : IApplicationService
    {
        public string Run();
    }
}
