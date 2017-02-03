using USF.TrainingCatalog.Data.Entities;

namespace USF.TrainingCatalog.Data.Repositories
{
    public class SessionRepository : Repository<Session>
    {
        public SessionRepository(CatalogContext context) : base(context)
        {
        }
    }
}
