﻿using AbstractVsInterface.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface.Entities
{
    public class Customer: IEntity
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string LastName { get; set; }    
        public DateTime DateOfBirth { get; set; }   
        public string NationalityId { get; set; }   
    }

    
}
