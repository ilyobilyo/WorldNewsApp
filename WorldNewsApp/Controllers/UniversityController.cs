using Microsoft.AspNetCore.Mvc;
using NewsWorld.Core.Contracts;
using WorldNewsApp.Models.Pageing;

namespace WorldNewsApp.Controllers
{
    public class UniversityController : Controller
    {
        private readonly IPageingService pageingService;

        public UniversityController(IPageingService pageingService)
        {
            this.pageingService = pageingService;
        }

        public async Task<IActionResult> Index(int pageNumber, PageingViewModel model = null)
        {
            PageingViewModel universities;

            if (model.SearchedMessage != null)
            {
                universities = await pageingService.GetUniversitiesPerPage(pageNumber, model.SearchedMessage);
            }
            else
            {
                universities = await pageingService.GetUniversitiesPerPage(pageNumber);
            }


            return View(universities);
        }
    }
}
