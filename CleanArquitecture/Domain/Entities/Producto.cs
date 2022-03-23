using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Producto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int Caduca { get; set; }

    }
}
