﻿using AbstractVsInterface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface.Abstracts
{
    public  interface ICustomerService
    {
        void Save(Customer customer); 

    }
}
