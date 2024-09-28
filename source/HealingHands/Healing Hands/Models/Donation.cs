namespace Healing_Hands.Models
{
    public class Investor
    {
        public string InvestorName { get; set; }

        public Investor(string investorName)
        {
            InvestorName = investorName;
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
    public class Donation
    {
        public string DonorName { get; set; }

        public Donation(string donorName)
        {
            DonorName = donorName;
        }
    }
}
