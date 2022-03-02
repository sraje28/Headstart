using OrderCloud.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Headstart.Common;

namespace ExportWebAPIs.Command
{
   

    public interface IImportBuyersCommand
    {
       
        Task<Buyer> CreateBuyer(Buyer buyer, IOrderCloudClient client);
        Task<User> CreateBuyerUser(string buyerID, User user, IOrderCloudClient client);
        Task<Address> CreateBuyerAddress(string buyerID, Address address, IOrderCloudClient client);
        Task CreateBuyerAddressAssignment(string buyerID, AddressAssignment addressAssignment, IOrderCloudClient client);

    }
    public class ImportBuyersCommand : IImportBuyersCommand
    {

        public async Task<Buyer> CreateBuyer(Buyer buyer, IOrderCloudClient client)
        {
            return await client.Buyers.CreateAsync(buyer);
        }
        public async Task<User> CreateBuyerUser(string buyerID, User user, IOrderCloudClient client)
        {
            return await client.Users.CreateAsync(buyerID, user);
        }
        public async Task<Address> CreateBuyerAddress(string buyerID, Address address, IOrderCloudClient client)
        {
            return await client.Addresses.CreateAsync(buyerID, address);
        }

        public async Task CreateBuyerAddressAssignment(string buyerID, AddressAssignment addressAssignment, IOrderCloudClient client)            
        {
            await client.Addresses.SaveAssignmentAsync(buyerID, addressAssignment);
        }


    }
}
