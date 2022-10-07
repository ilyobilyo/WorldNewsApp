namespace NewsWorld.Core.Data.Common
{
    public interface IRepository
    {
        IQueryable<T> All<T>() where T : class;

        int SaveChanges();

        Task<int> SaveChangesAsync();
    }
}
