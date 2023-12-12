// Account.cs

public class Account
{
    private int accountId;
    private Customer customer;
    private double balance;

    public Account(int accountId, Customer customer, double balance)
    {
        this.accountId = accountId;
        this.customer = customer;
        this.balance = balance;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Account ID: {accountId}");
        customer.DisplayInfo();
        Console.WriteLine($"Balance: {balance:C}");
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }
}
