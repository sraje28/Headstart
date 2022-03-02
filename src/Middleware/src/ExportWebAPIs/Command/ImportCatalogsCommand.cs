using OrderCloud.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExportWebAPIs.Command
{

    public interface IImportCatalogsCommand
    {
        Task<Catalog> CreateCatalog(Catalog catalog, IOrderCloudClient client);
        Task CreateCatalogAssignment(CatalogAssignment catalogAssignment, IOrderCloudClient client);
        Task ProductCatalogAssignment(ProductCatalogAssignment productCatalogAssignment, IOrderCloudClient client);
    }
    public class ImportCatalogsCommand : IImportCatalogsCommand
    {
        public async Task<Catalog> CreateCatalog(Catalog catalog, IOrderCloudClient client)
        {
            return await client.Catalogs.CreateAsync(catalog);
        }

        public async Task CreateCatalogAssignment(CatalogAssignment catalogAssignment, IOrderCloudClient client)
        {
            await client.Catalogs.SaveAssignmentAsync(catalogAssignment);
        }

        public async Task ProductCatalogAssignment(ProductCatalogAssignment productCatalogAssignment, IOrderCloudClient client)
        {
            await client.Catalogs.SaveProductAssignmentAsync(productCatalogAssignment);
        }

    }
}