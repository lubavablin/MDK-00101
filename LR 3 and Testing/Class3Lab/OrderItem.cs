using System;
using System.Collections.Generic;
using System.Linq;

namespace LR_3
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public decimal TotalCost { get; set; } 
        public Part Part { get; set; }
        public List<Material> Materials { get; set; }
        public int Quality { get; set; } 

        public OrderItem()
        {
            Materials = new List<Material>();
            TotalCost = 0;
        }
        public void CalculateTotalCost()
        {
            if (Part != null && Materials != null)
            {
                TotalCost = Materials.Sum(m => m.PricePerUnit) * Quantity;
            }
        }
        public override string ToString()
        {
            if (Part != null && Materials != null && Materials.Any())
            {
                return $"{Part.Name} - {Materials[0].Name}: {Quantity} шт. = {TotalCost:C}";
            }
            return $"OrderItem: {Quantity} шт.";
        }
    }
}