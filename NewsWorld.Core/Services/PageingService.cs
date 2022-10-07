using NewsWorld.Core.Contracts;
using NewsWorld.Core.ServiceModels.University;
using WorldNewsApp.Models.Pageing;

namespace NewsWorld.Core.Services
{
    public class PageingService : IPageingService
    {
        private readonly IUniversityService universityService;

        public PageingService(IUniversityService universityService)
        {
            this.universityService = universityService;
        }

        public async Task<PageingViewModel> GetUniversitiesPerPage(int pageNumber, string country = null)
        {
            var totalCountUniversities = await universityService.GetTotalCountOfUniversities(country);

            var pageSize = 10;

            var universities = await universityService.GetUniversities(pageNumber, pageSize, country);

            var pageList = new PageingList<UniversityServiceModel>(universities, totalCountUniversities, pageNumber, pageSize);

            var pageingViewModel = new PageingViewModel()
            {
                Universities = pageList,
            };

            return pageingViewModel;
        }
    }
}
