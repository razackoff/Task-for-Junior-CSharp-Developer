namespace Task_for_Junior_CSharp_Developer.Models
{
    public class PurchaseTransaction
    {
        public Guid TransactionID { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public string ProductName { get; set; }
        public int InstallmentRange { get; set; }
        public decimal ProductCost { get; set; }

    }
}
