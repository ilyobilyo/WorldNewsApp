using NewsWorld.Core.Data.Common;

namespace NewsWorld.Core.Data.AppRepository
{
    public class ApplicationRepository : Repository, IApplicationRepository
    {
        public ApplicationRepository(ApplicationDbContext context)
        {
            this.Context = context;
        }
    }
}
