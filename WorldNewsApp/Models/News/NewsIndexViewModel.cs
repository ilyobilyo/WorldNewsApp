using NewsWorld.Core.ServiceModels.News;

namespace WorldNewsApp.Models.News
{
    public class NewsIndexViewModel
    {
        public List<NewsServiceModel> News { get; set; }
        public string SearchedMessage { get; set; }
    }
}
