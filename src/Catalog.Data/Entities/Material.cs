namespace USF.TrainingCatalog.Data.Entities
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public Session Session { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
