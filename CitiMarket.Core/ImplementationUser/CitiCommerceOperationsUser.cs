using CitiMarket.Core.Implementation;
using CitiMarket.DataBaseConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiMarket.Core.ImplementationUser
{
    public class CitiCommerceOperationsUser
    {
        CitiCommerceOperations _citiOperations;
        public CitiCommerceOperationsUser(CitiCommerceOperations CitiOperations)
        {
            this._citiOperations = CitiOperations;
        }


        public CitiCommerceOperations DisplayTopSales()
        {
            return _citiOperations;
        }

    }
}
