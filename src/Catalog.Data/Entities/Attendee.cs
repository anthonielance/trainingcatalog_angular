namespace USF.TrainingCatalog.Data.Entities
{
    public class Attendee
    {
        public int Id { get; set; }

        public Session Session { get; set; }
        public CatalogUser User { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
