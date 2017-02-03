using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace USF.TrainingCatalog.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveAllAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
