﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary
{
    public class Customer : User
    {
        public Customer(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}
