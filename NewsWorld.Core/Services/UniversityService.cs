using NewsWorld.Core.Contracts;
using NewsWorld.Core.Data.Universities;
using NewsWorld.Core.ServiceModels.JsonObjects;
using NewsWorld.Core.ServiceModels.University;
using Newtonsoft.Json;

namespace NewsWorld.Core.Services
{
    public class UniversityService : IUniversityService
    {
        private readonly string baseUrl = "http://universities.hipolabs.com/search";

        public Task<IEnumerable<UniversityServiceModel>> GetUniversities()
        {
            throw new NotImplementedException();
        }

        

    }
}
