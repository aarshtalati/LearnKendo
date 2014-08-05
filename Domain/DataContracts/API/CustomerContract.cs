using NorthwindEntities.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataContracts.API
{
    public class CustomerContract : IDataContract< CustomerContract, Customer>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string AddressString { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public List<OrderContract> Orders { get; set; }

        public CustomerContract ConvertDbToContract(Customer source)
        {
            return new CustomerContract
            {
                Id = source.CustomerID,
                Name = source.ContactName ?? "",
                Company = source.CompanyName ?? "",
                Title = source.ContactTitle ?? "",
                Address = source.Address ?? "",
                City = source.City ?? "",
                Region = source.Region ?? "",
                Zip = source.PostalCode ?? "",
                Country = source.Country ?? "",
                AddressString = string.Join(" ", new string[] { 
                    source.Address ?? "", 
                    source.City ?? "", 
                    source.Region ?? "", 
                    source.PostalCode ?? "", 
                    source.Country ?? ""}).Replace("  ", " "),
                Phone = source.Phone ?? "",
                Fax = source.Fax
            };
        }

        public Customer ConvertContractToDb(CustomerContract source)
        {
            throw new NotImplementedException();
        }
    }
}
