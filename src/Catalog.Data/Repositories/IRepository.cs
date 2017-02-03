using System.Threading.Tasks;

namespace USF.TrainingCatalog.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        Task<bool> SaveAllAsync();

    }
}
