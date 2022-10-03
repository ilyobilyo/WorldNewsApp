using NewsWorld.Core.Contracts;
using NewsWorld.Core.ServiceModels.JsonObjects;
using NewsWorld.Core.ServiceModels.News;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace NewsWorld.Core.Services
{
    public class NewsService : INewsService
    {
        private readonly string baseUrl = " https://newsdata.io/api/1/news?apikey=pub_11834ce7a3751feb98d43c623fadbdb23e75b&language=en";

        public async Task<IEnumerable<NewsServiceModel>> GetRecentNews()
        {
            var recentNews = new List<NewsServiceModel>();

            using (var client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage();

                request.RequestUri = new Uri(baseUrl);

                request.Method = HttpMethod.Get;

                //request.Headers.Add("X-Api-Key", "cd515c0e53784fffadc76102908a4eb8");

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
