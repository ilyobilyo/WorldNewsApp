using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NewsWorld.Core.Contracts;
using NewsWorld.Core.Data.AppRepository;
using NewsWorld.Core.Data.Universities;
using NewsWorld.Core.ServiceModels.University;

namespace NewsWorld.Core.Services
{
    public class UniversityService : IUniversityService
    {
        private readonly IApplicationRepository repo;
        private readonly IMapper mapper;

        public UniversityService(IApplicationRepository repo,
            IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public async Task<int> GetTotalCountOfUniversities(string country = null)
        {
            var totalCount = 0;

            if (country != null)
            {
                totalCount = await repo.All<University>()
                                   .CountAsync(x => x.Country == country);
            }
            else
            {
                totalCount = await repo.All<University>()
                .CountAsync();
            }

            return totalCount;
        }


        public async Task<List<UniversityServiceModel>> GetUniversities(int pageNumber, int pageSize, string country = null)
        {
            var universities = new List<University>();

            if (country != null)
            {
                 universities = await repo.All<University>()
                .Where(x => x.Country == country)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            }
            else
            {
                 universities = await repo.All<University>()
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            }

            var uniServiceModels = mapper.Map<List<UniversityServiceModel>>(universities);

            return uniServiceModels;
        }
    }
}
