﻿using ClassAbstractInterfaceProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstractInterfaceProjesi.Abstract
{
    public interface ICustomerService
    {
        void save(Customer customer); 
    }
}