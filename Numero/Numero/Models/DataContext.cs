﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Numero.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")//Constructor
        {

        }
    }
}