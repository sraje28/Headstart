using ExportWebAPIs.Command;
using ExportWebAPIs.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OrderCloud.SDK;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using ExportWebAPIs.Constants;


namespace ExportWebAPIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly IImportBuyersCommand _command;
        private readonly IConfiguration _config;
        

        public CustomerController(ILogger<CustomerController> logger, IImportBuyersCommand command, IConfiguration config)
        {
            _logger = logger;
            _command = command;
            _config = config;
        }


        [HttpGet]
        public async Task Buyer()
        {
            var client = GetConfigData();

            //Read Json 
            var customerObj = ReadJsonData();
            var buyerObj = BuyerJsonData();

            foreach (var data in buyerObj.Values)
            {
                 await CreateBuyer(client, data);
            }
            foreach (var item in customerObj.Values)
            {
                await CreateBuyerUser(client, item);
                await CeateBuyerUserAddress(client, item);
            }
        }


        public BuyerModel BuyerJsonData()
        {
            string fileName = _config.GetValue<string>(OCConstants.BuyerJsonPath);
            string myJsonResponse = System.IO.File.ReadAllText(fileName);
            BuyerModel buyerObj = Newtonsoft.Json.JsonConvert.DeserializeObject<BuyerModel>(myJsonResponse);
            return buyerObj;
        }

        public CustomerModel ReadJsonData()
        {
            string fileName = _config.GetValue<string>(OCConstants.JsonFilePath);
            string myJsonResponse = System.IO.File.ReadAllText(fileName);

            myJsonResponse = myJsonResponse.Replace("$", ""); //Replacing $ sign

            CustomerModel customerObj = Newtonsoft.Json.JsonConvert.DeserializeObject<CustomerModel>(myJsonResponse);
            return customerObj;
        }

       

        private async Task CreateBuyer(IOrderCloudClient client, BuyerValues buyerObj )
        {
            var buyer = new Buyer
            {

                Name = buyerObj.Name, //config
                DateCreated = DateTime.Now,
                Active = true,
                ID = buyerObj.Id,
                DefaultCatalogID = "0001",   //Env specified Default Catalog ID
                //xp = new ExtendedBuyer
                //{
                //    UniqueId = customerObj.UniqueId,
                //    Version = customerObj.Version,
                //    Published = customerObj.Published,
                //    IsPersisted = customerObj.IsPersisted,
                //}

            };

            try
            {
                Buyer response = await _command.CreateBuyer(buyer, client);
            }

            catch (OrderCloudException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private async Task CreateBuyerUser(IOrderCloudClient client, _Values customerObj)
        {
            var maxConcurency = 5;
            var minPause = 100; // ms
            List<User> UserList = new List<User>();
            UserList.Add(new User
            {
                ID = customerObj.Id,
                FirstName = customerObj.FirstName,
                LastName = customerObj.LastName,
                Email = customerObj.Email,
                Password = "Customer@123",
                Username = customerObj.UserName,
                Active = true,
                xp = new ExtendedBuyerUser
                {
                    AccountNumber = customerObj.AccountNumber,
                    AccountStatus = customerObj.AccountStatus,
                    CreatedBy = customerObj.CreatedBy,
                    UpdatedBy = customerObj.UpdatedBy,
                    UpdatedDate = customerObj.DateUpdated
                }
            });

            try
            {
                // await _command.CreateBuyerUser("CustomBuyer001", user, client);
                await ExportWebAPIs.Throttler.Throttler.RunAsync(UserList, minPause, maxConcurency, user => _command.CreateBuyerUser("Default-Habitat-Buyer-001", user, client));
            }

            catch (OrderCloudException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private async Task CeateBuyerUserAddress(IOrderCloudClient client, _Values customerObj)
        {
            var address = customerObj.Components.Values[2].Party;
            var item = new Address
            {
                FirstName = address.FirstName,
                LastName = address.LastName,
                AddressName = address.AddressName,
                Phone = address.PhoneNumber,
                Street1 = address.Address1,
                State = address.State,
                City = address.City,
                Country = address.CountryCode,
                CompanyName = String.Concat(address.FirstName + " " + address.LastName),
                DateCreated = DateTimeOffset.Now,
                Zip = address.ZipPostalCode,
                xp = new ExtendedAddress
                {
                    CountryName = address.Country,
                    StateCode = address.StateCode,
                    IsPrimary = address.IsPrimary,
                }

            };

            try
            {
                Address response = await _command.CreateBuyerAddress("Default-Habitat-Buyer-001", item, client);
                await CreateBuyerAddressAssignment(client, customerObj, response);
            }

            catch (OrderCloudException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
        
        private async Task CreateBuyerAddressAssignment(IOrderCloudClient client, _Values customerObj, Address response)
        {
            var addressAssignment = new AddressAssignment
            {
                IsBilling = true,
                IsShipping = true,
                UserID = customerObj.Id,
                AddressID = response.ID,
            };

            try
            {
                await _command.CreateBuyerAddressAssignment("Default-Habitat-Buyer-001", addressAssignment, client);
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
              
            
