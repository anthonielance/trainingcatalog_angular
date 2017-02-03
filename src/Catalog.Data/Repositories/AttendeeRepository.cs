using USF.TrainingCatalog.Data.Entities;

namespace USF.TrainingCatalog.Data.Repositories
{
    public class AttendeeRepository : Repository<Attendee>
    {
        public AttendeeRepository(CatalogContext context) : base(context)
        {
        }
    }
}
