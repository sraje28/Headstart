
using OrderCloud.SDK;

namespace ExportWebAPIs.Command
{ 
    public interface IImportProductsCommand
    {
        Task<Product> CreateProduct(Product product, IOrderCloudClient client);
        Task ProductAssignment(ProductAssignment productAssignment, IOrderCloudClient client);
        Task<Product> GenerateVariant(string productID, bool overwriteExisting, IOrderCloudClient client);
        Task UpdateProductSupplier(string productID, string supplierID, string defaultPriceScheduleID, IOrderCloudClient client);
        Task UpdateProductVariant(string productID, string variantID, Variant variant, IOrderCloudClient client);
    }
    public class ImportProductsCommand : IImportProductsCommand
    {
        public async Task<Product> CreateProduct(Product product, IOrderCloudClient client)
        {
            return await client.Products.CreateAsync(product);
        }

        public async Task ProductAssignment(ProductAssignment productAssignment, IOrderCloudClient client)
        {
            await client.Products.SaveAssignmentAsync(productAssignment);
        }

        public async Task<Product> GenerateVariant(string productID, bool overwriteExisting, IOrderCloudClient client)
        {
            return await client.Products.GenerateVariantsAsync(productID, overwriteExisting);
        }

        public async Task UpdateProductSupplier(string productID, string supplierID, string defaultPriceScheduleID, IOrderCloudClient client)
        {
            await client.Products.SaveSupplierAsync(productID, supplierID, defaultPriceScheduleID);
        }

        public async Task UpdateProductVariant(string productID, string variantID, Variant variant, IOrderCloudClient client)
        {
            await client.Products.SaveVariantAsync(productID, variantID, variant);
        }
    }
}

