using ClassAbstractInterfaceProjesi.Abstract;
using ClassAbstractInterfaceProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstractInterfaceProjesi.Concrete
{
    public class NeroCustomerManager :BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;
        public NeroCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
