using System;

namespace Task_for_Junior_CSharp_Developer.Models
{
    public class PurchaseTransactionDto
    {
        public string productName { get; set; }
        public decimal productCost { get; set; }
        public string phoneNumber { get; set; }
        public int installmentRange { get; set; }
    }
}
