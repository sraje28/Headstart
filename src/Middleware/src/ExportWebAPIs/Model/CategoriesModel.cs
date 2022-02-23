using Newtonsoft.Json;

namespace ExportWebAPIs.Model
{
    public class CategoriesModel
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<CategoriesValues> Values { get; set; }
    }

    public class CategoriesValues
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string SitecoreId { get; set; }
        public string ParentCatalogList { get; set; }
        public string ParentCategoryList { get; set; }
        public string ChildrenSellableItemList { get; set; }
        public bool IsBundle { get; set; }
        public CategoriesComponents Components { get; set; }
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
        public string ChildrenCategoryList { get; set; }
        public string CatalogToEntityList { get; set; }
    }

    public class CategoriesComponents
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<CategoryComponentValues> Values { get; set; }
    }

    public class CategoryComponentValues
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string Id { get; set; }
        public Childcomponents ChildComponents { get; set; }
        public Messages Messages { get; set; }
    }

    public class Childcomponents
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<ChildcomponentsValues> Values { get; set; }
    }

    public class ChildcomponentsValues
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Messages
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<MessagesValues> Values { get; set; }
    }

    public class MessagesValues
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string Code { get; set; }
        public string Text { get; set; }
        public string Id { get; set; }
    }

    public class ExtendedCategories
    {
        public string SitecoreId { get; set; }
        public string ParentCatalogList { get; set; }
        public string ChildrenSellableItemList { get; set; }
        public string FriendlyId { get; set; }
        public string UniqueId { get; set; }
        public CategoriesComponents categoriesComponents { get; set; }

    }

}
