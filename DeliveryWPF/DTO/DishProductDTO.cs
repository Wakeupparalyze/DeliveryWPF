using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryWPF.DTO
{
    public class DishProductDTO
    {
        public int Id { get; set; }

        public int DishId { get; set; }

        public int ProductId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string Dish { get; set; } = null!;

        public string Product { get; set; } = null!;
    }
}
