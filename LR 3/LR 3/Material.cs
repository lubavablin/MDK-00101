using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3
{
    public class Material
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Descriptioon { get; set; }
        public decimal PricePerUnit { get; set; }
        public string Supplier { get; set; }
        public string Category { get; set; }
        public string ImageName { get; set; }
        public override string ToString()
        {
            return $"{ Name } - {PricePerUnit:C}";
        }
    }
}
