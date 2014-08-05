using NorthwindEntities.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.DataContracts.API
{
    class ShipperContract : IDataContract<ShipperContract, Shipper>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public List<OrderContract> Orders { get; set; }

        public ShipperContract ConvertDbToContract(Shipper source)
        {
            throw new NotImplementedException();
        }

        public Shipper ConvertContractToDb(ShipperContract source)
        {
            throw new NotImplementedException();
        }
    }
}
