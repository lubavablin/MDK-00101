using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3
{
    public class OrderItem
    {
       public Part Part { get; set; } 
       public Material Material { get; set; }
       public int Quality { get; set; }
        public decimal TotalCost => Material?.PricePerUnit * Quality ?? 0;
        public override string ToString()
        {
            return $"{Part.Name} - {Material.Name}: {Quality} шт. = {TotalCost:C}";
        }

    }
}
