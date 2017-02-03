using USF.TrainingCatalog.Data.Entities;

namespace USF.TrainingCatalog.Data.Repositories
{
    public class TrainerRepository : Repository<Trainer>
    {
        public TrainerRepository(CatalogContext context) : base(context)
        {
        }
    }
}
