namespace SOLID_CSharp;

public class PaymentProcessor
{
    public void ProcessPayment(string paymentType)
    {
        if (paymentType == "CreditCard")
        {
            Console.WriteLine("Processing credit card payment.");
        }
        else if (paymentType == "BankTransfer")
        {
            Console.WriteLine("Processing bank transfer payment.");
        }
        else
        {
            throw new Exception("Unsupported payment type.");
        }
    }
}