using NewsWorld.Core.ServiceModels.University;

namespace WorldNewsApp.Models.Universities
{
    public class UniversityIndexModel
    {
        public List<UniversityServiceModel> Universities { get; set; }
        public string SearchedMessage { get; set; }
    }
}
