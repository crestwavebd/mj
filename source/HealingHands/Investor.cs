public class Investor
{
    public required string InvestorName { get; set; }

    public Investor(string investorName)
    {
        InvestorName = investorName;
    }
}
