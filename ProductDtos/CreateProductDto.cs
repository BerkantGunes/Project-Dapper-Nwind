﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5_DapperNorthwind.DTOs.ProductDtos
{
    public class CreateProductDto
    {
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int CategoryId { get; set; }
    }
}
