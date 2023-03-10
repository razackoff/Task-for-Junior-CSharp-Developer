using Microsoft.AspNetCore.Identity;

namespace Task_for_Junior_CSharp_Developer.Models
{
    public class SmsSender
    {
        public string PhoneNumber { get; set; }
        public string Sms { get; set; }

        public void Send()
        {
            Console.WriteLine(PhoneNumber);
            Console.Write(Sms);
        }
    }
}
