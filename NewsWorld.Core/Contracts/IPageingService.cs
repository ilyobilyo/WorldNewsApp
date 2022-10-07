using WorldNewsApp.Models.Pageing;

namespace NewsWorld.Core.Contracts
{
    public interface IPageingService
    {
        Task<PageingViewModel> GetUniversitiesPerPage(int pageNumber, string country = null);
    }
}
