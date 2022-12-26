namespace WebApplication1.DTOs
{
    public class ProductCreateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Amount { get; set; }
        public decimal Price { get; set; }
    }
}
