using Microsoft.AspNetCore.Mvc;
using NewsWorld.Core.Contracts;

namespace WorldNewsApp.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsService newsService;

        public NewsController(INewsService newsService)
        {
            this.newsService = newsService;
        }

        public async Task<IActionResult> Index()
        {
            var news = await newsService.GetRecentNews();

            return View(news);
        }

        public async Task<IActionResult> SearchNews(string searchedMessage)
        {
            //var serachedNews = await newsService.GetSearchedNews(searchedMessage);
            return Ok();
        }
    }
}
