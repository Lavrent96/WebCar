using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EngineType EngineType { get; set; }          
        public decimal Price { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }

        // Foreign key to relate CarModel to CarBrand
        public int CarBrandId { get; set; }
        public CarBrand CarBrand { get; set; }

        // Navigation property to relate CarModel to Size
        public ICollection<TireSize> Tires { get; set; } = new List<TireSize>();    
    }
}
