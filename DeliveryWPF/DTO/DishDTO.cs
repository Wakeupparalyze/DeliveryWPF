using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryWPF.DTO
{
    public class DishDTO
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public decimal Price { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
