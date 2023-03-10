namespace Task_for_Junior_CSharp_Developer.Models
{
    public class PurchaseTransaction
    {
        public Guid TransactionID { get; set; }
        public string PhoneNumber { get; set; }
        public string ProductСategory { get; set; }
        public int InstallmentRange { get; set; }
        public decimal ProductCost { get; set; }
        public decimal summa { get; set; }
        
        public void Handle()
        {
            InstallmentHandler installmentHandler = new InstallmentHandler();
            installmentHandler.price = ProductCost;
            installmentHandler.installmentRange = InstallmentRange;
            installmentHandler.productСategory = ProductСategory;
            summa = installmentHandler.GetInstallment();
            
            SmsSender smsSender = new SmsSender();
            smsSender.PhoneNumber = PhoneNumber;
            smsSender.Sms = $"Transaction ID = {TransactionID} \n" +
                $"Phone Number = {PhoneNumber} \n" +
                $"Product Category = {ProductСategory} \n" +
                $"Installment Range = {InstallmentRange} \n" +
                $"Product Cost = {summa}";
            smsSender.Send();
        }
    }
}
