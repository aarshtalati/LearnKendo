using NorthwindEntities.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.DataContracts.API
{
    public class OrderContract : IDataContract<OrderContract, Order>
    {
        public int Id { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }

        public string CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public int? ShipperId { get; set; }

        public OrderContract ConvertDbToContract(Order source)
        {
            throw new NotImplementedException();
        }

        public Order ConvertContractToDb(OrderContract source)
        {
            throw new NotImplementedException();
        }
    }
}
