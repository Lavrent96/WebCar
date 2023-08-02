using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Tire
    {
        public int Id { get; set; }
        public int Diameter { get; set; }
        public int Width { get; set; }
        public int AspectRatio { get; set; }
        public TireType TireType { get; set; }

        // Foreign key to relate CarModel to CarBrand
        public int CarModelId { get; set; }
        public CarModel CarModel { get; set; }
    }
}
