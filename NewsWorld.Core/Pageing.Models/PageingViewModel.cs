using NewsWorld.Core.ServiceModels.University;

namespace WorldNewsApp.Models.Pageing
{
    public class PageingViewModel
    {
        public PageingList<UniversityServiceModel> Universities { get; set; }

        public string SearchedMessage { get; set; }
    }
}
