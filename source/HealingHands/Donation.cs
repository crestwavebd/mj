namespace Healing_Hands.Models
{
    public class Donation
    {
        public string DonorName { get; set; }

        public Donation(string donorName)
        {
            DonorName = donorName;
        }
    }
}
