using Microsoft.AspNetCore.Mvc;
using NewsWorld.Core.Contracts;

namespace WorldNewsApp.Controllers
{
    public class UniversityController : Controller
    {
        private readonly IUniversityService universityService;

        public UniversityController(IUniversityService universityService)
        {
            this.universityService = universityService;
        }

        public async Task<IActionResult> Index()
        {
            //var universities = universityService.GetUniversitiesSeed();

            return View();
        }
    }
}
