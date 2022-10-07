using NewsWorld.Core.Data.Universities;
using NewsWorld.Core.ServiceModels.University;

namespace NewsWorld.Core.Contracts
{
    public interface IUniversityService
    {
        Task<List<UniversityServiceModel>> GetUniversities(int pageNumber, int pageSize, string country = null);
        Task<int> GetTotalCountOfUniversities(string country = null);
    }
}
