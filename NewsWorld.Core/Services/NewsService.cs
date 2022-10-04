using NewsWorld.Core.Contracts;
using NewsWorld.Core.ServiceModels.JsonObjects;
using NewsWorld.Core.ServiceModels.News;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace NewsWorld.Core.Services
{
    public class NewsService : INewsService
    {
        private readonly string baseUrl = "https://newsdata.io/api/1/news?apikey=pub_11834ce7a3751feb98d43c623fadbdb23e75b&language=en";

        public async Task<IEnumerable<NewsServiceModel>> GetRecentNews()
        {
            var recentNews = await GetNewsFromApi();

            return recentNews;
        }

        public async Task<IEnumerable<NewsServiceModel>> GetSearchedNews(string searchedMessage)
        {
            var recentNews = await GetNewsFromApi(searchedMessage);

            return recentNews;
        }



        private async Task<IEnumerable<NewsServiceModel>> GetNewsFromApi(string searchedMessage = null)
        {
            var recentNews = new List<NewsServiceModel>();

            using (var client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage();

                if (searchedMessage == null)
                {
                    request.RequestUri = new Uri(baseUrl);
                }
                else
                {
                    request.RequestUri = new Uri(baseUrl + "&q=" + searchedMessage);
                }

                request.Method = HttpMethod.Get;

                HttpResponseMessage response = await client.SendAsync(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var responseString = await response.Content.ReadAsStringAsync();

                    var jsonObj = JsonConvert.DeserializeObject<NewsJsonObjects>(responseString);

                    recentNews = jsonObj.Results;
                }
                else
                {
                    return null;
                }
            }

            return recentNews;
        }
    }
}
