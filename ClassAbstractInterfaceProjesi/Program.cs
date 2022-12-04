using ClassAbstractInterfaceProjesi.Abstract;
using ClassAbstractInterfaceProjesi.Adapters;
using ClassAbstractInterfaceProjesi.Concrete;
using ClassAbstractInterfaceProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstractInterfaceProjesi
{
    class program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.save(new Customer
            {
                DateOfBirth = new DateTime(1985,1,6),
                FirstName = "engin",
                LastName = "demiroğ",
                NationalityId = "28861499108"
            });
            Console.ReadLine();
        }

    }
}
