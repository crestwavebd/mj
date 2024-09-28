namespace Healing_Hands.Models
{
    public class Investor(string investorName)
    {
        public required string InvestorName { get; set; } = investorName;
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
