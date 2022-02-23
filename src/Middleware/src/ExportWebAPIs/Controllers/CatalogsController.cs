using ExportWebAPIs.Command;
using ExportWebAPIs.Constants;
using ExportWebAPIs.Model;
using Microsoft.AspNetCore.Mvc;
using OrderCloud.SDK;

namespace ExportWebAPIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogsController : Controller
    {
        private readonly ILogger<CatalogsController> _logger;
        private readonly IImportCatalogsCommand _command;
        private readonly IConfiguration _config;


        public CatalogsController(ILogger<CatalogsController> logger, IImportCatalogsCommand command, IConfiguration config)
        {
            _logger = logger;
            _command = command;
            _config = config;
        }

        [HttpGet]
        public async Task Catalog()
        {
            var client = GetConfigData();

            //Read Json 
            var data = ReadJsonData();

            foreach (var item in data.Values)
            {
                await CreateCatalog(client, item);
                                
            }

        }

        public CatalogsModel ReadJsonData()
        {
            string fileName = _config.GetValue<string>(OCConstants.CatalogJsonPath);
            string myJsonResponse = System.IO.File.ReadAllText(fileName);

            myJsonResponse = myJsonResponse.Replace("$", ""); //Replacing $ sign

            CatalogsModel data = Newtonsoft.Json.JsonConvert.DeserializeObject<CatalogsModel>(myJsonResponse);
            return data;
        }

        private async Task CreateCatalog(IOrderCloudClient client, Values data)
        {
            var workflow = data.Components.Values[2].Workflow;
            var catalog = new Catalog
            {
                //ID = data.Id,
                OwnerID = "MPOrderCloud",
                Name = data.Name,
                Active = true,
                Description = data.Type,
                xp = new ExtendedCatalog
                {
                    WorkflowName = workflow.Name,
                    WorkflowEntityTarget = workflow.EntityTarget,
                    EntityTargetUniqueId = workflow.EntityTargetUniqueId,
                    FriendlyId = data.FriendlyId,
                    SitecoreId = data.SitecoreId,
                    PriceBookName = data.PriceBookName,
                    PromotionBookName = data.PromotionBookName,
                    DefaultInventorySetName = data.DefaultInventorySetName,
                    IsPublished = data.Published,
                    ChildrenCategoryList = data.ChildrenCategoryList
                    
                }
            };
            try
            {
                Catalog response = await _command.CreateCatalog(catalog, client);
                await CreateCatalogAssignment(client, response);
            }

            catch (OrderCloudException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task CreateCatalogAssignment(IOrderCloudClient client, Catalog response)
        {
            var catalogAssignment = new CatalogAssignment
            {
                CatalogID = response.ID,
                BuyerID = "0001",
                ViewAllCategories = true,
                ViewAllProducts = true
            };
            try
            {
                await _command.CreateCatalogAssignment(catalogAssignment, client);
            }

            catch (OrderCloudException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task ProductCatalogAssignment(IOrderCloudClient client, Catalog response, Product products)
        {
                var productcatalogAssignment = new ProductCatalogAssignment
                {
                    CatalogID = response.ID,
                    ProductID = products.ID
                };
            try
            {
                await _command.ProductCatalogAssignment(productcatalogAssignment, client);
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
