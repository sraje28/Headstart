using ExportWebAPIs.Command;
using ExportWebAPIs.Constants;
using ExportWebAPIs.Model;
using Microsoft.AspNetCore.Mvc;
using OrderCloud.SDK;

namespace ExportWebAPIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ILogger<CategoriesController> _logger;
        private readonly IImportCategoriesCommand _command;
        private readonly IConfiguration _config;

        public CategoriesController(ILogger<CategoriesController> logger, IImportCategoriesCommand command, IConfiguration config)
        {
            _logger = logger;
            _command = command;
            _config = config;
        }


        [HttpGet]
        public async Task Category()
        {
            var client = GetConfigData();

            //Read Json 
            var categoriesObj = ReadJsonData();

            foreach (var item in categoriesObj.Values)
            {
                await CreateCategory(client, item);

            }

        }

        public CategoriesModel ReadJsonData()
        {
            string fileName = _config.GetValue<string>(OCConstants.CategoryJsonPath);
            string myJsonResponse = System.IO.File.ReadAllText(fileName);

            myJsonResponse = myJsonResponse.Replace("$", ""); //Replacing $ sign
            myJsonResponse = myJsonResponse.Replace(" ", "");

            CategoriesModel categoriesObj = Newtonsoft.Json.JsonConvert.DeserializeObject<CategoriesModel>(myJsonResponse);
            return categoriesObj;
        }
        private async Task CreateCategory(IOrderCloudClient client, CategoriesValues categoriesObj)
        {
            
            var category = new Category
            {
                
                ID = categoriesObj.Id,
                Name = categoriesObj.Name,
               // ParentID = data.ParentCategoryList,
                Active = true,
                xp = new ExtendedCategories
                {
                    SitecoreId = categoriesObj.SitecoreId,
                    FriendlyId = categoriesObj.FriendlyId,
                    UniqueId = categoriesObj.UniqueId,
                    ParentCatalogList = categoriesObj.ParentCatalogList,
                    ChildrenSellableItemList = categoriesObj.ChildrenSellableItemList
                    
                }
            };
            try
            {
                Category response = await _command.CreateCategory("Entity-Catalog-Habitat_Master", category, client);
                await CreateCategoryAssignment(client, response);

            }

            catch (OrderCloudException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private async Task CreateCategoryAssignment(IOrderCloudClient client, Category response)
        {
            var categoryAssignment = new CategoryAssignment
            {
                CategoryID = response.ID,
                BuyerID = "0001",
                ViewAllProducts = true,
                Visible = true

            };

            try
            {
                 await _command.CreateCategoryAssignment("Entity-Catalog-Habitat_Master", categoryAssignment, client);

            }

            catch (OrderCloudException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public IOrderCloudClient GetConfigData()
        {
            return new OrderCloudClient(new OrderCloudClientConfig
            {
                ClientId = _config.GetValue<string>(OCConstants.AdminClientId),
                Username = _config.GetValue<string>(OCConstants.AdminUserName),
                Password = _config.GetValue<string>(OCConstants.AdminPassword),
                GrantType = GrantType.Password,
                Roles = new[] {
                    ApiRole.MeAdmin,
                    ApiRole.PasswordReset,
                    ApiRole.BuyerReader,
                    ApiRole.BuyerAdmin,
                    ApiRole.OrderAdmin,
                    ApiRole.CatalogAdmin,
                    ApiRole.ProductAdmin,
                    ApiRole.ProductAssignmentAdmin,
                    ApiRole.PriceScheduleAdmin,
                    ApiRole.ShipmentAdmin,
                    ApiRole.BuyerUserAdmin,
                    ApiRole.AdminUserAdmin,
                    ApiRole.AddressAdmin,
                    ApiRole.AdminAddressAdmin
                },
                ApiUrl = _config.GetValue<string>(OCConstants.ApiUrl),
                AuthUrl = _config.GetValue<string>(OCConstants.AuthUrl)
            });
        }
    }
}
