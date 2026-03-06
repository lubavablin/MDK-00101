using System.Collections.Generic;

namespace LR_3
{
    public class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Material> RequiredMaterials { get; set; }
        public Part()
        {
            RequiredMaterials = new List<Material>();
        }
        public override string ToString()
        {
            return Name;
        }
   }
}