using Newtonsoft.Json;

namespace ExportWebAPIs.Model
{
    public class ProductsModel
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<ProductValues> Values { get; set; }
    }

    public class ProductValues
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string ProductId { get; set; }
        public Tags Tags { get; set; }
        public string SitecoreId { get; set; }
        public string ParentCatalogList { get; set; }
        public string ParentCategoryList { get; set; }
        public bool IsBundle { get; set; }
        public ProductComponents Components { get; set; }
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
        public Policies Policies { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string ItemVariations { get; set; }
    }

    public class Tags
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<TagValues> Values { get; set; }
    }

    public class TagValues
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public bool Excluded { get; set; }
        public string Name { get; set; }
    }

    public class ProductComponents
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<ProdComponentsValues> Values { get; set; }
    }

    public class ProdComponentsValues
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string BundleType { get; set; }
        public Bundleitems BundleItems { get; set; }
        public string Id { get; set; }
        public Images Images { get; set; }
        public ProdChildcomponents ChildComponents { get; set; }
        public ProductMessages Messages { get; set; }
    }

    public class Bundleitems
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<BundleItemValues> Values { get; set; }
    }

    public class BundleItemValues
{
        [JsonProperty("type")]
        public string Type { get; set; }
        public string SellableItemId { get; set; }
        public int Quantity { get; set; }
    }

    public class Images
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<object> Values { get; set; }
    }

    public class ProdChildcomponents
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<ChildComponentValues> Values { get; set; }
    }

    public class ChildComponentValues
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string ItemDefinition { get; set; }
        public string DisplayName { get; set; }
        public Tags1 Tags { get; set; }
        public bool Disabled { get; set; }
        public Policies1 Policies { get; set; }
        public ProdChildcomponents1 ChildComponents { get; set; }
    }

    public class Tags1
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<TagValues1> Values { get; set; }
    }

    public class TagValues1
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public bool Excluded { get; set; }
        public string Name { get; set; }
    }

    public class Policies
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<PoliciesValues> Values { get; set; }
    }

    public class PoliciesValues
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public Prices Prices { get; set; }
        public string PolicyId { get; set; }
        public string PriceCardName { get; set; }
    }

    public class Prices
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<PriceValues> Values { get; set; }
    }

    public class PriceValues
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string CurrencyCode { get; set; }
        public float Amount { get; set; }
    }

    public class ProdChildcomponents1
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<ProdChildcomponents1Values> Values { get; set; }
    }

    public class ProdChildcomponents1Values
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public Images1 Images { get; set; }
        public string Id { get; set; }
        public Inventoryassociations InventoryAssociations { get; set; }
        public bool DisplayOnSite { get; set; }
        public bool DisplayInProductList { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
    }

    public class Images1
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<object> Values { get; set; }
    }

    public class Inventoryassociations
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<InventoryassociationsValues> Values { get; set; }
    }

    public class InventoryassociationsValues
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public Inventoryinformation InventoryInformation { get; set; }
        public Inventoryset InventorySet { get; set; }
    }

    public class Inventoryinformation
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string EntityTarget { get; set; }
    }

    public class Inventoryset
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string EntityTarget { get; set; }
    }

    public class ProductMessages
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<ProductMessagesValues> Values { get; set; }
    }

    public class ProductMessagesValues
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string Code { get; set; }
        public string Text { get; set; }
        public string Id { get; set; }
    }

    public class Policies1
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<PoliciesValues1> Values { get; set; }
    }

    public class PoliciesValues1
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public Prices1 Prices { get; set; }
        public string PolicyId { get; set; }
        public string PriceCardName { get; set; }
    }

    public class Prices1
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<PriceValues1> Values { get; set; }
    }

    public class PriceValues1
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string CurrencyCode { get; set; }
        public float Amount { get; set; }
    }

    public class ProductsExtendedProperty
    {
        public string ProductId { get; set; }
        public string SitecoreId { get; set; }
        public string ParentCatalogList { get; set; }
        public string ParentCategoryList { get; set; }
        public bool IsBundle { get; set; }
        public string DisplayName { get; set; }
        public string FriendlyId { get; set; }
        public string UniqueId { get; set; }
        public string Brand { get; set; }
        public string ItemVariations { get; set; }
    }

}
