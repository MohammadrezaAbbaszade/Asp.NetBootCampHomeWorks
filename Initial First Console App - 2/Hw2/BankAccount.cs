namespace Initial_First_Console_App___2.Hw2;

public class BankAccount
{
    
    private double balance;

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void WithDraw(double amount)
    {
        if (balance < amount)
        {
            Console.WriteLine($"Your balance is not Enough!");
        }
        else
        {
            balance -= amount;
        }
    }
    
    public void ShowBalance()
    {
        Console.WriteLine($"Your balance  {balance}");
    }

    public static void Run()
    {
        BankAccount account = new BankAccount();
        account.Deposit(5);
        account.ShowBalance();
        account.WithDraw(6);
        account.ShowBalance();
    }
}