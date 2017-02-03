namespace USF.TrainingCatalog.Data.Entities
{
    public class CatalogUser
    {
        public string Id { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
