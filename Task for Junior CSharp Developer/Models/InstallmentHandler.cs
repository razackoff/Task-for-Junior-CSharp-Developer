using Market.Application.Common.Exceptions;

namespace Task_for_Junior_CSharp_Developer.Models
{
    public class InstallmentHandler
    {
        public string productСategory { get; set; }
        public decimal price { get; set; }
        private decimal summa;
        public decimal installmentRange { get; set; }
        private decimal installmentProcent = 0;
        

        public decimal GetInstallment() 
        {
            if(installmentRange == 3)
            {
                installmentRange = 1;
            }
            else if(installmentRange == 6) 
            {
                installmentRange = 2;
            }
            else if(installmentRange == 9)
            {
                installmentRange = 3;
            }
            else if(installmentRange == 12)
            {
                installmentRange = 4;
            }
            else if(installmentRange == 18)
            {
                installmentRange = 5;
            }
            else if(installmentRange == 24)
            {
                installmentRange = 6;
            }
            /*else
            {
                throw new NotFoundException();
            }*/
            if(productСategory == "Smartphone")
            {
                if(installmentRange > 3)
                {
                    installmentProcent = 3 * (installmentRange - 3);
                }
                Console.WriteLine(installmentRange.ToString());
            }
            else if(productСategory == "Computer")
            {
                if (installmentRange > 4)
                {
                    installmentProcent = 4 * (installmentRange - 4);
                }
            }
            else if(productСategory == "TV")
            {
                if (installmentRange > 5)
                {
                    installmentProcent = 5 * (installmentRange - 5);
                }
            }

            summa = price;
            summa += price / 100 * installmentProcent;
            return summa;
        }
    }
}
