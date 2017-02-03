using Microsoft.EntityFrameworkCore;
using USF.TrainingCatalog.Data.Entities;

namespace USF.TrainingCatalog.Data.Repositories
{
    public class MaterialRepository : Repository<Material>
    {
        public MaterialRepository(DbContext context) : base(context)
        {
        }
    }
}
