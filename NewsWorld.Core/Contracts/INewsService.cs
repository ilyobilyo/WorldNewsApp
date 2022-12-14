using NewsWorld.Core.ServiceModels.News;

namespace NewsWorld.Core.Contracts
{
    public interface INewsService
    {
        Task<IEnumerable<NewsServiceModel>> GetRecentNews();
        Task<IEnumerable<NewsServiceModel>> GetSearchedNews(string searchedMessage);
    }
}
