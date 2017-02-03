using USF.TrainingCatalog.Data.Entities;

namespace USF.TrainingCatalog.Data.Repositories
{
    public class CatalogUserRepository : Repository<CatalogUser>
    {
        public CatalogUserRepository(CatalogContext context) : base(context)
        {
        }
    }
}
