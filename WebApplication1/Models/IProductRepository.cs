﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
