using ClassAbstractInterfaceProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstractInterfaceProjesi.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void save(Customer customer)
        {
            Console.WriteLine("Saved to db : "  +customer.FirstName);
        }
    }
}
