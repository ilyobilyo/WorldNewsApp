using Microsoft.AspNetCore.Mvc;
using NewsWorld.Core.Contracts;
using NewsWorld.Core.ServiceModels.News;

namespace WorldNewsApp.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsService newsService;

        public NewsController(INewsService newsService)
        {
            this.newsService = newsService;
        }

        public async Task<IActionResult> Index(IEnumerable<NewsServiceModel> news = null)
        {
            if (news.Count() == 0)
            {
                news = await newsService.GetRecentNews();
            }

            return View(news);
        }

        public async Task<IActionResult> SearchNews(string searchedMessage)
        {
            var serachedNews = await newsService.GetSearchedNews(searchedMessage);
            
            return RedirectToAction(nameof(Index), serachedNews);
        }
    }
}
