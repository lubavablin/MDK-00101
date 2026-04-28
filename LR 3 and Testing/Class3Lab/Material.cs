namespace LR_3
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PricePerUnit { get; set; }
        public string Category { get; set; }
        public string ImageName { get; set; }
        public override string ToString()
        {
            return $"{Name} - {PricePerUnit:C}";
        }
    }
}