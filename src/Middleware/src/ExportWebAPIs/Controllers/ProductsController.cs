using ExportWebAPIs.Command;
using ExportWebAPIs.Constants;
using ExportWebAPIs.Model;
using Microsoft.AspNetCore.Mvc;
using OrderCloud.SDK;

namespace ExportWebAPIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IImportProductsCommand _command;
        private readonly IConfiguration _config;

        public ProductsController(ILogger<ProductsController> logger, IImportProductsCommand command, IConfiguration config)
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
            var productsObj = ReadJsonData();

            foreach (var item in productsObj.Values)
            {
                await CreateProduct(client, item);

            }

        }

        public ProductsModel ReadJsonData()
        {
            string fileName = _config.GetValue<string>(OCConstants.ProductJsonPath);
            string myJsonResponse = System.IO.File.ReadAllText(fileName);

            myJsonResponse = myJsonResponse.Replace("$", ""); //Replacing $ sign

            ProductsModel productsObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductsModel>(myJsonResponse);
            return productsObj;
        }
        private async Task CreateProduct(IOrderCloudClient client, ProductValues productsObj)
        {

            var product = new Product
            {
                Name = productsObj.Name,
                Description = productsObj.Description,
                ID = productsObj.Id,
                OwnerID = "MPOrderCloud",
                Active = true,
                Inventory = new Inventory
                {
                    Enabled = true,
                    OrderCanExceed = false

                },
                xp = new ProductsExtendedProperty
                {
                    DisplayName = productsObj.DisplayName,
                    Brand = productsObj.Brand,
                    ProductId = productsObj.ProductId,                   
                    SitecoreId = productsObj.SitecoreId,
                    ParentCatalogList = productsObj.ParentCatalogList,  
                    ParentCategoryList = productsObj.ParentCategoryList,    
                    FriendlyId = productsObj.FriendlyId,
                    UniqueId = productsObj.UniqueId,
                    ItemVariations = productsObj.ItemVariations,
                    IsBundle = productsObj.IsBundle
                }
            };
            try
            {
                Product response = await _command.CreateProduct(product, client);

                await ProductAssignment(client, response);
            }

            catch (OrderCloudException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private async Task ProductAssignment(IOrderCloudClient client, Product response)
        {
            var productAssignment = new ProductAssignment
            {
                BuyerID = "0001",
                ProductID = response.ID
            };
            try
            {
                await _command.ProductAssignment(productAssignment, client);
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
