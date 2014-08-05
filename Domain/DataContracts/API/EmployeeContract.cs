using NorthwindEntities.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.DataContracts.API
{
    class EmployeeContract : IDataContract<EmployeeContract, Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }

        public List<OrderContract> Orders { get; set; }

        public EmployeeContract ConvertDbToContract(Employee source)
        {
            throw new NotImplementedException();
        }

        public Employee ConvertContractToDb(EmployeeContract source)
        {
            throw new NotImplementedException();
        }
    }
}
