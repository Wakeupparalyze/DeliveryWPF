﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryWPF.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
