namespace USF.TrainingCatalog.Data.Entities
{
    public class Trainer
    {
        public int Id { get; set; }

        public Session Session { get; set; }
        public CatalogUser User { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
