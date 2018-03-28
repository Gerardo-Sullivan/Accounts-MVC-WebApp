namespace ConsoleApp_HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account newAccount = new Account("Gerardo", "password", 23, "New Zealand");

            var test = newAccount.Purchases;

            newAccount.AddPurchase(new Purchase(newAccount.AccountID, "Car"));
            newAccount.AddPurchase(new Purchase(newAccount.AccountID, "Phone"));
            newAccount.PrintInfo();
        }
    }
}
