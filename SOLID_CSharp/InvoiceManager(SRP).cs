namespace SOLID_CSharp;

public class InvoiceManager
{
    public string CreateInvoice(int customerId, int amount)
    {
        string invoice = $"Customer : {customerId} pay shawerma with Amount: {amount}$";
        return invoice;
    }

    public void SendEmailToCustomer(string email)
    {
        string invoice = CreateInvoice(1, 50);
        Console.WriteLine($"Sending email to : {email} with Email: {invoice}");
    }

    public void SaveInvoceToDb()
    {
        string invoice = CreateInvoice(1, 50);
        Console.WriteLine($"Saving invoice: {invoice}");
    }
}