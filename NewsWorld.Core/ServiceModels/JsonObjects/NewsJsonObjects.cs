using NewsWorld.Core.ServiceModels.News;

namespace NewsWorld.Core.ServiceModels.JsonObjects
{
    public class NewsJsonObjects
    {
        public string Status { get; set; }

        public int TotalResults { get; set; }

        public List<NewsServiceModel> Results { get; set; }
    }
}
