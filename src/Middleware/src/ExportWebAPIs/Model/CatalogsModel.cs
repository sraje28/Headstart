using Newtonsoft.Json;

namespace ExportWebAPIs.Model
{

    public class CatalogsModel
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<Values> Values { get; set; }
    }

    public class Values
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string PriceBookName { get; set; }
        public string PromotionBookName { get; set; }
        public string DefaultInventorySetName { get; set; }
        public string SitecoreId { get; set; }
        public string ChildrenCategoryList { get; set; }
        public bool IsBundle { get; set; }
        public Components Components { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string DisplayName { get; set; }
        public string FriendlyId { get; set; }
        public string Id { get; set; }
        public int Version { get; set; }
        public int EntityVersion { get; set; }
        public bool Published { get; set; }
        public bool IsPersisted { get; set; }
        public string Name { get; set; }
        public string UniqueId { get; set; }
    }

    public class Components
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<ComponentValues> Values { get; set; }
    }

    public class ComponentValues
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public Definitions Definitions { get; set; }
        public string Id { get; set; }
        public Memberships Memberships { get; set; }
        public Workflow Workflow { get; set; }
        public string CurrentState { get; set; }
        public string Settings { get; set; }
    }

    public class Definitions
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<object> Values { get; set; }
    }

    public class Memberships
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<object> Values { get; set; }
    }

    public class Workflow
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string Name { get; set; }
        public string EntityTarget { get; set; }
        public string EntityTargetUniqueId { get; set; }
    }

    public class ExtendedCatalog
    {
        public string FriendlyId { get; set; }
        public bool IsPublished { get; set; }
        public string SitecoreId { get; set; }
        public string PriceBookName { get; set; }
        public string PromotionBookName { get; set; }
        public string EntityTargetUniqueId { get; set; }
        public string ChildrenCategoryList { get; set; }
        public string DefaultInventorySetName { get; set; }
        public string WorkflowEntityTarget { get; set; }
        public string WorkflowName { get; set; }
    }

}
