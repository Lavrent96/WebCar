using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TireSize
    {
        public int Id { get; set; }
        public int Diameter { get; set; }
        public int Width { get; set; }
        public int AspectRatio { get; set; }
    }
}
