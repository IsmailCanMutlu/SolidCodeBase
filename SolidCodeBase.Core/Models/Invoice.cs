namespace SolidCodeBase.Core.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }
}