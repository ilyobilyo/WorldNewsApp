using Microsoft.AspNetCore.Mvc;
using NewsWorld.Core.Contracts;
using NewsWorld.Core.ServiceModels.News;
using WorldNewsApp.Models.News;

namespace WorldNewsApp.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsService newsService;

        public NewsController(INewsService newsService)
        {
            this.newsService = newsService;
        }

        public async Task<IActionResult> Index(NewsIndexViewModel model = null)
        {
            IEnumerable<NewsServiceModel> news;

            if (model.SearchedMessage == null)
            {
                news = await newsService.GetRecentNews();
            }
            else
            {
                news = await newsService.GetSearchedNews(model.SearchedMessage);
            }

            var viewModel = new NewsIndexViewModel()
            {
                News = news.ToList()
            };

            return View(viewModel);
        }

    }
}
