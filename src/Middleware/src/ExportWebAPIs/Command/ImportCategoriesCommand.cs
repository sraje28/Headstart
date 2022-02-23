using OrderCloud.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExportWebAPIs.Command
{

    public interface IImportCategoriesCommand
    {
        Task<Category> CreateCategory(string catalogID, Category category, IOrderCloudClient client);
        Task CreateCategoryAssignment( string catalogID, CategoryAssignment categoryAssignment, IOrderCloudClient client);
        Task CategoryProductAssignment(string catalogID,CategoryProductAssignment categoryProductAssignment, IOrderCloudClient client);
    }
    public class ImportCategoriesCommand : IImportCategoriesCommand
    {
        public async Task<Category> CreateCategory(string catalogID, Category category, IOrderCloudClient client)
        {
            return await client.Categories.CreateAsync(catalogID, category);
        }

        public async Task CreateCategoryAssignment(string catalogID, CategoryAssignment categoryAssignment, IOrderCloudClient client)
        {
            await client.Categories.SaveAssignmentAsync(catalogID, categoryAssignment);          
        }

        public async Task CategoryProductAssignment(string catalogID,CategoryProductAssignment categoryProductAssignment, IOrderCloudClient client)
        {
            await client.Categories.SaveProductAssignmentAsync(catalogID,categoryProductAssignment);
        }
    }
}
   
