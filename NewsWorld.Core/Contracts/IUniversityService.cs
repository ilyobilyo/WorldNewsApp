using NewsWorld.Core.Data.Universities;
using NewsWorld.Core.ServiceModels.University;

namespace NewsWorld.Core.Contracts
{
    public interface IUniversityService
    {
        Task<IEnumerable<UniversityServiceModel>> GetUniversities();
    }
}
