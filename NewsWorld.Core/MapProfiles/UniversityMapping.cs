using AutoMapper;
using NewsWorld.Core.Data.Universities;
using NewsWorld.Core.ServiceModels.University;

namespace NewsWorld.Core.MapProfiles
{
    public class UniversityMapping : Profile
    {
        public UniversityMapping()
        {
            CreateMap<University, UniversityServiceModel>()
                .ForMember(x => x.AlphaTwoCode, y => y.MapFrom(s => s.Alpha_Two_Code));
        }
    }
}
