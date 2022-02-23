
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace ExportWebAPIs.Model
{

    public class CustomerModel
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<_Values> Values { get; set; }
    }

    public class _Values
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string AccountStatus { get; set; }
        public string AccountNumber { get; set; }
        public string? Password { get; set; }
        public _Tags Tags { get; set; }
        public _Components Components { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string? DisplayName { get; set; }
        public string FriendlyId { get; set; }
        public string Id { get; set; }
        public int Version { get; set; }
        public bool Published { get; set; }
        public bool IsPersisted { get; set; }
        public string? Name { get; set; }
        public string UniqueId { get; set; }
        public _Policies Policies { get; set; }
        public string UserName { get; set; }
    }

    public class _Tags
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<object> Values { get; set; }
    }

    public class _Components
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<_ComponentValues> Values { get; set; }

    }

    public class _ComponentValues
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public _View View { get; set; }
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Comments { get; set; }
        public _Policies Policies { get; set; }
        public _ChildComponents ChildComponents { get; set; }
        public _Memberships Memberships { get; set; }
        public _Party Party { get; set; }
    }

    public class _View
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string? DisplayName { get; set; }
        public string? EntityId { get; set; }
        public int EntityVersion { get; set; }
        public string? Action { get; set; }
        public string? ItemId { get; set; }
        public string VersionedItemId { get; set; }
        public _Selectedchildview SelectedChildView { get; set; }
        public int DisplayRank { get; set; }
        public string UiHint { get; set; }
        public string Icon { get; set; }
        public _Properties1 Properties { get; set; }
        public _Childviews ChildViews { get; set; }
        public string? Name { get; set; }
        public _Policies Policies { get; set; }
    }

    public class _Properties1
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<object> Values { get; set; }

    }

    public class _Selectedchildview
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string Name { get; set; }
        public _Policies Policies { get; set; }
    }

    public class _Policies
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<object> Values { get; set; }
    }

    public class _Properties
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<_PropertiesValues> Values { get; set; }
    }

    public class _PropertiesValues
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string DisplayName { get; set; }
        public string RawValue { get; set; }
        public string Value { get; set; }
        public bool IsHidden { get; set; }
        public string OriginalType { get; set; }
        public bool IsReadOnly { get; set; }
        public string? UiType { get; set; }
        public bool IsRequired { get; set; }
        public string Name { get; set; }
        public _Policies Policies { get; set; }
    }

    public class _ChildComponents
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<object> Values { get; set; }

    }

    public class _Childviews
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<_ChildviewsValues> Values { get; set; }
    }

    public class _ChildviewsValues
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string? DisplayName { get; set; }
        public string? EntityId { get; set; }
        public int EntityVersion { get; set; }
        public string? Action { get; set; }
        public string? ItemId { get; set; }
        public string VersionedItemId { get; set; }
        public _Selectedchildview SelectedChildView { get; set; }
        public int DisplayRank { get; set; }
        public string UiHint { get; set; }
        public string Icon { get; set; }
        public _Properties Properties { get; set; }
        public _Childviews1 ChildViews { get; set; }
        public string Name { get; set; }
        public _Policies Policies { get; set; }

    }

    public class _Childviews1
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<object> Values { get; set; }
    }

    public class _Memberships
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public List<object> Values { get; set; }
    }

    public class _Party
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        public string Country { get; set; }
        public string AddressName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CountryCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address1 { get; set; }
        public string ZipPostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsPrimary { get; set; }
        public string StateCode { get; set; }
        public string? Name { get; set; }
        public _Policies Policies { get; set; }

    }

    public class ExtendedAddress
    {
        public string  CountryName { get; set; }
        public string  StateCode { get; set; }
        public bool IsPrimary { get; set; }
    }

    public class ExtendedBuyer
    {
        public string UniqueId { get; set; }
        public bool Published { get; set; }
        public int Version { get; set; }
        public int EntityVersion { get; set; }
        public bool IsPersisted { get; set; }
    }

    public class ExtendedBuyerUser
    {
        public string AccountStatus { get; set; }
        public string AccountNumber { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}


