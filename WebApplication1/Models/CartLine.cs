﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

}