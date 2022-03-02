namespace ExportWebAPIs.Model
{

    public class BuyerModel
    {
        public List<BuyerValues> Values { get; set; }
    }

    public class BuyerValues
    {
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string DisplayName { get; set; }
        public string Id { get; set; }
        public string UniqueId { get; set; }
    }

}
