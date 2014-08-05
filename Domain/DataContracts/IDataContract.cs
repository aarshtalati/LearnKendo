using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataContracts
{
    public interface IDataContract<C, D>
    {
        C ConvertDbToContract(D source);
        D ConvertContractToDb(C source);
    }
}
